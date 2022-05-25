
namespace Vkutuphane
{
    partial class formEntity
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
            this.btngnc = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.yazarAra = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.yazar = new System.Windows.Forms.TextBox();
            this.bio = new System.Windows.Forms.TextBox();
            this.eser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.yazardgw = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yazardgw)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.btngnc);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.yazarAra);
            this.groupBox1.Controls.Add(this.txtAra);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.id);
            this.groupBox1.Controls.Add(this.yazar);
            this.groupBox1.Controls.Add(this.bio);
            this.groupBox1.Controls.Add(this.eser);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(11, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(857, 280);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yazar Bilgileri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btngnc
            // 
            this.btngnc.BackColor = System.Drawing.Color.DarkKhaki;
            this.btngnc.ForeColor = System.Drawing.Color.Black;
            this.btngnc.Location = new System.Drawing.Point(352, 208);
            this.btngnc.Name = "btngnc";
            this.btngnc.Size = new System.Drawing.Size(127, 43);
            this.btngnc.TabIndex = 11;
            this.btngnc.Text = "Güncelle";
            this.btngnc.UseVisualStyleBackColor = false;
            this.btngnc.Click += new System.EventHandler(this.btngnc_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnSil.ForeColor = System.Drawing.Color.Black;
            this.btnSil.Location = new System.Drawing.Point(204, 208);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(127, 43);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnKaydet.ForeColor = System.Drawing.Color.Black;
            this.btnKaydet.Location = new System.Drawing.Point(58, 209);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(127, 43);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // yazarAra
            // 
            this.yazarAra.AutoSize = true;
            this.yazarAra.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yazarAra.ForeColor = System.Drawing.Color.Black;
            this.yazarAra.Location = new System.Drawing.Point(498, 215);
            this.yazarAra.Name = "yazarAra";
            this.yazarAra.Size = new System.Drawing.Size(92, 24);
            this.yazarAra.TabIndex = 9;
            this.yazarAra.Text = "Yazar Adı :";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(596, 209);
            this.txtAra.Multiline = true;
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(144, 34);
            this.txtAra.TabIndex = 8;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(58, 115);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(144, 34);
            this.txtId.TabIndex = 7;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.id.Location = new System.Drawing.Point(54, 67);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(27, 24);
            this.id.TabIndex = 6;
            this.id.Text = "Id";
            // 
            // yazar
            // 
            this.yazar.Location = new System.Drawing.Point(246, 115);
            this.yazar.Multiline = true;
            this.yazar.Name = "yazar";
            this.yazar.Size = new System.Drawing.Size(144, 34);
            this.yazar.TabIndex = 5;
            // 
            // bio
            // 
            this.bio.Location = new System.Drawing.Point(422, 115);
            this.bio.Multiline = true;
            this.bio.Name = "bio";
            this.bio.Size = new System.Drawing.Size(144, 34);
            this.bio.TabIndex = 4;
            this.bio.TextChanged += new System.EventHandler(this.bio_TextChanged);
            // 
            // eser
            // 
            this.eser.Location = new System.Drawing.Point(596, 115);
            this.eser.Multiline = true;
            this.eser.Name = "eser";
            this.eser.Size = new System.Drawing.Size(144, 34);
            this.eser.TabIndex = 3;
            this.eser.TextChanged += new System.EventHandler(this.eser_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(592, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Eserleri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(418, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Biyografi";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(242, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yazar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // yazardgw
            // 
            this.yazardgw.BackgroundColor = System.Drawing.Color.DarkKhaki;
            this.yazardgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.yazardgw.Location = new System.Drawing.Point(12, 298);
            this.yazardgw.Name = "yazardgw";
            this.yazardgw.RowHeadersWidth = 51;
            this.yazardgw.RowTemplate.Height = 24;
            this.yazardgw.Size = new System.Drawing.Size(857, 196);
            this.yazardgw.TabIndex = 6;
            this.yazardgw.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.yazardgw_CellContentClick);
            // 
            // formEntity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(880, 521);
            this.Controls.Add(this.yazardgw);
            this.Controls.Add(this.groupBox1);
            this.Name = "formEntity";
            this.Text = "formEntity";
            this.Load += new System.EventHandler(this.formEntity_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yazardgw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView yazardgw;
        private System.Windows.Forms.TextBox yazar;
        private System.Windows.Forms.TextBox bio;
        private System.Windows.Forms.TextBox eser;
        private System.Windows.Forms.Label yazarAra;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Button btngnc;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
    }
}