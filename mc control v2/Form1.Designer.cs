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
            label1 = new Label();
            ip_textbox = new TextBox();
            port_box = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pw_textbox = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)port_box).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(162, 21);
            label1.TabIndex = 0;
            label1.Text = "MCrcon Client login";
            // 
            // ip_textbox
            // 
            ip_textbox.Location = new Point(12, 58);
            ip_textbox.Name = "ip_textbox";
            ip_textbox.Size = new Size(181, 23);
            ip_textbox.TabIndex = 1;
            // 
            // port_box
            // 
            port_box.Location = new Point(199, 59);
            port_box.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            port_box.Name = "port_box";
            port_box.Size = new Size(89, 23);
            port_box.TabIndex = 2;
            port_box.Value = new decimal(new int[] { 1111, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 40);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 3;
            label2.Text = "IP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(199, 40);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 4;
            label3.Text = "PORT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 84);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 5;
            label4.Text = "Pass";
            // 
            // pw_textbox
            // 
            pw_textbox.Location = new Point(12, 102);
            pw_textbox.Name = "pw_textbox";
            pw_textbox.PasswordChar = '*';
            pw_textbox.Size = new Size(276, 23);
            pw_textbox.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(12, 135);
            button1.Name = "button1";
            button1.Size = new Size(276, 23);
            button1.TabIndex = 7;
            button1.Text = "Continue";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 170);
            Controls.Add(button1);
            Controls.Add(pw_textbox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(port_box);
            Controls.Add(ip_textbox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)port_box).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox ip_textbox;
        private NumericUpDown port_box;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox pw_textbox;
        private Button button1;
    }
}