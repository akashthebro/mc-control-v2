namespace mc_control_v2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            debugsend_button = new Button();
            debugtext_box = new TextBox();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 396);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(520, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(172, 17);
            toolStripStatusLabel1.Text = "RCON client by aksl -- beta test";
            // 
            // debugsend_button
            // 
            debugsend_button.Location = new Point(368, 370);
            debugsend_button.Name = "debugsend_button";
            debugsend_button.Size = new Size(140, 23);
            debugsend_button.TabIndex = 2;
            debugsend_button.Text = "Debug send msg";
            debugsend_button.UseVisualStyleBackColor = true;
            debugsend_button.Click += debugsend_button_Click;
            // 
            // debugtext_box
            // 
            debugtext_box.Location = new Point(12, 370);
            debugtext_box.Name = "debugtext_box";
            debugtext_box.Size = new Size(350, 23);
            debugtext_box.TabIndex = 3;
            debugtext_box.Text = "TEST MESSAGE";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 418);
            Controls.Add(debugtext_box);
            Controls.Add(debugsend_button);
            Controls.Add(statusStrip1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Button debugsend_button;
        private TextBox debugtext_box;
    }
}