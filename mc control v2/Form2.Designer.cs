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
            groupBox2 = new GroupBox();
            grf = new RadioButton();
            grt = new RadioButton();
            timevalBox = new TextBox();
            difficultyDrop = new ComboBox();
            panel1 = new Panel();
            targetsay_box = new TextBox();
            radio_keepinv = new RadioButton();
            radio_time = new RadioButton();
            radio_daylightcycle = new RadioButton();
            radio_downfall = new RadioButton();
            radio_diff = new RadioButton();
            say_msg = new TextBox();
            radio_say = new RadioButton();
            radio_Ipban = new RadioButton();
            pardontextbox = new TextBox();
            radio_pardonip = new RadioButton();
            targettp_box = new TextBox();
            radio_unban = new RadioButton();
            radio_tp = new RadioButton();
            kbreasontextbox = new TextBox();
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
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(timevalBox);
            groupBox1.Controls.Add(difficultyDrop);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(targetsay_box);
            groupBox1.Controls.Add(radio_keepinv);
            groupBox1.Controls.Add(radio_time);
            groupBox1.Controls.Add(radio_daylightcycle);
            groupBox1.Controls.Add(radio_downfall);
            groupBox1.Controls.Add(radio_diff);
            groupBox1.Controls.Add(say_msg);
            groupBox1.Controls.Add(radio_say);
            groupBox1.Controls.Add(radio_Ipban);
            groupBox1.Controls.Add(pardontextbox);
            groupBox1.Controls.Add(radio_pardonip);
            groupBox1.Controls.Add(targettp_box);
            groupBox1.Controls.Add(radio_unban);
            groupBox1.Controls.Add(radio_tp);
            groupBox1.Controls.Add(gamemodeDrop);
            groupBox1.Controls.Add(kbreasontextbox);
            groupBox1.Controls.Add(radio_Ban);
            groupBox1.Controls.Add(radio_Kick);
            groupBox1.Controls.Add(radio_Deop);
            groupBox1.Controls.Add(radio_OP);
            groupBox1.Controls.Add(radio_Gamemode);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(usernametextbox);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(513, 260);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Actions";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(grf);
            groupBox2.Controls.Add(grt);
            groupBox2.Location = new Point(271, 200);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(150, 44);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            groupBox2.Text = "Gamerule option";
            // 
            // grf
            // 
            grf.AutoSize = true;
            grf.Location = new Point(82, 19);
            grf.Name = "grf";
            grf.Size = new Size(51, 19);
            grf.TabIndex = 0;
            grf.TabStop = true;
            grf.Text = "False";
            grf.UseVisualStyleBackColor = true;
            // 
            // grt
            // 
            grt.AutoSize = true;
            grt.Location = new Point(13, 19);
            grt.Name = "grt";
            grt.Size = new Size(47, 19);
            grt.TabIndex = 0;
            grt.TabStop = true;
            grt.Text = "True";
            grt.UseVisualStyleBackColor = true;
            // 
            // timevalBox
            // 
            timevalBox.Location = new Point(346, 125);
            timevalBox.Name = "timevalBox";
            timevalBox.PlaceholderText = "Time value 0-24000";
            timevalBox.Size = new Size(161, 23);
            timevalBox.TabIndex = 26;
            // 
            // difficultyDrop
            // 
            difficultyDrop.DropDownStyle = ComboBoxStyle.DropDownList;
            difficultyDrop.FormattingEnabled = true;
            difficultyDrop.Location = new Point(353, 76);
            difficultyDrop.Name = "difficultyDrop";
            difficultyDrop.Size = new Size(154, 23);
            difficultyDrop.TabIndex = 25;
            // 
            // panel1
            // 
            panel1.Location = new Point(255, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 249);
            panel1.TabIndex = 24;
            // 
            // targetsay_box
            // 
            targetsay_box.Location = new Point(321, 50);
            targetsay_box.Name = "targetsay_box";
            targetsay_box.PlaceholderText = "Target";
            targetsay_box.Size = new Size(60, 23);
            targetsay_box.TabIndex = 23;
            // 
            // radio_keepinv
            // 
            radio_keepinv.AutoSize = true;
            radio_keepinv.Location = new Point(271, 176);
            radio_keepinv.Name = "radio_keepinv";
            radio_keepinv.Size = new Size(104, 19);
            radio_keepinv.TabIndex = 22;
            radio_keepinv.TabStop = true;
            radio_keepinv.Text = "Keep inventory";
            radio_keepinv.UseVisualStyleBackColor = true;
            radio_keepinv.CheckedChanged += radio_keepinv_CheckedChanged;
            // 
            // radio_time
            // 
            radio_time.AutoSize = true;
            radio_time.Location = new Point(271, 126);
            radio_time.Name = "radio_time";
            radio_time.Size = new Size(69, 19);
            radio_time.TabIndex = 22;
            radio_time.TabStop = true;
            radio_time.Text = "Time set";
            radio_time.UseVisualStyleBackColor = true;
            radio_time.CheckedChanged += radio_time_CheckedChanged;
            // 
            // radio_daylightcycle
            // 
            radio_daylightcycle.AutoSize = true;
            radio_daylightcycle.Location = new Point(271, 151);
            radio_daylightcycle.Name = "radio_daylightcycle";
            radio_daylightcycle.Size = new Size(99, 19);
            radio_daylightcycle.TabIndex = 22;
            radio_daylightcycle.TabStop = true;
            radio_daylightcycle.Text = "Daylight cycle";
            radio_daylightcycle.UseVisualStyleBackColor = true;
            radio_daylightcycle.CheckedChanged += radio_daylightcycle_CheckedChanged;
            // 
            // radio_downfall
            // 
            radio_downfall.AutoSize = true;
            radio_downfall.Location = new Point(271, 101);
            radio_downfall.Name = "radio_downfall";
            radio_downfall.Size = new Size(107, 19);
            radio_downfall.TabIndex = 22;
            radio_downfall.TabStop = true;
            radio_downfall.Text = "ToggleDownfall";
            radio_downfall.UseVisualStyleBackColor = true;
            radio_downfall.CheckedChanged += radio_downfall_CheckedChanged;
            // 
            // radio_diff
            // 
            radio_diff.AutoSize = true;
            radio_diff.Location = new Point(271, 76);
            radio_diff.Name = "radio_diff";
            radio_diff.Size = new Size(76, 19);
            radio_diff.TabIndex = 22;
            radio_diff.TabStop = true;
            radio_diff.Text = "Difficulty ";
            radio_diff.UseVisualStyleBackColor = true;
            radio_diff.CheckedChanged += radio_diff_CheckedChanged;
            // 
            // say_msg
            // 
            say_msg.Location = new Point(387, 50);
            say_msg.Name = "say_msg";
            say_msg.PlaceholderText = "Message";
            say_msg.Size = new Size(120, 23);
            say_msg.TabIndex = 21;
            // 
            // radio_say
            // 
            radio_say.AutoSize = true;
            radio_say.Location = new Point(271, 51);
            radio_say.Name = "radio_say";
            radio_say.Size = new Size(43, 19);
            radio_say.TabIndex = 20;
            radio_say.TabStop = true;
            radio_say.Text = "Say";
            radio_say.UseVisualStyleBackColor = true;
            radio_say.CheckedChanged += radio_say_CheckedChanged;
            // 
            // radio_Ipban
            // 
            radio_Ipban.AutoSize = true;
            radio_Ipban.Location = new Point(6, 226);
            radio_Ipban.Name = "radio_Ipban";
            radio_Ipban.Size = new Size(55, 19);
            radio_Ipban.TabIndex = 17;
            radio_Ipban.TabStop = true;
            radio_Ipban.Text = "IPBan";
            radio_Ipban.UseVisualStyleBackColor = true;
            radio_Ipban.CheckedChanged += radio_Ipban_CheckedChanged;
            // 
            // pardontextbox
            // 
            pardontextbox.AccessibleDescription = "";
            pardontextbox.Location = new Point(353, 25);
            pardontextbox.Name = "pardontextbox";
            pardontextbox.PlaceholderText = "IP ";
            pardontextbox.Size = new Size(154, 23);
            pardontextbox.TabIndex = 19;
            // 
            // radio_pardonip
            // 
            radio_pardonip.AutoSize = true;
            radio_pardonip.Location = new Point(271, 26);
            radio_pardonip.Name = "radio_pardonip";
            radio_pardonip.Size = new Size(76, 19);
            radio_pardonip.TabIndex = 18;
            radio_pardonip.TabStop = true;
            radio_pardonip.Text = "Pardon ip";
            radio_pardonip.UseVisualStyleBackColor = true;
            radio_pardonip.CheckedChanged += radio_pardonip_CheckedChanged;
            // 
            // targettp_box
            // 
            targettp_box.Location = new Point(64, 200);
            targettp_box.Name = "targettp_box";
            targettp_box.PlaceholderText = "Target";
            targettp_box.Size = new Size(185, 23);
            targettp_box.TabIndex = 16;
            // 
            // radio_unban
            // 
            radio_unban.AutoSize = true;
            radio_unban.Location = new Point(6, 176);
            radio_unban.Name = "radio_unban";
            radio_unban.Size = new Size(60, 19);
            radio_unban.TabIndex = 13;
            radio_unban.TabStop = true;
            radio_unban.Text = "Unban";
            radio_unban.UseVisualStyleBackColor = true;
            radio_unban.CheckedChanged += radio_unban_CheckedChanged;
            // 
            // radio_tp
            // 
            radio_tp.AutoSize = true;
            radio_tp.Location = new Point(6, 201);
            radio_tp.Name = "radio_tp";
            radio_tp.Size = new Size(52, 19);
            radio_tp.TabIndex = 15;
            radio_tp.TabStop = true;
            radio_tp.Text = "TP to";
            radio_tp.UseVisualStyleBackColor = true;
            radio_tp.CheckedChanged += radio_tp_CheckedChanged;
            // 
            // kbreasontextbox
            // 
            kbreasontextbox.Location = new Point(72, 125);
            kbreasontextbox.Name = "kbreasontextbox";
            kbreasontextbox.PlaceholderText = "Reason of kick/ban";
            kbreasontextbox.Size = new Size(177, 23);
            kbreasontextbox.TabIndex = 9;
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
            statusStrip1.Size = new Size(537, 22);
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
            richTextLog.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            richTextLog.Location = new Point(12, 278);
            richTextLog.Name = "richTextLog";
            richTextLog.ReadOnly = true;
            richTextLog.Size = new Size(516, 148);
            richTextLog.TabIndex = 2;
            richTextLog.Text = "---CONSOLE---\n› Server console feedback is not possible due to limitations";
            richTextLog.TextChanged += richTextLog_TextChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 488);
            Controls.Add(playerExecute);
            Controls.Add(richTextLog);
            Controls.Add(statusStrip1);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "MCRCON ";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private RichTextBox richTextLog;
        private RadioButton radio_unban;
        private TextBox targettp_box;
        private RadioButton radio_tp;
        private TextBox targetsay_box;
        private RadioButton radio_diff;
        private TextBox say_msg;
        private RadioButton radio_say;
        private RadioButton radio_Ipban;
        private TextBox pardontextbox;
        private RadioButton radio_pardonip;
        private Panel panel1;
        private RadioButton radio_keepinv;
        private RadioButton radio_time;
        private RadioButton radio_daylightcycle;
        private RadioButton radio_downfall;
        private ComboBox difficultyDrop;
        private TextBox timevalBox;
        private GroupBox groupBox2;
        private RadioButton grf;
        private RadioButton grt;
    }
}