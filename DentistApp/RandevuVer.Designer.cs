namespace DentistApp
{
    partial class RandevuVer
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
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("");
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.randevuVerTarihSecici = new System.Windows.Forms.MonthCalendar();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroPanel2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.metroListView1);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(428, 122);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(1049, 455);
            this.metroPanel2.TabIndex = 1;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(60, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(208, 20);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Randevu Sistemine Hoş Geldiniz";
            this.metroLabel1.UseWaitCursor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(28, 48);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(273, 50);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Lütfen randevu almak istediğiniz \r\ntarihi seçiniz.";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel2.UseWaitCursor = true;
            // 
            // randevuVerTarihSecici
            // 
            this.randevuVerTarihSecici.BackColor = System.Drawing.Color.Gold;
            this.randevuVerTarihSecici.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.randevuVerTarihSecici.Font = new System.Drawing.Font("Aliquam", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randevuVerTarihSecici.ForeColor = System.Drawing.Color.Blue;
            this.randevuVerTarihSecici.Location = new System.Drawing.Point(28, 140);
            this.randevuVerTarihSecici.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.randevuVerTarihSecici.MaxSelectionCount = 1;
            this.randevuVerTarihSecici.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.randevuVerTarihSecici.Name = "randevuVerTarihSecici";
            this.randevuVerTarihSecici.ShowWeekNumbers = true;
            this.randevuVerTarihSecici.TabIndex = 2;
            this.randevuVerTarihSecici.TitleBackColor = System.Drawing.Color.Red;
            this.randevuVerTarihSecici.TitleForeColor = System.Drawing.Color.White;
            this.randevuVerTarihSecici.UseWaitCursor = true;
            this.randevuVerTarihSecici.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.randevuVerTarihSecici_DateSelected);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.randevuVerTarihSecici);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 122);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(399, 455);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.UseWaitCursor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroListView1
            // 
            this.metroListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.metroListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView1.FullRowSelect = true;
            this.metroListView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.metroListView1.Location = new System.Drawing.Point(24, 15);
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.OwnerDraw = true;
            this.metroListView1.Size = new System.Drawing.Size(1002, 423);
            this.metroListView1.TabIndex = 2;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.UseSelectable = true;
            this.metroListView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Saat";
            this.columnHeader1.Width = 102;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ad";
            this.columnHeader2.Width = 152;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyad";
            this.columnHeader3.Width = 155;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefon Numarası";
            this.columnHeader4.Width = 184;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Width = 191;
            // 
            // RandevuVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Name = "RandevuVer";
            this.Text = "RandevuVer";
            this.Load += new System.EventHandler(this.RandevuVer_Load);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        public System.Windows.Forms.MonthCalendar randevuVerTarihSecici;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroListView metroListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}