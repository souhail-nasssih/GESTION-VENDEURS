﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GESTION_VENDEURS.Form2;

namespace GESTION_VENDEURS
{
    public partial class Form1 : Form
    {
        private int id_cv;
        private string nom;
        private string tel;
        private string cin;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);

            Profil p = new Profil(PlaceManager.NomPlace);
            p.TopLevel = false;
            pnlC.Controls.Add(p);
            p.BringToFront();
            p.Show();

        }

        private void gunaControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Profil p = new Profil(PlaceManager.NomPlace);
            p.TopLevel = false;
            pnlC.Controls.Add(p);
            p.BringToFront();
            p.Show();
        }

        private void pnlC_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Form2 p = new Form2();
            p.Show();
            this.Hide();

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            clients p = new clients();
            p.TopLevel = false;
            pnlC.Controls.Add(p);
            p.BringToFront();
            p.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
           H_vents p = new H_vents();
            p.TopLevel = false;
            pnlC.Controls.Add(p);
            p.BringToFront();
            p.Show();
        }
    }
}
