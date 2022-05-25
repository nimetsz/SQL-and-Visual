
namespace Vkutuphane
{
    partial class anaEkran
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
            this.btnkitap = new System.Windows.Forms.Button();
            this.btnyazar = new System.Windows.Forms.Button();
            this.btnyayinevi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnkitap
            // 
            this.btnkitap.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnkitap.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkitap.ForeColor = System.Drawing.Color.Gray;
            this.btnkitap.Location = new System.Drawing.Point(273, 90);
            this.btnkitap.Name = "btnkitap";
            this.btnkitap.Size = new System.Drawing.Size(227, 85);
            this.btnkitap.TabIndex = 0;
            this.btnkitap.Text = "Kitaplar";
            this.btnkitap.UseVisualStyleBackColor = false;
            this.btnkitap.Click += new System.EventHandler(this.btnkitap_Click);
            // 
            // btnyazar
            // 
            this.btnyazar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnyazar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnyazar.ForeColor = System.Drawing.Color.Gray;
            this.btnyazar.Location = new System.Drawing.Point(273, 225);
            this.btnyazar.Name = "btnyazar";
            this.btnyazar.Size = new System.Drawing.Size(227, 85);
            this.btnyazar.TabIndex = 1;
            this.btnyazar.Text = "Yazarlar";
            this.btnyazar.UseVisualStyleBackColor = false;
            this.btnyazar.Click += new System.EventHandler(this.btnyazar_Click);
            // 
            // btnyayinevi
            // 
            this.btnyayinevi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnyayinevi.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnyayinevi.ForeColor = System.Drawing.Color.Gray;
            this.btnyayinevi.Location = new System.Drawing.Point(273, 366);
            this.btnyayinevi.Name = "btnyayinevi";
            this.btnyayinevi.Size = new System.Drawing.Size(227, 85);
            this.btnyayinevi.TabIndex = 2;
            this.btnyayinevi.Text = "Yayınevi";
            this.btnyayinevi.UseVisualStyleBackColor = false;
            this.btnyayinevi.Click += new System.EventHandler(this.btnyayinevi_Click);
            // 
            // anaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(844, 511);
            this.Controls.Add(this.btnyayinevi);
            this.Controls.Add(this.btnyazar);
            this.Controls.Add(this.btnkitap);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "anaEkran";
            this.Text = "anaEkran";
            this.Load += new System.EventHandler(this.anaEkran_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnkitap;
        private System.Windows.Forms.Button btnyazar;
        private System.Windows.Forms.Button btnyayinevi;
    }
}