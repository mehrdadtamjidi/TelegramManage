using Microsoft.VisualBasic;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using TL;

namespace TelegramManage
{
    public partial class MainForm : Form
    {
        private readonly ManualResetEventSlim _codeReady = new();
        private WTelegram.Client _client;
        private User _user;

        public MainForm()
        {
            InitializeComponent();
            WTelegram.Helpers.Log = (l, s) => Debug.WriteLine(s);

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _client?.Dispose();
            Properties.Settings.Default.Save();
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(((LinkLabel)sender).Tag as string);
        }

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            buttonLogin.Enabled = false;
            listBox.Items.Add($"Connecting & login into Telegram servers...");
            _client = new WTelegram.Client(Config);
            _user = await _client.LoginUserIfNeeded();
            panelActions.Visible = true;
            listBox.Items.Add($"We are now connected as {_user}");
        }

        string Config(string what)
        {
            switch (what)
            {
                case "api_id": return textBoxApiID.Text.Trim();
                case "api_hash": return textBoxApiHash.Text.Trim();
                case "phone_number": return textBoxPhone.Text.Trim();
                case "verification_code":
                case "password":
                    BeginInvoke(new Action(() => CodeNeeded(what.Replace('_', ' '))));
                    _codeReady.Reset();
                    _codeReady.Wait();
                    return textBoxCode.Text;
                default: return null;
            };
        }

        private void CodeNeeded(string what)
        {
            labelCode.Text = what + ':';
            textBoxCode.Text = "";
            labelCode.Visible = textBoxCode.Visible = buttonSendCode.Visible = true;
            textBoxCode.Focus();
            listBox.Items.Add($"A {what} is required...");
        }

        private void buttonSendCode_Click(object sender, EventArgs e)
        {
            labelCode.Visible = textBoxCode.Visible = buttonSendCode.Visible = false;
            _codeReady.Set();
        }

        private async void buttonGetChats_Click(object sender, EventArgs e)
        {
            if (_user == null)
            {
                MessageBox.Show("You must login first.");
                return;
            }
            var chats = await _client.Messages_GetAllChats(null);
            listBox.Items.Clear();
            foreach (var chat in chats.chats.Values)
                switch (chat)
                {
                    case Chat smallgroup when (smallgroup.flags & Chat.Flags.deactivated) == 0:
                        Console.WriteLine($"{smallgroup.id}:  Small group: {smallgroup.title} with {smallgroup.participants_count} members");
                        break;
                    case Channel channel when (channel.flags & Channel.Flags.broadcast) != 0:
                        Console.WriteLine($"{channel.id}: Channel {channel.username}: {channel.title}");
                        break;
                    case Channel group:
                        Console.WriteLine($"{group.id}: Group {group.username}: {group.title}");

                        listBox.Items.Add(chat);
                        break;
                }
        }

        private async void buttonGetMembers_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem is not ChatBase chat)
            {
                MessageBox.Show("You must select a chat in the list first");
                return;
            }

            var users = chat is Channel channel
                ? (await _client.Channels_GetAllParticipants(channel)).users
                : (await _client.Messages_GetFullChat(chat.ID)).users;
            listBox.Items.Clear();

            int i = 0;

            string path = Application.StartupPath + "\\file\\scrapper.txt";

            //if (!File.Exists(path))
            //         {
            //	using (StreamWriter file = new StreamWriter(path, true))
            //	{
            //			file.WriteLine("username,user id,name,group");
            //	}
            //}

            foreach (var user in users.Values)
            {
                if (!string.IsNullOrEmpty(user.username) && !user.username.Contains("bot"))
                {
                    using (StreamWriter file = new StreamWriter(path, true))
                    {
                        //file.WriteLine($"@{user.username},{user.id},{user.first_name +' '+ user.last_name},{chat.Title}");
                        file.WriteLine($"@{user.username}");
                    }

                    listBox.Items.Add(user);
                    i++;
                }
            }
            MessageBox.Show($"finish with {i.ToString()} items");
        }

        private async void buttonSendMsg_Click(object sender, EventArgs e)
        {
            var msg = Interaction.InputBox("Type some text to send to ourselves\n(Saved Messages)", "Send to self");
            if (!string.IsNullOrEmpty(msg))
            {
                msg = "_Here is your *saved message*:_\n" + Markdown.Escape(msg);
                var entities = _client.MarkdownToEntities(ref msg);
                await _client.SendMessageAsync(InputPeer.Self, msg, entities: entities);
            }
        }
    }
}
