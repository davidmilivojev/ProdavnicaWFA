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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void piceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllForms();
            Prodaja prodaja = new Prodaja();
            prodaja.MdiParent = this;

            prodaja.WindowState = FormWindowState.Maximized;
            prodaja.ControlBox = false;

            prodaja.Show();
        }

        private void CloseAllForms()
        {

            Form[] formToClose = null;
            int i = 1;

            foreach (Form form in Application.OpenForms)
            {
                if (form != this)
                {
                    Array.Resize(ref formToClose, i);
                    formToClose[i - 1] = form;
                    i++;
                }
            }
            if (formToClose != null)

                for (int j = 0; j < formToClose.Length; j++)
                    formToClose[j].Dispose();
        }

        private void operaterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllForms();
            Unos unos = new Unos();
            unos.MdiParent = this;

            unos.WindowState = FormWindowState.Maximized;
            unos.ControlBox = false;

            unos.Show();
        }
    }
}
