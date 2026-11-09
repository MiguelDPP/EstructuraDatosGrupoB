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
    public partial class FrHanoiTower : Form
    {
        private Pila<Disk> _pila1;
        private Pila<Disk> _pila2;
        private Pila<Disk> _pila3;

        private Pila<Disk> _current;
        private int _diskNumber;


        public FrHanoiTower()
        {
            InitializeComponent();
            _pila1 = new Pila<Disk>();
            _pila2 = new Pila<Disk>();
            _pila3 = new Pila<Disk>();
        }

        private void Restart()
        {
            _pila1.Clear();
            _pila2.Clear();
            _pila3.Clear();

            Random random = new Random();
            int r, g, b;

            for (int i = _diskNumber; i > 0; i--)
            {
                r = random.Next(0, 255);
                g = random.Next(0, 255);
                b = random.Next(0, 255);

                Disk disk = new Disk(i, Color.FromArgb(r, g, b));
                _pila1.Push(disk);
            }

            UpdateDisk(panelPila1, _pila1);
            UpdateDisk(panelPila2, _pila2);
            UpdateDisk(panelPila3, _pila3);
        }

        private void UpdateDisk(Panel panel, Pila<Disk> pila)
        {
            panel.Controls.Clear();

            int minWidth = (panel.Width * 20) / 100;
            double paso = (panel.Width - minWidth) / _diskNumber;

            int disKWitdh = minWidth;
            int diskHeght = panel.Height / _diskNumber;


            int positionX = 0;
            int positionY = panel.Height - diskHeght*pila.Count;

            foreach (Disk disk in pila)
            {
                positionX = (panel.Width - disKWitdh) / 2;

                disk.SetProperties(disKWitdh, diskHeght, new Point(positionX, positionY));
                panel.Controls.Add(disk.Panel);
                disKWitdh += (int)paso;
                positionY += diskHeght;
            }
        }

        private void FrHanoiTower_SizeChanged(object sender, EventArgs e)
        {
            Tool.resizeWitdhControls(this, lbTitle, 20);
            Tool.resizeHeightControls(this, panelPilas, 60);
            Tool.resizeWitdhControls(this, panelPilas, 40);

            Tool.resizeHeightControls(panelPilas, panelPila1, 20);
            Tool.resizeHeightControls(panelPilas, panelPila2, 20);
            Tool.resizeHeightControls(panelPilas, panelPila3, 20);

            resizeHorizontalControls(panelPilas, 20);
        }

        //Mirar si lo agrego al tool o lo dejo aqui
        private void resizeHorizontalControls(Control parent, int margin)
        {
            int width;
            if (parent.Controls.Count > 0)
            {
                width = (parent.Width - ((parent.Controls.Count + 1) * margin)) / parent.Controls.Count;
            }
            else
            {
                return;
            }
            int positionX = margin;
            foreach (Control control in parent.Controls)
            {
                control.Width = width;
                control.Left = positionX;
                positionX += width + margin;
            }
        }

        private void btnReboot_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDiskNumber.Text, out _diskNumber))
            {
                Restart();
            }
            else
            {
                MessageBox.Show("Ingrese un numero valido");
            }
        }

        private Pila<Disk> getPila(Panel panel)
        {
            switch (panel.Name)
            {
                case "panelPila1":
                    return _pila1;
                case "panelPila2":
                    return _pila2;
                case "panelPila3":
                    return _pila3;
            }

            return null;
        }

        private void mover_Click(object sender, EventArgs e)
        {
            Panel panelCurrent = (Panel)sender;
            if (_current == null)
            {
                _current = getPila(panelCurrent);

                if (_current.Count == 0) _current = null;
            } else
            {
                Pila<Disk> pilaDestino = getPila(panelCurrent);


                if (pilaDestino.IsEmpty || _current.Peek().DiskNumber < pilaDestino.Peek().DiskNumber)
                {
                    pilaDestino.Push(_current.Pop());
                    UpdateDisk(panelPila1, _pila1);
                    UpdateDisk(panelPila2, _pila2);
                    UpdateDisk(panelPila3, _pila3);
                }

                _current = null;

            }
        }
    }
}
