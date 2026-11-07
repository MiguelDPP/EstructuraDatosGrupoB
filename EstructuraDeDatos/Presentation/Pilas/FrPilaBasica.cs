using EstructuraDeDatos.Domain;
using EstructuraDeDatos.DynamicStructure;
using EstructuraDeDatos.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EstructuraDeDatos.Presentation.Pilas
{
    public partial class FrPilaBasica : Form
    {
        private Pila<string> _pilaPending;
        private Pila<string> _pilaPaid;

        public FrPilaBasica()
        {
            InitializeComponent();
            _pilaPaid = new Pila<string>();
            _pilaPending = new Pila<string>();
        }

        private void updateListBox(ListView listView, Pila<string> pila)
        {
            listView.Items.Clear();

            foreach(string data in pila)
            {
                listView.Items.Add(data);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAddProduct.Text != string.Empty)
            {
                _pilaPending.Push(txtAddProduct.Text);
                updateListBox(listViewPendding, _pilaPending);
                txtAddProduct.Text = string.Empty;
            } else
            {
                MessageBox.Show("Eror: Ingrese un producto");
            }
        }

        private void btnClearPending_Click(object sender, EventArgs e)
        {
            _pilaPending.Clear();
            updateListBox(listViewPendding, _pilaPending);
        }

        private void btnPassToPaid_Click(object sender, EventArgs e)
        {
            if (!_pilaPending.IsEmpty)
            {
                string producto = _pilaPending.Pop();
                _pilaPaid.Push(producto);
                updateListBox(listViewPendding, _pilaPending);
                updateListBox(listViewPaid, _pilaPaid);
            }
        }

        private void btnPassToPedding_Click(object sender, EventArgs e)
        {
            if (!_pilaPaid.IsEmpty)
            {
                string producto = _pilaPaid.Pop();
                _pilaPending.Push(producto);
                updateListBox(listViewPendding, _pilaPending);
                updateListBox(listViewPaid, _pilaPaid);
            }
        }

        private void btnClearPaid_Click(object sender, EventArgs e)
        {
            _pilaPaid.Clear();
            updateListBox(listViewPaid, _pilaPaid);
        }
    }
}
