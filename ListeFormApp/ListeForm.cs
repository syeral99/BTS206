﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListeFormApp
{
    public partial class ListeForm : Form
    {
        public ListeForm()
        {
            InitializeComponent();
        }

        private void lbListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = lbListe.Text;
        }

        private void ListeForm_Load(object sender, EventArgs e)
        {
            lbListe.Items.Add("Hercai");
            lbListe.SelectedIndex = lbListe.Items.Count - 1;
        }

        private void lbListe_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                while (lbListe.SelectedItems.Count > 0)
                {
                    lbListe.Items.Remove(lbListe.SelectedItem);
                }
            }
        }
    }
}
