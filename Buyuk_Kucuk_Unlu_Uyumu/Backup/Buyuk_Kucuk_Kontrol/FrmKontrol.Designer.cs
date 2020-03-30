namespace Buyuk_Kucuk_Kontrol
{
    partial class FrmKontrol
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
            this.txtKelime = new System.Windows.Forms.TextBox();
            this.btnKontrol = new DevExpress.XtraEditors.SimpleButton();
            this.pcbBykK = new System.Windows.Forms.PictureBox();
            this.grpByk = new DevExpress.XtraEditors.GroupControl();
            this.grpKck = new DevExpress.XtraEditors.GroupControl();
            this.pcbKckK = new System.Windows.Forms.PictureBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBykK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpByk)).BeginInit();
            this.grpByk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpKck)).BeginInit();
            this.grpKck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbKckK)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKelime
            // 
            this.txtKelime.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKelime.Location = new System.Drawing.Point(12, 12);
            this.txtKelime.MaxLength = 14;
            this.txtKelime.Multiline = true;
            this.txtKelime.Name = "txtKelime";
            this.txtKelime.Size = new System.Drawing.Size(236, 50);
            this.txtKelime.TabIndex = 14;
            // 
            // btnKontrol
            // 
            this.btnKontrol.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKontrol.Appearance.ForeColor = System.Drawing.Color.Lime;
            this.btnKontrol.Appearance.Options.UseFont = true;
            this.btnKontrol.Appearance.Options.UseForeColor = true;
            this.btnKontrol.Location = new System.Drawing.Point(254, 12);
            this.btnKontrol.Name = "btnKontrol";
            this.btnKontrol.Size = new System.Drawing.Size(136, 50);
            this.btnKontrol.TabIndex = 13;
            this.btnKontrol.Text = "KONTROL";
            this.btnKontrol.Click += new System.EventHandler(this.btnKontrol_Click);
            // 
            // pcbBykK
            // 
            this.pcbBykK.Location = new System.Drawing.Point(5, 21);
            this.pcbBykK.Name = "pcbBykK";
            this.pcbBykK.Size = new System.Drawing.Size(94, 110);
            this.pcbBykK.TabIndex = 15;
            this.pcbBykK.TabStop = false;
            // 
            // grpByk
            // 
            this.grpByk.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpByk.AppearanceCaption.ForeColor = System.Drawing.Color.Red;
            this.grpByk.AppearanceCaption.Options.UseFont = true;
            this.grpByk.AppearanceCaption.Options.UseForeColor = true;
            this.grpByk.Controls.Add(this.pcbBykK);
            this.grpByk.Location = new System.Drawing.Point(12, 105);
            this.grpByk.Name = "grpByk";
            this.grpByk.Size = new System.Drawing.Size(105, 136);
            this.grpByk.TabIndex = 17;
            this.grpByk.Text = "Büyük Ünlü Uyumu Kontrol";
            // 
            // grpKck
            // 
            this.grpKck.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpKck.AppearanceCaption.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.grpKck.AppearanceCaption.Options.UseFont = true;
            this.grpKck.AppearanceCaption.Options.UseForeColor = true;
            this.grpKck.Controls.Add(this.pcbKckK);
            this.grpKck.Location = new System.Drawing.Point(123, 105);
            this.grpKck.Name = "grpKck";
            this.grpKck.Size = new System.Drawing.Size(105, 136);
            this.grpKck.TabIndex = 18;
            this.grpKck.Text = "Küçük Ünlü Uyumu Kontrol";
            // 
            // pcbKckK
            // 
            this.pcbKckK.Location = new System.Drawing.Point(5, 21);
            this.pcbKckK.Name = "pcbKckK";
            this.pcbKckK.Size = new System.Drawing.Size(94, 110);
            this.pcbKckK.TabIndex = 15;
            this.pcbKckK.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 24.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.labelControl1.Location = new System.Drawing.Point(305, 80);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(26, 195);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "O c e a N";
            this.labelControl1.UseWaitCursor = true;
            // 
            // FrmKontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Buyuk_Kucuk_Kontrol.Properties.Resources.CaramelDikey;
            this.ClientSize = new System.Drawing.Size(391, 287);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.grpKck);
            this.Controls.Add(this.grpByk);
            this.Controls.Add(this.txtKelime);
            this.Controls.Add(this.btnKontrol);
            this.Name = "FrmKontrol";
            this.Text = "KONTROL ET !";
            ((System.ComponentModel.ISupportInitialize)(this.pcbBykK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpByk)).EndInit();
            this.grpByk.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpKck)).EndInit();
            this.grpKck.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbKckK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKelime;
        private DevExpress.XtraEditors.SimpleButton btnKontrol;
        private System.Windows.Forms.PictureBox pcbBykK;
        private DevExpress.XtraEditors.GroupControl grpByk;
        private DevExpress.XtraEditors.GroupControl grpKck;
        private System.Windows.Forms.PictureBox pcbKckK;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}