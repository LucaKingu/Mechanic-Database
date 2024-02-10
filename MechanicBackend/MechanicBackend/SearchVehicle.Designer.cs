namespace MechanicBackend
{
    partial class SearchVehicle
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
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.PaleGreen;
            button1.Font = new Font("Segoe UI", 20F);
            button1.Location = new Point(255, 138);
            button1.Name = "button1";
            button1.Size = new Size(248, 60);
            button1.TabIndex = 0;
            button1.Text = "SEARCH";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SandyBrown;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(178, 76);
            label1.Name = "label1";
            label1.Size = new Size(180, 37);
            label1.TabIndex = 1;
            label1.Text = "Number Plate";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(37, 240);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(717, 179);
            dataGridView1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightGray;
            textBox1.Font = new Font("Segoe UI", 20F);
            textBox1.Location = new Point(429, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(312, 43);
            textBox1.TabIndex = 3;
            // 
            // SearchVehicle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "SearchVehicle";
            Text = "SearchVehicle";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox textBox1;
    }
}