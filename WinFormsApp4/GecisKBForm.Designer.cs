namespace WinFormsApp4
{
    partial class GecisKBForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            button11 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = SystemColors.InactiveCaption;
            label1.Font = new Font("Yu Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.BottomCenter;
            label1.Location = new Point(205, 153);
            label1.Name = "label1";
            label1.Size = new Size(495, 199);
            label1.TabIndex = 1;
            label1.Text = "Kullanıcı - Bilgisayar \r\nHoşgeldiniz!\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.BackColor = SystemColors.InactiveCaption;
            label2.Font = new Font("Yu Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.BottomCenter;
            label2.Location = new Point(125, 92);
            label2.Name = "label2";
            label2.Size = new Size(641, 18);
            label2.TabIndex = 2;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.BackColor = SystemColors.InactiveCaption;
            label3.Font = new Font("Yu Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ImageAlign = ContentAlignment.BottomCenter;
            label3.Location = new Point(125, 401);
            label3.Name = "label3";
            label3.Size = new Size(641, 18);
            label3.TabIndex = 3;
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.BackColor = SystemColors.InactiveCaption;
            label5.Font = new Font("Yu Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ImageAlign = ContentAlignment.BottomCenter;
            label5.Location = new Point(125, 110);
            label5.Name = "label5";
            label5.Size = new Size(18, 301);
            label5.TabIndex = 5;
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.BackColor = SystemColors.InactiveCaption;
            label4.Font = new Font("Yu Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ImageAlign = ContentAlignment.BottomCenter;
            label4.Location = new Point(748, 110);
            label4.Name = "label4";
            label4.Size = new Size(18, 301);
            label4.TabIndex = 6;
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button11
            // 
            button11.Anchor = AnchorStyles.None;
            button11.BackColor = SystemColors.InactiveCaption;
            button11.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button11.Location = new Point(205, 480);
            button11.Name = "button11";
            button11.Size = new Size(495, 57);
            button11.TabIndex = 7;
            button11.Text = "İlerle\r\n";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // GecisKBForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 614);
            Controls.Add(button11);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GecisKBForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            WindowState = FormWindowState.Maximized;
            Load += Form3_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private Button button11;
    }
}