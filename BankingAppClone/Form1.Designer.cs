namespace BankingAppClone
{
    partial class LoginWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginWindow));
            SignUpButton = new Button();
            ClearButton = new Button();
            maskedTextBox1 = new MaskedTextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label6 = new Label();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // SignUpButton
            // 
            SignUpButton.BackColor = SystemColors.ButtonHighlight;
            SignUpButton.FlatStyle = FlatStyle.System;
            SignUpButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SignUpButton.ForeColor = SystemColors.ControlText;
            SignUpButton.Location = new Point(32, 270);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(60, 39);
            SignUpButton.TabIndex = 0;
            SignUpButton.Text = "Login";
            SignUpButton.UseVisualStyleBackColor = false;
            // 
            // ClearButton
            // 
            ClearButton.BackColor = SystemColors.ButtonHighlight;
            ClearButton.FlatStyle = FlatStyle.System;
            ClearButton.ForeColor = SystemColors.ControlText;
            ClearButton.Location = new Point(106, 270);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(60, 39);
            ClearButton.TabIndex = 1;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = false;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(32, 222);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(282, 23);
            maskedTextBox1.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(32, 178);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(282, 23);
            textBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Reference Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(45, 223);
            label1.Name = "label1";
            label1.Size = new Size(433, 35);
            label1.TabIndex = 6;
            label1.Text = "Maple Leaf Financial Group";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(95, 261);
            label2.Name = "label2";
            label2.Size = new Size(343, 20);
            label2.TabIndex = 7;
            label2.Text = "Rooted in Strength, Growing Your Future";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 160);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 8;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 204);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 9;
            label4.Text = "Password";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(345, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(542, 471);
            panel1.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(129, 443);
            label5.Name = "label5";
            label5.Size = new Size(273, 15);
            label5.TabIndex = 9;
            label5.Text = "Designed and developed by Ramiyan Gangatharan";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(174, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 170);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.FlatStyle = FlatStyle.System;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(254, 270);
            button1.Name = "button1";
            button1.Size = new Size(60, 39);
            button1.TabIndex = 14;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(140, 130);
            label6.Name = "label6";
            label6.Size = new Size(74, 26);
            label6.TabIndex = 15;
            label6.Text = "Login";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.FlatStyle = FlatStyle.System;
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(180, 270);
            button2.Name = "button2";
            button2.Size = new Size(60, 39);
            button2.TabIndex = 16;
            button2.Text = "Help";
            button2.UseVisualStyleBackColor = false;
            // 
            // LoginWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(209, 182, 153);
            ClientSize = new Size(884, 466);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(maskedTextBox1);
            Controls.Add(label4);
            Controls.Add(SignUpButton);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(ClearButton);
            Name = "LoginWindow";
            Text = "[MLFG] Maple Leaf Financial Group - Login";
            Load += LoginWindow_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SignUpButton;
        private Button ClearButton;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private Button button1;
        private Label label6;
        private PictureBox pictureBox1;
        private Label label5;
        private Button button2;
    }
}