namespace WinFormsApp4
{
    partial class secimForm
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
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.AutoSize = true;
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(120, 365);
            button2.Name = "button2";
            button2.Size = new Size(246, 79);
            button2.TabIndex = 1;
            button2.Text = "Bilgisayar - Bilgisayar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.AutoSize = true;
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(728, 365);
            button3.Name = "button3";
            button3.Size = new Size(246, 79);
            button3.TabIndex = 2;
            button3.Text = "Kullanıcı - Bilgisayar\r\n";
            button3.UseVisualStyleBackColor = false;
            button3.Click += Button3_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Location = new Point(77, 323);
            label1.Name = "label1";
            label1.Size = new Size(346, 10);
            label1.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Location = new Point(77, 471);
            label3.Name = "label3";
            label3.Size = new Size(346, 10);
            label3.TabIndex = 5;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Location = new Point(413, 323);
            label5.Name = "label5";
            label5.Size = new Size(10, 157);
            label5.TabIndex = 7;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.BackColor = SystemColors.ActiveCaption;
            label6.Location = new Point(77, 323);
            label6.Name = "label6";
            label6.Size = new Size(10, 157);
            label6.TabIndex = 8;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.BackColor = SystemColors.ActiveCaption;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(285, 83);
            label9.Name = "label9";
            label9.Size = new Size(531, 120);
            label9.TabIndex = 11;
            label9.Text = "Seçiminizi Yapın!";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.BackColor = SystemColors.ActiveCaption;
            label10.Location = new Point(685, 323);
            label10.Name = "label10";
            label10.Size = new Size(10, 157);
            label10.TabIndex = 16;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.BackColor = SystemColors.ActiveCaption;
            label11.Location = new Point(1021, 323);
            label11.Name = "label11";
            label11.Size = new Size(10, 157);
            label11.TabIndex = 15;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.BackColor = SystemColors.ActiveCaption;
            label12.Location = new Point(685, 471);
            label12.Name = "label12";
            label12.Size = new Size(346, 10);
            label12.TabIndex = 14;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.BackColor = SystemColors.ActiveCaption;
            label13.Location = new Point(685, 323);
            label13.Name = "label13";
            label13.Size = new Size(346, 10);
            label13.TabIndex = 13;
            // 
            // secimForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 575);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Name = "secimForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += secimForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button3;
        private Label label1;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
    }
}