namespace DentistApp
{
    partial class Hastalar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtHastaAra = new MetroFramework.Controls.MetroTextBox();
            this.mlblToplamHasta = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.hastalarGrid = new MetroFramework.Controls.MetroGrid();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.ctxDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxSil = new System.Windows.Forms.ToolStripMenuItem();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hastalarGrid)).BeginInit();
            this.metroContextMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.txtHastaAra);
            this.metroPanel1.Controls.Add(this.mlblToplamHasta);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.hastalarGrid);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 12;
            this.metroPanel1.Location = new System.Drawing.Point(32, 94);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1237, 477);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 13;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(829, 23);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 20);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Hasta Ara: ";
            // 
            // txtHastaAra
            // 
            // 
            // 
            // 
            this.txtHastaAra.CustomButton.Image = null;
            this.txtHastaAra.CustomButton.Location = new System.Drawing.Point(226, 2);
            this.txtHastaAra.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtHastaAra.CustomButton.Name = "";
            this.txtHastaAra.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtHastaAra.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHastaAra.CustomButton.TabIndex = 1;
            this.txtHastaAra.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHastaAra.CustomButton.UseSelectable = true;
            this.txtHastaAra.CustomButton.Visible = false;
            this.txtHastaAra.Lines = new string[0];
            this.txtHastaAra.Location = new System.Drawing.Point(957, 18);
            this.txtHastaAra.Margin = new System.Windows.Forms.Padding(4);
            this.txtHastaAra.MaxLength = 32767;
            this.txtHastaAra.Name = "txtHastaAra";
            this.txtHastaAra.PasswordChar = '\0';
            this.txtHastaAra.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHastaAra.SelectedText = "";
            this.txtHastaAra.SelectionLength = 0;
            this.txtHastaAra.SelectionStart = 0;
            this.txtHastaAra.ShortcutsEnabled = true;
            this.txtHastaAra.Size = new System.Drawing.Size(252, 28);
            this.txtHastaAra.TabIndex = 1;
            this.txtHastaAra.UseSelectable = true;
            this.txtHastaAra.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHastaAra.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtHastaAra.TextChanged += new System.EventHandler(this.txtHastaAra_TextChanged);
            // 
            // mlblToplamHasta
            // 
            this.mlblToplamHasta.AutoSize = true;
            this.mlblToplamHasta.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlblToplamHasta.Location = new System.Drawing.Point(254, 18);
            this.mlblToplamHasta.Name = "mlblToplamHasta";
            this.mlblToplamHasta.Size = new System.Drawing.Size(22, 25);
            this.mlblToplamHasta.TabIndex = 5;
            this.mlblToplamHasta.Text = "0";
            this.mlblToplamHasta.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mlblToplamHasta.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(51, 23);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(139, 20);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Toplam Hasta Sayısı : ";
            // 
            // hastalarGrid
            // 
            this.hastalarGrid.AllowUserToResizeRows = false;
            this.hastalarGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hastalarGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hastalarGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.hastalarGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.hastalarGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.hastalarGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hastalarGrid.ContextMenuStrip = this.metroContextMenu1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.hastalarGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.hastalarGrid.EnableHeadersVisualStyles = false;
            this.hastalarGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.hastalarGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hastalarGrid.Location = new System.Drawing.Point(4, 61);
            this.hastalarGrid.Name = "hastalarGrid";
            this.hastalarGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.hastalarGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.hastalarGrid.RowHeadersWidth = 51;
            this.hastalarGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.hastalarGrid.RowTemplate.Height = 24;
            this.hastalarGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.hastalarGrid.Size = new System.Drawing.Size(1218, 369);
            this.hastalarGrid.TabIndex = 2;
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxDuzenle,
            this.ctxSil});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(211, 80);
            // 
            // ctxDuzenle
            // 
            this.ctxDuzenle.Name = "ctxDuzenle";
            this.ctxDuzenle.Size = new System.Drawing.Size(210, 24);
            this.ctxDuzenle.Text = "Düzenle";
            this.ctxDuzenle.Click += new System.EventHandler(this.ctxDuzenle_Click);
            // 
            // ctxSil
            // 
            this.ctxSil.Name = "ctxSil";
            this.ctxSil.Size = new System.Drawing.Size(210, 24);
            this.ctxSil.Text = "Sil";
            this.ctxSil.Click += new System.EventHandler(this.ctxSil_Click);
            // 
            // Hastalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 600);
            this.Controls.Add(this.metroPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Hastalar";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Hastalar";
            this.Load += new System.EventHandler(this.Hastalar_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hastalarGrid)).EndInit();
            this.metroContextMenu1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txtHastaAra;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid hastalarGrid;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel mlblToplamHasta;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem ctxDuzenle;
        private System.Windows.Forms.ToolStripMenuItem ctxSil;
    }
}