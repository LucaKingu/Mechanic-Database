namespace MechanicBackend
{
    partial class AddMechanic
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
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.PaleGreen;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 20F);
            button1.Location = new Point(197, 365);
            button1.Name = "button1";
            button1.Size = new Size(250, 44);
            button1.TabIndex = 0;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SandyBrown;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(134, 25);
            label1.Name = "label1";
            label1.Size = new Size(66, 30);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Gainsboro;
            textBox1.Font = new Font("Segoe UI", 13F);
            textBox1.Location = new Point(223, 33);
            textBox1.MaxLength = 40;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(316, 31);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Gainsboro;
            textBox2.Font = new Font("Segoe UI", 13F);
            textBox2.Location = new Point(223, 90);
            textBox2.MaxLength = 40;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(316, 31);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SandyBrown;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(110, 83);
            label2.Name = "label2";
            label2.Size = new Size(91, 30);
            label2.TabIndex = 3;
            label2.Text = "Surname";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Gainsboro;
            textBox3.Font = new Font("Segoe UI", 13F);
            textBox3.Location = new Point(223, 154);
            textBox3.MaxLength = 40;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(316, 31);
            textBox3.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SandyBrown;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(134, 147);
            label3.Name = "label3";
            label3.Size = new Size(67, 30);
            label3.TabIndex = 5;
            label3.Text = "Salary";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Gainsboro;
            textBox4.Font = new Font("Segoe UI", 13F);
            textBox4.Location = new Point(223, 212);
            textBox4.MaxLength = 40;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(316, 31);
            textBox4.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.SandyBrown;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI", 15F);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(42, 212);
            label4.Name = "label4";
            label4.Size = new Size(159, 30);
            label4.TabIndex = 7;
            label4.Text = "Contact Number";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.Gainsboro;
            textBox5.Font = new Font("Segoe UI", 13F);
            textBox5.Location = new Point(223, 280);
            textBox5.MaxLength = 40;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(316, 31);
            textBox5.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.SandyBrown;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Segoe UI", 15F);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(140, 272);
            label5.Name = "label5";
            label5.Size = new Size(61, 30);
            label5.TabIndex = 9;
            label5.Text = "Email";
            // 
            // AddMechanic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(632, 475);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "AddMechanic";
            Text = "AddMechanic";
            Load += AddMechanic_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
    }
}