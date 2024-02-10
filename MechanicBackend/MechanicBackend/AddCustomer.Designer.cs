namespace MechanicBackend
{
    partial class AddCustomer
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.PaleGreen;
            button1.Font = new Font("Segoe UI", 20F);
            button1.Location = new Point(226, 374);
            button1.Name = "button1";
            button1.Size = new Size(354, 64);
            button1.TabIndex = 0;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Gainsboro;
            textBox1.Font = new Font("Segoe UI", 20F);
            textBox1.Location = new Point(326, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(318, 43);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SandyBrown;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(170, 56);
            label1.Name = "label1";
            label1.Size = new Size(88, 37);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SandyBrown;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(147, 121);
            label2.Name = "label2";
            label2.Size = new Size(121, 37);
            label2.TabIndex = 5;
            label2.Text = "Surname";
            label2.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Gainsboro;
            textBox2.Font = new Font("Segoe UI", 20F);
            textBox2.Location = new Point(326, 121);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(318, 43);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SandyBrown;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(55, 185);
            label3.Name = "label3";
            label3.Size = new Size(213, 37);
            label3.TabIndex = 7;
            label3.Text = "Contact Number";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Gainsboro;
            textBox3.Font = new Font("Segoe UI", 20F);
            textBox3.Location = new Point(326, 185);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(318, 43);
            textBox3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.SandyBrown;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(186, 249);
            label4.Name = "label4";
            label4.Size = new Size(82, 37);
            label4.TabIndex = 9;
            label4.Text = "Email";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Gainsboro;
            textBox4.Font = new Font("Segoe UI", 20F);
            textBox4.Location = new Point(326, 249);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(318, 43);
            textBox4.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.SandyBrown;
            label5.Font = new Font("Segoe UI", 20F);
            label5.Location = new Point(157, 308);
            label5.Name = "label5";
            label5.Size = new Size(111, 37);
            label5.TabIndex = 11;
            label5.Text = "Address";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.Gainsboro;
            textBox5.Font = new Font("Segoe UI", 20F);
            textBox5.Location = new Point(326, 308);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(318, 43);
            textBox5.TabIndex = 10;
            // 
            // AddCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "AddCustomer";
            Text = "Add Customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
    }
}