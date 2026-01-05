namespace SifreOlusturucu
{
    partial class Form1
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
            this.numUzunluk = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.chkHarf = new System.Windows.Forms.CheckBox();
            this.chkRakam = new System.Windows.Forms.CheckBox();
            this.chkSembol = new System.Windows.Forms.CheckBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnUret = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUzunluk)).BeginInit();
            this.SuspendLayout();
            // 
            // numUzunluk
            // 
            this.numUzunluk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numUzunluk.Location = new System.Drawing.Point(242, 86);
            this.numUzunluk.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numUzunluk.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numUzunluk.Name = "numUzunluk";
            this.numUzunluk.Size = new System.Drawing.Size(120, 30);
            this.numUzunluk.TabIndex = 0;
            this.numUzunluk.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
//            this.numUzunluk.ValueChanged += new System.EventHandler(this.numUzunluk_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(188, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Karakter Sayısı";
            // 
            // chkHarf
            // 
            this.chkHarf.AutoSize = true;
            this.chkHarf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkHarf.Location = new System.Drawing.Point(190, 127);
            this.chkHarf.Name = "chkHarf";
            this.chkHarf.Size = new System.Drawing.Size(74, 29);
            this.chkHarf.TabIndex = 2;
            this.chkHarf.Text = "Harf";
            this.chkHarf.UseVisualStyleBackColor = true;
            // 
            // chkRakam
            // 
            this.chkRakam.AutoSize = true;
            this.chkRakam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkRakam.Location = new System.Drawing.Point(276, 127);
            this.chkRakam.Name = "chkRakam";
            this.chkRakam.Size = new System.Drawing.Size(100, 29);
            this.chkRakam.TabIndex = 3;
            this.chkRakam.Text = "Rakam";
            this.chkRakam.UseVisualStyleBackColor = true;
            // 
            // chkSembol
            // 
            this.chkSembol.AutoSize = true;
            this.chkSembol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkSembol.Location = new System.Drawing.Point(382, 127);
            this.chkSembol.Name = "chkSembol";
            this.chkSembol.Size = new System.Drawing.Size(107, 29);
            this.chkSembol.TabIndex = 4;
            this.chkSembol.Text = "Sembol";
            this.chkSembol.UseVisualStyleBackColor = true;
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(242, 216);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.ReadOnly = true;
            this.txtSifre.Size = new System.Drawing.Size(159, 30);
            this.txtSifre.TabIndex = 5;
            // 
            // btnUret
            // 
            this.btnUret.BackColor = System.Drawing.Color.Red;
            this.btnUret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUret.Location = new System.Drawing.Point(287, 304);
            this.btnUret.Name = "btnUret";
            this.btnUret.Size = new System.Drawing.Size(114, 60);
            this.btnUret.TabIndex = 6;
            this.btnUret.Text = "Şifre Üret";
            this.btnUret.UseVisualStyleBackColor = false;
            this.btnUret.Click += new System.EventHandler(this.btnUret_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(676, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Severler Soft";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUret);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.chkSembol);
            this.Controls.Add(this.chkRakam);
            this.Controls.Add(this.chkHarf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numUzunluk);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numUzunluk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numUzunluk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkHarf;
        private System.Windows.Forms.CheckBox chkRakam;
        private System.Windows.Forms.CheckBox chkSembol;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnUret;
        private System.Windows.Forms.Label label2;
    }
}

