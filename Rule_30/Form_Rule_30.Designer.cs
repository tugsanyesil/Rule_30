namespace Rule_30
{
    partial class Form_Rule_30
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.PictureBox_Matrix = new System.Windows.Forms.PictureBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.Label_Array_Length = new System.Windows.Forms.Label();
            this.Label_Size_Length = new System.Windows.Forms.Label();
            this.TextBox_Array_Length = new System.Windows.Forms.TextBox();
            this.TextBox_Size_Length = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Matrix)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox_Matrix
            // 
            this.PictureBox_Matrix.Location = new System.Drawing.Point(12, 63);
            this.PictureBox_Matrix.Name = "PictureBox_Matrix";
            this.PictureBox_Matrix.Size = new System.Drawing.Size(100, 100);
            this.PictureBox_Matrix.TabIndex = 0;
            this.PictureBox_Matrix.TabStop = false;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(12, 47);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(80, 13);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Rule 30 Picture";
            // 
            // Label_Array_Length
            // 
            this.Label_Array_Length.AutoSize = true;
            this.Label_Array_Length.Location = new System.Drawing.Point(123, 17);
            this.Label_Array_Length.Name = "Label_Array_Length";
            this.Label_Array_Length.Size = new System.Drawing.Size(67, 13);
            this.Label_Array_Length.TabIndex = 2;
            this.Label_Array_Length.Text = "Array Length";
            // 
            // Label_Size_Length
            // 
            this.Label_Size_Length.AutoSize = true;
            this.Label_Size_Length.Location = new System.Drawing.Point(127, 43);
            this.Label_Size_Length.Name = "Label_Size_Length";
            this.Label_Size_Length.Size = new System.Drawing.Size(63, 13);
            this.Label_Size_Length.TabIndex = 3;
            this.Label_Size_Length.Text = "Size Length";
            // 
            // TextBox_Array_Length
            // 
            this.TextBox_Array_Length.Location = new System.Drawing.Point(196, 14);
            this.TextBox_Array_Length.Name = "TextBox_Array_Length";
            this.TextBox_Array_Length.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Array_Length.TabIndex = 4;
            this.TextBox_Array_Length.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_Array_Length_KeyDown);
            // 
            // TextBox_Size_Length
            // 
            this.TextBox_Size_Length.Location = new System.Drawing.Point(196, 40);
            this.TextBox_Size_Length.Name = "TextBox_Size_Length";
            this.TextBox_Size_Length.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Size_Length.TabIndex = 5;
            this.TextBox_Size_Length.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_Size_Length_KeyDown);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(12, 12);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Form_Rule_30
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.TextBox_Size_Length);
            this.Controls.Add(this.TextBox_Array_Length);
            this.Controls.Add(this.Label_Size_Length);
            this.Controls.Add(this.Label_Array_Length);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.PictureBox_Matrix);
            this.Name = "Form_Rule_30";
            this.Text = "Rule 30 Form";
            this.Load += new System.EventHandler(this.Form_Rule_30_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Matrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox_Matrix;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label Label_Array_Length;
        private System.Windows.Forms.Label Label_Size_Length;
        private System.Windows.Forms.TextBox TextBox_Array_Length;
        private System.Windows.Forms.TextBox TextBox_Size_Length;
        private System.Windows.Forms.Button SaveButton;
    }
}

