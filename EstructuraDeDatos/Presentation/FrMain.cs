using EstructuraDeDatos.Presentation.Pilas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EstructuraDeDatos.Presentation
{
    public partial class FrMain : Form
    {
        public FrMain()
        {
            InitializeComponent();
        }

        private void navegacionListasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Application.OpenForms.OfType<FrLista>().FirstOrDefault()
            FrLista frLista = new FrLista();
            frLista.MdiParent = this;
            frLista.Show();
        }


        private void listaBasicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrListaBasica frListaBasica = new FrListaBasica();
            frListaBasica.MdiParent = this;
            frListaBasica.Show();
        }

        private void pilaBasicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrPilaBasica frPilaBasica = new FrPilaBasica();
            frPilaBasica.MdiParent = this;
            frPilaBasica.Show();
        }

        private void torreDeHanoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrHanoiTower frHanoiTower = new FrHanoiTower();
            frHanoiTower.MdiParent = this;
            frHanoiTower.Show();
        }
    }
}
