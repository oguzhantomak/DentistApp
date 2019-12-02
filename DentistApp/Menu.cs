﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace DentistApp
{
    public partial class Menu : MetroForm
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMenuTarih.Text = DateTime.Now.ToLongDateString();
        }

        private void mtHastalar_Click(object sender, EventArgs e)
        {
            Hastalar HastalarPage = new Hastalar();
            HastalarPage.ShowDialog();
        }

        private void mtMaliDurum_Click(object sender, EventArgs e)
        {
            MaliDurum MaliDurumPage = new MaliDurum();
            MaliDurumPage.ShowDialog();
        }

        private void mtStok_Click(object sender, EventArgs e)
        {
            Stok StokPage = new Stok();
            StokPage.ShowDialog();
        }

        private void mtRandevular_Click(object sender, EventArgs e)
        {
            Randevular RandevularPage = new Randevular();
            RandevularPage.ShowDialog();
        }

        private void mtYeniHastaKaydi_Click(object sender, EventArgs e)
        {
            YeniHastaKaydi YeniHastaKaydiPage = new YeniHastaKaydi();
            YeniHastaKaydiPage.ShowDialog();
        }

        private void mtRandevuVer_Click(object sender, EventArgs e)
        {
            Randevular RandevularPage = new Randevular();
            RandevularPage.ShowDialog();
        }
    }
}
