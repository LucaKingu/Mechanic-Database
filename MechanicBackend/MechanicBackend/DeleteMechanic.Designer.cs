﻿namespace MechanicBackend
{
    partial class DeleteMechanic
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
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Gainsboro;
            textBox1.Font = new Font("Segoe UI", 20F);
            textBox1.Location = new Point(358, 183);
            textBox1.MaxLength = 10000;
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = RightToLeft.No;
            textBox1.Size = new Size(366, 43);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SandyBrown;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(146, 183);
            label1.Name = "label1";
            label1.Size = new Size(163, 37);
            label1.TabIndex = 1;
            label1.Text = "Mechanic ID";
            // 
            // button1
            // 
            button1.BackColor = Color.PaleGreen;
            button1.Font = new Font("Segoe UI", 20F);
            button1.Location = new Point(224, 305);
            button1.Name = "button1";
            button1.Size = new Size(395, 66);
            button1.TabIndex = 2;
            button1.Text = "DELETE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // DeleteMechanic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Font = new Font("Segoe UI", 9F);
            Name = "DeleteMechanic";
            RightToLeft = RightToLeft.Yes;
            Text = "DeleteMechanic";
            Load += DeleteMechanic_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button button1;
    }
}