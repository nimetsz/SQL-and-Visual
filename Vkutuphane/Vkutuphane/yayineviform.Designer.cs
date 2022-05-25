
namespace Vkutuphane
{
    partial class yayineviform
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.yayindgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtyayin = new System.Windows.Forms.TextBox();
            this.txtkitap = new System.Windows.Forms.TextBox();
            this.txtkateg = new System.Windows.Forms.TextBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btngunc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yayindgv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SandyBrown;
            this.groupBox1.Controls.Add(this.btngunc);
            this.groupBox1.Controls.Add(this.btnsil);
            this.groupBox1.Controls.Add(this.btnkaydet);
            this.groupBox1.Controls.Add(this.txtkateg);
            this.groupBox1.Controls.Add(this.txtkitap);
            this.groupBox1.Controls.Add(this.txtyayin);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(912, 313);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yayınevi Bilgileri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // yayindgv
            // 
            this.yayindgv.BackgroundColor = System.Drawing.Color.Coral;
            this.yayindgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.yayindgv.Location = new System.Drawing.Point(0, 309);
            this.yayindgv.Name = "yayindgv";
            this.yayindgv.RowHeadersWidth = 51;
            this.yayindgv.RowTemplate.Height = 24;
            this.yayindgv.Size = new System.Drawing.Size(912, 193);
            this.yayindgv.TabIndex = 0;
            this.yayindgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.yayindgv_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(31, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(31, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yayınevi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(30, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kategori";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(31, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kitap";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(202, 54);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(184, 30);
            this.txtid.TabIndex = 4;
            // 
            // txtyayin
            // 
            this.txtyayin.Location = new System.Drawing.Point(202, 99);
            this.txtyayin.Name = "txtyayin";
            this.txtyayin.Size = new System.Drawing.Size(184, 30);
            this.txtyayin.TabIndex = 5;
            // 
            // txtkitap
            // 
            this.txtkitap.Location = new System.Drawing.Point(202, 154);
            this.txtkitap.Name = "txtkitap";
            this.txtkitap.Size = new System.Drawing.Size(184, 30);
            this.txtkitap.TabIndex = 6;
            // 
            // txtkateg
            // 
            this.txtkateg.Location = new System.Drawing.Point(202, 202);
            this.txtkateg.Name = "txtkateg";
            this.txtkateg.Size = new System.Drawing.Size(184, 30);
            this.txtkateg.TabIndex = 7;
            this.txtkateg.TextChanged += new System.EventHandler(this.txtkateg_TextChanged);
            // 
            // btnkaydet
            // 
            this.btnkaydet.BackColor = System.Drawing.Color.Coral;
            this.btnkaydet.ForeColor = System.Drawing.Color.White;
            this.btnkaydet.Location = new System.Drawing.Point(614, 54);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(163, 43);
            this.btnkaydet.TabIndex = 8;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = false;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.Coral;
            this.btnsil.ForeColor = System.Drawing.Color.White;
            this.btnsil.Location = new System.Drawing.Point(614, 119);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(163, 43);
            this.btnsil.TabIndex = 9;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btngunc
            // 
            this.btngunc.BackColor = System.Drawing.Color.Coral;
            this.btngunc.ForeColor = System.Drawing.Color.White;
            this.btngunc.Location = new System.Drawing.Point(614, 189);
            this.btngunc.Name = "btngunc";
            this.btngunc.Size = new System.Drawing.Size(163, 43);
            this.btngunc.TabIndex = 10;
            this.btngunc.Text = "Güncelle";
            this.btngunc.UseVisualStyleBackColor = false;
            this.btngunc.Click += new System.EventHandler(this.btngunc_Click);
            // 
            // yayineviform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 514);
            this.Controls.Add(this.yayindgv);
            this.Controls.Add(this.groupBox1);
            this.Name = "yayineviform";
            this.Text = "yayineviform";
            this.Load += new System.EventHandler(this.yayineviform_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yayindgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btngunc;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.TextBox txtkateg;
        private System.Windows.Forms.TextBox txtkitap;
        private System.Windows.Forms.TextBox txtyayin;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView yayindgv;
    }
}