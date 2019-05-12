namespace WindowsFormsApp1
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnTarihEkle = new System.Windows.Forms.Button();
            this.btnDizi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(139, 244);
            this.listBox1.TabIndex = 0;
            // 
            // btnTarihEkle
            // 
            this.btnTarihEkle.Location = new System.Drawing.Point(159, 13);
            this.btnTarihEkle.Name = "btnTarihEkle";
            this.btnTarihEkle.Size = new System.Drawing.Size(100, 28);
            this.btnTarihEkle.TabIndex = 1;
            this.btnTarihEkle.Text = "Tarih Ekle";
            this.btnTarihEkle.UseVisualStyleBackColor = true;
            this.btnTarihEkle.Click += new System.EventHandler(this.BtnTarihEkle_Click);
            // 
            // btnDizi
            // 
            this.btnDizi.Location = new System.Drawing.Point(159, 47);
            this.btnDizi.Name = "btnDizi";
            this.btnDizi.Size = new System.Drawing.Size(100, 28);
            this.btnDizi.TabIndex = 1;
            this.btnDizi.Text = "Dizi Oluştur";
            this.btnDizi.UseVisualStyleBackColor = true;
            this.btnDizi.Click += new System.EventHandler(this.BtnDizi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 365);
            this.Controls.Add(this.btnDizi);
            this.Controls.Add(this.btnTarihEkle);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnTarihEkle;
        private System.Windows.Forms.Button btnDizi;
    }
}

