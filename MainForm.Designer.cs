
namespace TelegramManage
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonGetChats = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCode = new System.Windows.Forms.Label();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.buttonSendCode = new System.Windows.Forms.Button();
            this.panelActions = new System.Windows.Forms.Panel();
            this.buttonSendMsg = new System.Windows.Forms.Button();
            this.buttonGetMembers = new System.Windows.Forms.Button();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxApiHash = new System.Windows.Forms.TextBox();
            this.textBoxApiID = new System.Windows.Forms.TextBox();
            this.panelActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(266, 31);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(84, 21);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Connect/Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonGetChats
            // 
            this.buttonGetChats.Location = new System.Drawing.Point(2, 2);
            this.buttonGetChats.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGetChats.Name = "buttonGetChats";
            this.buttonGetChats.Size = new System.Drawing.Size(79, 29);
            this.buttonGetChats.TabIndex = 1;
            this.buttonGetChats.Text = "Get chats";
            this.buttonGetChats.UseVisualStyleBackColor = true;
            this.buttonGetChats.Click += new System.EventHandler(this.buttonGetChats_Click);
            // 
            // listBox
            // 
            this.listBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(9, 96);
            this.listBox.Margin = new System.Windows.Forms.Padding(2);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(629, 251);
            this.listBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(2);
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "api_id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(2);
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "api_hash:";
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.LinkArea = new System.Windows.Forms.LinkArea(13, 28);
            this.linkLabel.Location = new System.Drawing.Point(424, 11);
            this.linkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Padding = new System.Windows.Forms.Padding(2);
            this.linkLabel.Size = new System.Drawing.Size(214, 21);
            this.linkLabel.TabIndex = 7;
            this.linkLabel.TabStop = true;
            this.linkLabel.Tag = "https://my.telegram.org/apps";
            this.linkLabel.Text = "get these at https://my.telegram.org/apps";
            this.linkLabel.UseCompatibleTextRendering = true;
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(2);
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "user phone number:";
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCode.Location = new System.Drawing.Point(355, 32);
            this.labelCode.Margin = new System.Windows.Forms.Padding(0);
            this.labelCode.Name = "labelCode";
            this.labelCode.Padding = new System.Windows.Forms.Padding(2);
            this.labelCode.Size = new System.Drawing.Size(110, 17);
            this.labelCode.TabIndex = 11;
            this.labelCode.Text = "verification code:";
            this.labelCode.Visible = false;
            // 
            // textBoxCode
            // 
            this.textBoxCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCode.Location = new System.Drawing.Point(460, 32);
            this.textBoxCode.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(76, 19);
            this.textBoxCode.TabIndex = 10;
            this.textBoxCode.Visible = false;
            // 
            // buttonSendCode
            // 
            this.buttonSendCode.Location = new System.Drawing.Point(539, 31);
            this.buttonSendCode.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSendCode.Name = "buttonSendCode";
            this.buttonSendCode.Size = new System.Drawing.Size(61, 21);
            this.buttonSendCode.TabIndex = 12;
            this.buttonSendCode.Text = "Verify";
            this.buttonSendCode.UseVisualStyleBackColor = true;
            this.buttonSendCode.Visible = false;
            this.buttonSendCode.Click += new System.EventHandler(this.buttonSendCode_Click);
            // 
            // panelActions
            // 
            this.panelActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelActions.Controls.Add(this.buttonSendMsg);
            this.panelActions.Controls.Add(this.buttonGetMembers);
            this.panelActions.Controls.Add(this.buttonGetChats);
            this.panelActions.Location = new System.Drawing.Point(9, 57);
            this.panelActions.Margin = new System.Windows.Forms.Padding(2);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(628, 34);
            this.panelActions.TabIndex = 13;
            this.panelActions.Visible = false;
            // 
            // buttonSendMsg
            // 
            this.buttonSendMsg.Location = new System.Drawing.Point(169, 2);
            this.buttonSendMsg.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSendMsg.Name = "buttonSendMsg";
            this.buttonSendMsg.Size = new System.Drawing.Size(79, 29);
            this.buttonSendMsg.TabIndex = 3;
            this.buttonSendMsg.Text = "Send to self...";
            this.buttonSendMsg.UseVisualStyleBackColor = true;
            this.buttonSendMsg.Visible = false;
            this.buttonSendMsg.Click += new System.EventHandler(this.buttonSendMsg_Click);
            // 
            // buttonGetMembers
            // 
            this.buttonGetMembers.Location = new System.Drawing.Point(86, 2);
            this.buttonGetMembers.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGetMembers.Name = "buttonGetMembers";
            this.buttonGetMembers.Size = new System.Drawing.Size(79, 29);
            this.buttonGetMembers.TabIndex = 2;
            this.buttonGetMembers.Text = "Get members";
            this.buttonGetMembers.UseVisualStyleBackColor = true;
            this.buttonGetMembers.Click += new System.EventHandler(this.buttonGetMembers_Click);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TelegramManage.Properties.Settings.Default, "phone_number", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhone.Location = new System.Drawing.Point(138, 32);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(125, 19);
            this.textBoxPhone.TabIndex = 8;
            this.textBoxPhone.Text = global::TelegramManage.Properties.Settings.Default.phone_number;
            // 
            // textBoxApiHash
            // 
            this.textBoxApiHash.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TelegramManage.Properties.Settings.Default, "api_hash", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxApiHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApiHash.Location = new System.Drawing.Point(203, 10);
            this.textBoxApiHash.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxApiHash.Name = "textBoxApiHash";
            this.textBoxApiHash.Size = new System.Drawing.Size(217, 19);
            this.textBoxApiHash.TabIndex = 5;
            this.textBoxApiHash.Text = global::TelegramManage.Properties.Settings.Default.api_hash;
            // 
            // textBoxApiID
            // 
            this.textBoxApiID.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TelegramManage.Properties.Settings.Default, "api_id", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxApiID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApiID.Location = new System.Drawing.Point(57, 10);
            this.textBoxApiID.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxApiID.Name = "textBoxApiID";
            this.textBoxApiID.Size = new System.Drawing.Size(76, 19);
            this.textBoxApiID.TabIndex = 3;
            this.textBoxApiID.Text = global::TelegramManage.Properties.Settings.Default.api_id;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 356);
            this.Controls.Add(this.panelActions);
            this.Controls.Add(this.buttonSendCode);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxApiHash);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxApiID);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.buttonLogin);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(626, 251);
            this.Name = "MainForm";
            this.Text = "TelegramManage - M@T";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panelActions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonGetChats;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox textBoxApiID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxApiHash;
        private System.Windows.Forms.LinkLabel linkLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Button buttonSendCode;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Button buttonGetMembers;
        private System.Windows.Forms.Button buttonSendMsg;
    }
}

