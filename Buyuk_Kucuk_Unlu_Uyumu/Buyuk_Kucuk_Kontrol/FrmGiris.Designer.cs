namespace Buyuk_Kucuk_Kontrol
{
    partial class FrmGiris
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiris));
            this.grpCon = new DevExpress.XtraEditors.GroupControl();
            this.rdg1 = new DevExpress.XtraEditors.RadioGroup();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.BtnBuyuk = new DevExpress.XtraEditors.SimpleButton();
            this.btnKck = new DevExpress.XtraEditors.SimpleButton();
            this.btnDevam = new DevExpress.XtraEditors.SimpleButton();
            this.btnCikis = new DevExpress.XtraEditors.SimpleButton();
            this.toolT = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grpCon)).BeginInit();
            this.grpCon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdg1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCon
            // 
            this.grpCon.AllowDrop = true;
            this.grpCon.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpCon.Appearance.Options.UseFont = true;
            this.grpCon.AppearanceCaption.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpCon.AppearanceCaption.ForeColor = System.Drawing.Color.Crimson;
            this.grpCon.AppearanceCaption.Options.UseFont = true;
            this.grpCon.AppearanceCaption.Options.UseForeColor = true;
            this.grpCon.ContentImage = global::Buyuk_Kucuk_Kontrol.Properties.Resources.CaramelYatay;
            this.grpCon.ContentImageAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.grpCon.Controls.Add(this.rdg1);
            this.grpCon.Location = new System.Drawing.Point(12, 12);
            this.grpCon.Name = "grpCon";
            this.grpCon.Size = new System.Drawing.Size(239, 154);
            this.grpCon.TabIndex = 0;
            this.grpCon.Text = "Lütfen 3 Secenekten Birini Seçin";
            // 
            // rdg1
            // 
            this.rdg1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rdg1.BackgroundImage")));
            this.rdg1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rdg1.Location = new System.Drawing.Point(0, 62);
            this.rdg1.Name = "rdg1";
            this.rdg1.Properties.Appearance.BackColor = System.Drawing.Color.Linen;
            this.rdg1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdg1.Properties.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.rdg1.Properties.Appearance.Options.UseBackColor = true;
            this.rdg1.Properties.Appearance.Options.UseFont = true;
            this.rdg1.Properties.Appearance.Options.UseForeColor = true;
            this.rdg1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rdg1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Büyük Ünlü Uyumu"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Kücük Ünlü Uyumu"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "2in1")});
            this.rdg1.Size = new System.Drawing.Size(239, 92);
            this.rdg1.TabIndex = 0;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Caramel";
            // 
            // BtnBuyuk
            // 
            this.BtnBuyuk.Appearance.BackColor = System.Drawing.Color.White;
            this.BtnBuyuk.Appearance.Font = new System.Drawing.Font("Calibri", 7.55F, System.Drawing.FontStyle.Bold);
            this.BtnBuyuk.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.BtnBuyuk.Appearance.Options.UseBackColor = true;
            this.BtnBuyuk.Appearance.Options.UseFont = true;
            this.BtnBuyuk.Appearance.Options.UseForeColor = true;
            this.BtnBuyuk.Location = new System.Drawing.Point(271, 12);
            this.BtnBuyuk.LookAndFeel.SkinName = "Summer 2008";
            this.BtnBuyuk.LookAndFeel.UseWindowsXPTheme = true;
            this.BtnBuyuk.Name = "BtnBuyuk";
            this.BtnBuyuk.Size = new System.Drawing.Size(158, 72);
            this.BtnBuyuk.TabIndex = 1;
            this.BtnBuyuk.Text = "Büyük\r\n Ünlü Uyumu\r\nNedir ? Öðrenmek için\r\nCursor\'u Butonun Üzerinde Beklet !\r\n\r\n" +
                "";
            this.toolT.SetToolTip(this.BtnBuyuk, "Bir kelimenin birinci hecesinde kalýn bir ünlü (a, ý, o, u) bulunuyorsa, diðer he" +
                    "celerdeki ünlüler de kalýn; ince bir ünlü (e, i, ö, ü) bulunuyorsa diðer heceler" +
                    "deki ünlüler de ince olmalýdýr.\r\n");
            this.BtnBuyuk.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Question;
            // 
            // btnKck
            // 
            this.btnKck.Appearance.BackColor = System.Drawing.Color.White;
            this.btnKck.Appearance.Font = new System.Drawing.Font("Calibri", 7.55F, System.Drawing.FontStyle.Bold);
            this.btnKck.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.btnKck.Appearance.Options.UseBackColor = true;
            this.btnKck.Appearance.Options.UseFont = true;
            this.btnKck.Appearance.Options.UseForeColor = true;
            this.btnKck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKck.BackgroundImage")));
            this.btnKck.Location = new System.Drawing.Point(271, 90);
            this.btnKck.LookAndFeel.SkinName = "Summer 2008";
            this.btnKck.LookAndFeel.UseWindowsXPTheme = true;
            this.btnKck.Name = "btnKck";
            this.btnKck.Size = new System.Drawing.Size(158, 76);
            this.btnKck.TabIndex = 2;
            this.btnKck.Text = "Küçük Ünlü Uyumu\r\nNedir ? Öðrenmek için\r\nCursor\'u Butonun Üzerinde Beklet !\r\n\r\n";
            this.toolT.SetToolTip(this.btnKck, resources.GetString("btnKck.ToolTip"));
            this.btnKck.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            // 
            // btnDevam
            // 
            this.btnDevam.Appearance.BackColor = System.Drawing.Color.White;
            this.btnDevam.Appearance.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDevam.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.btnDevam.Appearance.Options.UseBackColor = true;
            this.btnDevam.Appearance.Options.UseFont = true;
            this.btnDevam.Appearance.Options.UseForeColor = true;
            this.btnDevam.Location = new System.Drawing.Point(12, 193);
            this.btnDevam.LookAndFeel.SkinName = "Summer 2008";
            this.btnDevam.LookAndFeel.UseWindowsXPTheme = true;
            this.btnDevam.Name = "btnDevam";
            this.btnDevam.Size = new System.Drawing.Size(239, 72);
            this.btnDevam.TabIndex = 3;
            this.btnDevam.Text = "Devam Et";
            this.btnDevam.Click += new System.EventHandler(this.btnDevam_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Appearance.BackColor = System.Drawing.Color.White;
            this.btnCikis.Appearance.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.btnCikis.Appearance.Options.UseBackColor = true;
            this.btnCikis.Appearance.Options.UseFont = true;
            this.btnCikis.Appearance.Options.UseForeColor = true;
            this.btnCikis.Location = new System.Drawing.Point(271, 193);
            this.btnCikis.LookAndFeel.SkinName = "Summer 2008";
            this.btnCikis.LookAndFeel.UseWindowsXPTheme = true;
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(158, 72);
            this.btnCikis.TabIndex = 4;
            this.btnCikis.Text = "ÇIKIÞ";
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // toolT
            // 
            this.toolT.BackColor = System.Drawing.Color.Khaki;
            this.toolT.ForeColor = System.Drawing.Color.Red;
            this.toolT.IsBalloon = true;
            this.toolT.ShowAlways = true;
            this.toolT.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolT.ToolTipTitle = "Bu Nedir ?";
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::Buyuk_Kucuk_Kontrol.Properties.Resources.CaramelDikey;
            this.ClientSize = new System.Drawing.Size(440, 276);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnDevam);
            this.Controls.Add(this.btnKck);
            this.Controls.Add(this.BtnBuyuk);
            this.Controls.Add(this.grpCon);
            this.Name = "FrmGiris";
            this.Text = "Giris Ekraný";
            ((System.ComponentModel.ISupportInitialize)(this.grpCon)).EndInit();
            this.grpCon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rdg1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpCon;
        private DevExpress.XtraEditors.RadioGroup rdg1;
        private DevExpress.XtraEditors.SimpleButton BtnBuyuk;
        private DevExpress.XtraEditors.SimpleButton btnKck;
        private DevExpress.XtraEditors.SimpleButton btnDevam;
        private DevExpress.XtraEditors.SimpleButton btnCikis;
        public DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        public System.Windows.Forms.ToolTip toolT;
    }
}

