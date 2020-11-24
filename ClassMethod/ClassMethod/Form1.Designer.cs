namespace ClassMethod
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
            this.btnSec = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnYukle = new System.Windows.Forms.Button();
            this.dGview = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblNotYuksek = new System.Windows.Forms.Label();
            this.lblNotDusuk = new System.Windows.Forms.Label();
            this.lblDagilim = new System.Windows.Forms.Label();
            this.tbNot = new System.Windows.Forms.TrackBar();
            this.tbDagilim = new System.Windows.Forms.TrackBar();
            this.lblCC = new System.Windows.Forms.Label();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.txtDagGoster = new System.Windows.Forms.TextBox();
            this.lblD = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDagilim)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSec
            // 
            this.btnSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSec.Location = new System.Drawing.Point(309, 13);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(75, 39);
            this.btnSec.TabIndex = 0;
            this.btnSec.Text = "Seç";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(290, 38);
            this.textBox1.TabIndex = 1;
            // 
            // btnYukle
            // 
            this.btnYukle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYukle.Location = new System.Drawing.Point(391, 13);
            this.btnYukle.Name = "btnYukle";
            this.btnYukle.Size = new System.Drawing.Size(105, 39);
            this.btnYukle.TabIndex = 2;
            this.btnYukle.Text = "Yükle";
            this.btnYukle.UseVisualStyleBackColor = true;
            this.btnYukle.Click += new System.EventHandler(this.btnYukle_Click);
            // 
            // dGview
            // 
            this.dGview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGview.Location = new System.Drawing.Point(13, 72);
            this.dGview.Name = "dGview";
            this.dGview.RowHeadersWidth = 51;
            this.dGview.RowTemplate.Height = 24;
            this.dGview.Size = new System.Drawing.Size(483, 309);
            this.dGview.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblNotYuksek
            // 
            this.lblNotYuksek.AutoSize = true;
            this.lblNotYuksek.Location = new System.Drawing.Point(434, 446);
            this.lblNotYuksek.Name = "lblNotYuksek";
            this.lblNotYuksek.Size = new System.Drawing.Size(54, 17);
            this.lblNotYuksek.TabIndex = 5;
            this.lblNotYuksek.Text = "Yüksek\r\n";
            this.lblNotYuksek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNotDusuk
            // 
            this.lblNotDusuk.AutoSize = true;
            this.lblNotDusuk.Location = new System.Drawing.Point(12, 446);
            this.lblNotDusuk.Name = "lblNotDusuk";
            this.lblNotDusuk.Size = new System.Drawing.Size(48, 17);
            this.lblNotDusuk.TabIndex = 6;
            this.lblNotDusuk.Text = "Düşük\r\n";
            this.lblNotDusuk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDagilim
            // 
            this.lblDagilim.AutoSize = true;
            this.lblDagilim.Location = new System.Drawing.Point(21, 525);
            this.lblDagilim.Name = "lblDagilim";
            this.lblDagilim.Size = new System.Drawing.Size(54, 34);
            this.lblDagilim.TabIndex = 8;
            this.lblDagilim.Text = "Dagılım\r\nAralığı";
            this.lblDagilim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbNot
            // 
            this.tbNot.Location = new System.Drawing.Point(77, 437);
            this.tbNot.Name = "tbNot";
            this.tbNot.Size = new System.Drawing.Size(332, 56);
            this.tbNot.TabIndex = 10;
            this.tbNot.Scroll += new System.EventHandler(this.tbNot_Scroll);
            // 
            // tbDagilim
            // 
            this.tbDagilim.Location = new System.Drawing.Point(77, 531);
            this.tbDagilim.Name = "tbDagilim";
            this.tbDagilim.Size = new System.Drawing.Size(332, 56);
            this.tbDagilim.TabIndex = 7;
            this.tbDagilim.Scroll += new System.EventHandler(this.tbDagilim_Scroll);
            // 
            // lblCC
            // 
            this.lblCC.AutoSize = true;
            this.lblCC.Location = new System.Drawing.Point(174, 409);
            this.lblCC.Name = "lblCC";
            this.lblCC.Size = new System.Drawing.Size(65, 17);
            this.lblCC.TabIndex = 11;
            this.lblCC.Text = "CC Sınırı:";
            // 
            // txtCC
            // 
            this.txtCC.Location = new System.Drawing.Point(255, 409);
            this.txtCC.Name = "txtCC";
            this.txtCC.ReadOnly = true;
            this.txtCC.Size = new System.Drawing.Size(57, 22);
            this.txtCC.TabIndex = 12;
            // 
            // txtDagGoster
            // 
            this.txtDagGoster.Location = new System.Drawing.Point(255, 496);
            this.txtDagGoster.Name = "txtDagGoster";
            this.txtDagGoster.ReadOnly = true;
            this.txtDagGoster.Size = new System.Drawing.Size(57, 22);
            this.txtDagGoster.TabIndex = 14;
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(152, 499);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(97, 17);
            this.lblD.TabIndex = 13;
            this.lblD.Text = "Dağılım Aralığı";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(337, 593);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(151, 45);
            this.btnGuncelle.TabIndex = 15;
            this.btnGuncelle.Text = "Guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 651);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtDagGoster);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.txtCC);
            this.Controls.Add(this.lblCC);
            this.Controls.Add(this.tbNot);
            this.Controls.Add(this.lblDagilim);
            this.Controls.Add(this.tbDagilim);
            this.Controls.Add(this.lblNotDusuk);
            this.Controls.Add(this.lblNotYuksek);
            this.Controls.Add(this.dGview);
            this.Controls.Add(this.btnYukle);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSec);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dGview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDagilim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnYukle;
        private System.Windows.Forms.DataGridView dGview;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblNotYuksek;
        private System.Windows.Forms.Label lblNotDusuk;
        private System.Windows.Forms.Label lblDagilim;
        private System.Windows.Forms.TrackBar tbNot;
        private System.Windows.Forms.TrackBar tbDagilim;
        private System.Windows.Forms.Label lblCC;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.TextBox txtDagGoster;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Button btnGuncelle;
    }
}

