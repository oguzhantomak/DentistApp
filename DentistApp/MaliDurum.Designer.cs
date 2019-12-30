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
            this.mtxtHastaAdiAra = new MetroFramework.Controls.MetroTextBox();
            this.mlvHastalarMaliDurum = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.mlvHastalarMaliDurum);
            this.metroPanel1.Controls.Add(this.mtxtHastaAdiAra);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(760, 370);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
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
            this.mtxtHastaAdiAra.Location = new System.Drawing.Point(215, 4);
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
            // mlvHastalarMaliDurum
            // 
            this.mlvHastalarMaliDurum.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.mlvHastalarMaliDurum.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mlvHastalarMaliDurum.FullRowSelect = true;
            this.mlvHastalarMaliDurum.Location = new System.Drawing.Point(17, 41);
            this.mlvHastalarMaliDurum.Name = "mlvHastalarMaliDurum";
            this.mlvHastalarMaliDurum.OwnerDraw = true;
            this.mlvHastalarMaliDurum.Size = new System.Drawing.Size(727, 310);
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
            // MaliDurum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroPanel1);
            this.Name = "MaliDurum";
            this.Text = "MaliDurum";
            this.Load += new System.EventHandler(this.MaliDurum_Load);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox mtxtHastaAdiAra;
        private MetroFramework.Controls.MetroListView mlvHastalarMaliDurum;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}