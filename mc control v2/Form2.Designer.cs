namespace mc_control_v2
{
    partial class Form2
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
            gamemodeDrop = new ComboBox();
            groupBox1 = new GroupBox();
            radio_unban = new RadioButton();
            pardontextbox = new TextBox();
            radio_pardonip = new RadioButton();
            kbreasontextbox = new TextBox();
            radio_Ipban = new RadioButton();
            radio_Ban = new RadioButton();
            radio_Kick = new RadioButton();
            radio_Deop = new RadioButton();
            radio_OP = new RadioButton();
            radio_Gamemode = new RadioButton();
            label1 = new Label();
            usernametextbox = new TextBox();
            playerExecute = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            richTextLog = new RichTextBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // gamemodeDrop
            // 
            gamemodeDrop.DropDownStyle = ComboBoxStyle.DropDownList;
            gamemodeDrop.FormattingEnabled = true;
            gamemodeDrop.Location = new Point(128, 50);
            gamemodeDrop.Name = "gamemodeDrop";
            gamemodeDrop.Size = new Size(121, 23);
            gamemodeDrop.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radio_unban);
            groupBox1.Controls.Add(pardontextbox);
            groupBox1.Controls.Add(radio_pardonip);
            groupBox1.Controls.Add(gamemodeDrop);
            groupBox1.Controls.Add(kbreasontextbox);
            groupBox1.Controls.Add(radio_Ipban);
            groupBox1.Controls.Add(radio_Ban);
            groupBox1.Controls.Add(radio_Kick);
            groupBox1.Controls.Add(radio_Deop);
            groupBox1.Controls.Add(radio_OP);
            groupBox1.Controls.Add(radio_Gamemode);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(usernametextbox);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(255, 260);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Player Related";
            // 
            // radio_unban
            // 
            radio_unban.AutoSize = true;
            radio_unban.Location = new Point(6, 201);
            radio_unban.Name = "radio_unban";
            radio_unban.Size = new Size(60, 19);
            radio_unban.TabIndex = 13;
            radio_unban.TabStop = true;
            radio_unban.Text = "Unban";
            radio_unban.UseVisualStyleBackColor = true;
            // 
            // pardontextbox
            // 
            pardontextbox.AccessibleDescription = "";
            pardontextbox.Location = new Point(88, 225);
            pardontextbox.Name = "pardontextbox";
            pardontextbox.PlaceholderText = "IP ";
            pardontextbox.Size = new Size(161, 23);
            pardontextbox.TabIndex = 12;
            // 
            // radio_pardonip
            // 
            radio_pardonip.AutoSize = true;
            radio_pardonip.Location = new Point(6, 226);
            radio_pardonip.Name = "radio_pardonip";
            radio_pardonip.Size = new Size(76, 19);
            radio_pardonip.TabIndex = 11;
            radio_pardonip.TabStop = true;
            radio_pardonip.Text = "Pardon ip";
            radio_pardonip.UseVisualStyleBackColor = true;
            // 
            // kbreasontextbox
            // 
            kbreasontextbox.Location = new Point(72, 125);
            kbreasontextbox.Name = "kbreasontextbox";
            kbreasontextbox.PlaceholderText = "Reason of kick/ban";
            kbreasontextbox.Size = new Size(177, 23);
            kbreasontextbox.TabIndex = 9;
            // 
            // radio_Ipban
            // 
            radio_Ipban.AutoSize = true;
            radio_Ipban.Location = new Point(6, 176);
            radio_Ipban.Name = "radio_Ipban";
            radio_Ipban.Size = new Size(55, 19);
            radio_Ipban.TabIndex = 8;
            radio_Ipban.TabStop = true;
            radio_Ipban.Text = "IPBan";
            radio_Ipban.UseVisualStyleBackColor = true;
            radio_Ipban.CheckedChanged += radio_Ipban_CheckedChanged;
            // 
            // radio_Ban
            // 
            radio_Ban.AutoSize = true;
            radio_Ban.Location = new Point(6, 151);
            radio_Ban.Name = "radio_Ban";
            radio_Ban.Size = new Size(45, 19);
            radio_Ban.TabIndex = 8;
            radio_Ban.TabStop = true;
            radio_Ban.Text = "Ban";
            radio_Ban.UseVisualStyleBackColor = true;
            radio_Ban.CheckedChanged += radio_Ban_CheckedChanged;
            // 
            // radio_Kick
            // 
            radio_Kick.AutoSize = true;
            radio_Kick.Location = new Point(6, 126);
            radio_Kick.Name = "radio_Kick";
            radio_Kick.Size = new Size(47, 19);
            radio_Kick.TabIndex = 7;
            radio_Kick.TabStop = true;
            radio_Kick.Text = "Kick";
            radio_Kick.UseVisualStyleBackColor = true;
            radio_Kick.CheckedChanged += radio_Kick_CheckedChanged;
            // 
            // radio_Deop
            // 
            radio_Deop.AutoSize = true;
            radio_Deop.Location = new Point(6, 101);
            radio_Deop.Name = "radio_Deop";
            radio_Deop.Size = new Size(55, 19);
            radio_Deop.TabIndex = 6;
            radio_Deop.TabStop = true;
            radio_Deop.Text = "DeOP";
            radio_Deop.UseVisualStyleBackColor = true;
            radio_Deop.CheckedChanged += radio_Deop_CheckedChanged;
            // 
            // radio_OP
            // 
            radio_OP.AutoSize = true;
            radio_OP.Location = new Point(6, 76);
            radio_OP.Name = "radio_OP";
            radio_OP.Size = new Size(41, 19);
            radio_OP.TabIndex = 5;
            radio_OP.TabStop = true;
            radio_OP.Text = "OP";
            radio_OP.UseVisualStyleBackColor = true;
            radio_OP.CheckedChanged += radio_OP_CheckedChanged;
            // 
            // radio_Gamemode
            // 
            radio_Gamemode.AutoSize = true;
            radio_Gamemode.Location = new Point(6, 51);
            radio_Gamemode.Name = "radio_Gamemode";
            radio_Gamemode.Size = new Size(87, 19);
            radio_Gamemode.TabIndex = 2;
            radio_Gamemode.TabStop = true;
            radio_Gamemode.Text = "Gamemode";
            radio_Gamemode.UseVisualStyleBackColor = true;
            radio_Gamemode.CheckedChanged += radio_Gamemode_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // usernametextbox
            // 
            usernametextbox.Location = new Point(72, 22);
            usernametextbox.Name = "usernametextbox";
            usernametextbox.Size = new Size(177, 23);
            usernametextbox.TabIndex = 0;
            // 
            // playerExecute
            // 
            playerExecute.Location = new Point(12, 432);
            playerExecute.Name = "playerExecute";
            playerExecute.Size = new Size(516, 23);
            playerExecute.TabIndex = 11;
            playerExecute.Text = "Execute";
            playerExecute.UseVisualStyleBackColor = true;
            playerExecute.Click += button1_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 466);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(539, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // richTextLog
            // 
            richTextLog.Location = new Point(12, 278);
            richTextLog.Name = "richTextLog";
            richTextLog.ReadOnly = true;
            richTextLog.Size = new Size(516, 148);
            richTextLog.TabIndex = 2;
            richTextLog.Text = "";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(273, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(255, 260);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Server Related";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 488);
            Controls.Add(groupBox2);
            Controls.Add(playerExecute);
            Controls.Add(richTextLog);
            Controls.Add(statusStrip1);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox usernametextbox;
        private RadioButton radio_Gamemode;
        private RadioButton radio_Deop;
        private RadioButton radio_OP;
        private ComboBox gamemodeDrop;
        private TextBox kbreasontextbox;
        private RadioButton radio_Ban;
        private RadioButton radio_Kick;
        private Button playerExecute;
        private RadioButton radio_Ipban;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private RichTextBox richTextLog;
        private GroupBox groupBox2;
        private TextBox pardontextbox;
        private RadioButton radio_pardonip;
        private RadioButton radio_unban;
    }
}