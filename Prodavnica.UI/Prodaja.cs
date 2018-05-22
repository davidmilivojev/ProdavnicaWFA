using ProdavnicaPica.Domain;
using ProdavnicaPica.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prodavnica.UI
{
    public partial class Prodaja : Form
    {
        public Prodaja()
        {
            InitializeComponent();

            var data = new PiceViewModel().GetAll().ToList();

            foreach (var item in data)
            {
                prodajaCbx.Items.Add(item);
            }

            prodajaCbx.DisplayMember = "Naziv";
            prodajaCbx.ValueMember = "ID";
        }

        private void prodajPiceBtn_Click(object sender, EventArgs e)
        {
            //Operacije operacije = new Operacije();
            //var pice = prodajaCbx.SelectedItem as PiceModel;
            //operacije.Prodaja(pice.ID, 1);
        }
    }
}
