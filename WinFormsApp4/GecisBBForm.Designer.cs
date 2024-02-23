namespace WinFormsApp4
{
    partial class GecisBBForm
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
            Label label1;
            Label label2;
            Label label3;
            Label label4;
            Label label5;
            Button button1;
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = SystemColors.InactiveCaption;
            label1.Font = new Font("Yu Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.BottomCenter;
            label1.Location = new Point(220, 176);
            label1.Name = "label1";
            label1.Size = new Size(495, 199);
            label1.TabIndex = 0;
            label1.Text = "Bilgisayar - Bilgisayar \r\nHoşgeldiniz!\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.BackColor = SystemColors.InactiveCaption;
            label2.Font = new Font("Yu Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.BottomCenter;
            label2.Location = new Point(143, 110);
            label2.Name = "label2";
            label2.Size = new Size(641, 18);
            label2.TabIndex = 1;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.BackColor = SystemColors.InactiveCaption;
            label3.Font = new Font("Yu Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ImageAlign = ContentAlignment.BottomCenter;
            label3.Location = new Point(143, 414);
            label3.Name = "label3";
            label3.Size = new Size(641, 18);
            label3.TabIndex = 2;
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.BackColor = SystemColors.InactiveCaption;
            label4.Font = new Font("Yu Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ImageAlign = ContentAlignment.BottomCenter;
            label4.Location = new Point(766, 113);
            label4.Name = "label4";
            label4.Size = new Size(18, 301);
            label4.TabIndex = 3;
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.BackColor = SystemColors.InactiveCaption;
            label5.Font = new Font("Yu Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ImageAlign = ContentAlignment.BottomCenter;
            label5.Location = new Point(143, 113);
            label5.Name = "label5";
            label5.Size = new Size(18, 301);
            label5.TabIndex = 4;
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = SystemColors.InactiveCaption;
            button1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(220, 487);
            button1.Name = "button1";
            button1.Size = new Size(495, 57);
            button1.TabIndex = 5;
            button1.Text = "Oyunu Başlat\r\n";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // GecisBBForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 623);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GecisBBForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            WindowState = FormWindowState.Maximized;
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
    }
}