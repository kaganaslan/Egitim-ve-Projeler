namespace WinFormsApp1
{
    partial class frm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm1));
            this.birinciSayiTxtBox = new System.Windows.Forms.TextBox();
            this.ikinciSayiTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toplaBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // birinciSayiTxtBox
            // 
            this.birinciSayiTxtBox.Location = new System.Drawing.Point(351, 52);
            this.birinciSayiTxtBox.Name = "birinciSayiTxtBox";
            this.birinciSayiTxtBox.Size = new System.Drawing.Size(319, 26);
            this.birinciSayiTxtBox.TabIndex = 0;
            // 
            // ikinciSayiTxtBox
            // 
            this.ikinciSayiTxtBox.Location = new System.Drawing.Point(351, 114);
            this.ikinciSayiTxtBox.Name = "ikinciSayiTxtBox";
            this.ikinciSayiTxtBox.Size = new System.Drawing.Size(319, 26);
            this.ikinciSayiTxtBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(258, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sayı 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(258, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sayı 2:";
            // 
            // toplaBtn
            // 
            this.toplaBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.toplaBtn.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.toplaBtn.FlatAppearance.BorderSize = 2;
            this.toplaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toplaBtn.Font = new System.Drawing.Font("Cambria", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.toplaBtn.ForeColor = System.Drawing.Color.DarkBlue;
            this.toplaBtn.Location = new System.Drawing.Point(351, 161);
            this.toplaBtn.Name = "toplaBtn";
            this.toplaBtn.Size = new System.Drawing.Size(319, 61);
            this.toplaBtn.TabIndex = 4;
            this.toplaBtn.Text = "TOPLA";
            this.toplaBtn.UseVisualStyleBackColor = false;
            this.toplaBtn.Click += new System.EventHandler(this.toplaBtn_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(351, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(319, 32);
            this.label3.TabIndex = 5;
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1029, 570);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toplaBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ikinciSayiTxtBox);
            this.Controls.Add(this.birinciSayiTxtBox);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İlk Uygulama";
            this.Load += new System.EventHandler(this.frm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox birinciSayiTxtBox;
        private TextBox ikinciSayiTxtBox;
        private Label label1;
        private Label label2;
        private Button toplaBtn;
        private Label label3;
    }
}