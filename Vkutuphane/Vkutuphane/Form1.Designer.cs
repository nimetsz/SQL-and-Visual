
namespace Vkutuphane
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtkategori = new System.Windows.Forms.TextBox();
            this.txtkitap = new System.Windows.Forms.TextBox();
            this.txtyazar = new System.Windows.Forms.TextBox();
            this.txtyayinevi = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btngunc = new System.Windows.Forms.Button();
            this.dgkitap = new System.Windows.Forms.DataGridView();
            this.btnSi = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnAna = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgkitap)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtkategori);
            this.groupBox1.Controls.Add(this.txtkitap);
            this.groupBox1.Controls.Add(this.txtyazar);
            this.groupBox1.Controls.Add(this.txtyayinevi);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(154, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Bilgileri";
            // 
            // txtkategori
            // 
            this.txtkategori.Location = new System.Drawing.Point(194, 184);
            this.txtkategori.Name = "txtkategori";
            this.txtkategori.Size = new System.Drawing.Size(210, 27);
            this.txtkategori.TabIndex = 8;
            // 
            // txtkitap
            // 
            this.txtkitap.Location = new System.Drawing.Point(194, 64);
            this.txtkitap.Name = "txtkitap";
            this.txtkitap.Size = new System.Drawing.Size(210, 27);
            this.txtkitap.TabIndex = 7;
            // 
            // txtyazar
            // 
            this.txtyazar.Location = new System.Drawing.Point(194, 101);
            this.txtyazar.Name = "txtyazar";
            this.txtyazar.Size = new System.Drawing.Size(210, 27);
            this.txtyazar.TabIndex = 6;
            // 
            // txtyayinevi
            // 
            this.txtyayinevi.Location = new System.Drawing.Point(194, 144);
            this.txtyayinevi.Name = "txtyayinevi";
            this.txtyayinevi.Size = new System.Drawing.Size(210, 27);
            this.txtyayinevi.TabIndex = 5;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(194, 31);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(210, 27);
            this.txtid.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kategori";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yayınevi";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yazar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btngunc
            // 
            this.btngunc.BackColor = System.Drawing.Color.RosyBrown;
            this.btngunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngunc.ForeColor = System.Drawing.SystemColors.Window;
            this.btngunc.Location = new System.Drawing.Point(442, 249);
            this.btngunc.Name = "btngunc";
            this.btngunc.Size = new System.Drawing.Size(116, 43);
            this.btngunc.TabIndex = 2;
            this.btngunc.Text = "Güncelle";
            this.btngunc.UseVisualStyleBackColor = false;
            this.btngunc.Click += new System.EventHandler(this.btngunc_Click);
            // 
            // dgkitap
            // 
            this.dgkitap.BackgroundColor = System.Drawing.Color.White;
            this.dgkitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgkitap.Location = new System.Drawing.Point(154, 308);
            this.dgkitap.Name = "dgkitap";
            this.dgkitap.RowHeadersWidth = 51;
            this.dgkitap.RowTemplate.Height = 24;
            this.dgkitap.Size = new System.Drawing.Size(706, 150);
            this.dgkitap.TabIndex = 4;
            this.dgkitap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgkitap_CellClick);
            this.dgkitap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgkitap_CellContentClick);
            // 
            // btnSi
            // 
            this.btnSi.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSi.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSi.Location = new System.Drawing.Point(640, 249);
            this.btnSi.Name = "btnSi";
            this.btnSi.Size = new System.Drawing.Size(117, 43);
            this.btnSi.TabIndex = 5;
            this.btnSi.Text = "Sil";
            this.btnSi.UseVisualStyleBackColor = false;
            this.btnSi.Click += new System.EventHandler(this.btnSi_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.RosyBrown;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEkle.Location = new System.Drawing.Point(234, 249);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(117, 43);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Kaydet";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnAna
            // 
            this.btnAna.BackColor = System.Drawing.Color.Black;
            this.btnAna.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAna.ForeColor = System.Drawing.Color.White;
            this.btnAna.Location = new System.Drawing.Point(12, 21);
            this.btnAna.Name = "btnAna";
            this.btnAna.Size = new System.Drawing.Size(117, 42);
            this.btnAna.TabIndex = 7;
            this.btnAna.Text = "Ana Sayfa";
            this.btnAna.UseVisualStyleBackColor = false;
            this.btnAna.Click += new System.EventHandler(this.btnAna_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1002, 516);
            this.Controls.Add(this.btnAna);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnSi);
            this.Controls.Add(this.dgkitap);
            this.Controls.Add(this.btngunc);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgkitap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtkategori;
        private System.Windows.Forms.TextBox txtkitap;
        private System.Windows.Forms.TextBox txtyazar;
        private System.Windows.Forms.TextBox txtyayinevi;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btngunc;
        private System.Windows.Forms.DataGridView dgkitap;
        private System.Windows.Forms.Button btnSi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnAna;
    }
}

