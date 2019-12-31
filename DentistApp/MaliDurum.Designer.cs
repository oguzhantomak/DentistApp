namespace DentistApp
{
    partial class MaliDurum
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.mlvHastalarMaliDurum = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mtxtHastaAdiAra = new MetroFramework.Controls.MetroTextBox();
            this.mlblToplamHasta = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.mlblToplamHasta);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.mlvHastalarMaliDurum);
            this.metroPanel1.Controls.Add(this.mtxtHastaAdiAra);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 82);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1254, 495);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // mlvHastalarMaliDurum
            // 
            this.mlvHastalarMaliDurum.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.mlvHastalarMaliDurum.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mlvHastalarMaliDurum.FullRowSelect = true;
            this.mlvHastalarMaliDurum.Location = new System.Drawing.Point(17, 75);
            this.mlvHastalarMaliDurum.Name = "mlvHastalarMaliDurum";
            this.mlvHastalarMaliDurum.OwnerDraw = true;
            this.mlvHastalarMaliDurum.Size = new System.Drawing.Size(1234, 396);
            this.mlvHastalarMaliDurum.TabIndex = 3;
            this.mlvHastalarMaliDurum.UseCompatibleStateImageBehavior = false;
            this.mlvHastalarMaliDurum.UseSelectable = true;
            this.mlvHastalarMaliDurum.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ad";
            this.columnHeader1.Width = 137;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Soyad";
            this.columnHeader2.Width = 147;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Telefon Numarası";
            this.columnHeader3.Width = 196;
            // 
            // mtxtHastaAdiAra
            // 
            // 
            // 
            // 
            this.mtxtHastaAdiAra.CustomButton.Image = null;
            this.mtxtHastaAdiAra.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.mtxtHastaAdiAra.CustomButton.Name = "";
            this.mtxtHastaAdiAra.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtHastaAdiAra.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtHastaAdiAra.CustomButton.TabIndex = 1;
            this.mtxtHastaAdiAra.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtHastaAdiAra.CustomButton.UseSelectable = true;
            this.mtxtHastaAdiAra.CustomButton.Visible = false;
            this.mtxtHastaAdiAra.Lines = new string[0];
            this.mtxtHastaAdiAra.Location = new System.Drawing.Point(1037, 8);
            this.mtxtHastaAdiAra.MaxLength = 32767;
            this.mtxtHastaAdiAra.Name = "mtxtHastaAdiAra";
            this.mtxtHastaAdiAra.PasswordChar = '\0';
            this.mtxtHastaAdiAra.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtHastaAdiAra.SelectedText = "";
            this.mtxtHastaAdiAra.SelectionLength = 0;
            this.mtxtHastaAdiAra.SelectionStart = 0;
            this.mtxtHastaAdiAra.ShortcutsEnabled = true;
            this.mtxtHastaAdiAra.Size = new System.Drawing.Size(214, 23);
            this.mtxtHastaAdiAra.TabIndex = 2;
            this.mtxtHastaAdiAra.UseSelectable = true;
            this.mtxtHastaAdiAra.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtHastaAdiAra.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtHastaAdiAra.TextChanged += new System.EventHandler(this.mtxtHastaAdiAra_TextChanged);
            // 
            // mlblToplamHasta
            // 
            this.mlblToplamHasta.AutoSize = true;
            this.mlblToplamHasta.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlblToplamHasta.Location = new System.Drawing.Point(219, 8);
            this.mlblToplamHasta.Name = "mlblToplamHasta";
            this.mlblToplamHasta.Size = new System.Drawing.Size(22, 25);
            this.mlblToplamHasta.TabIndex = 7;
            this.mlblToplamHasta.Text = "0";
            this.mlblToplamHasta.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mlblToplamHasta.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(17, 13);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(139, 20);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Toplam Hasta Sayısı : ";
            // 
            // MaliDurum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 600);
            this.Controls.Add(this.metroPanel1);
            this.Name = "MaliDurum";
            this.Text = "MaliDurum";
            this.Load += new System.EventHandler(this.MaliDurum_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox mtxtHastaAdiAra;
        private MetroFramework.Controls.MetroListView mlvHastalarMaliDurum;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MetroFramework.Controls.MetroLabel mlblToplamHasta;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}