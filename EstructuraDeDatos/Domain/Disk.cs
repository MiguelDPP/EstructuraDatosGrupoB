using System;
using System.Collections.Generic;
using System.Text;

namespace EstructuraDeDatos.Domain
{
    internal class Disk
    {
        public int DiskNumber { get; set; }
        public Color Color { get; set; }
        public Panel Panel { get; set; }

        public Disk(int diskNumber, Color color)
        {
            Color = color;
            DiskNumber = diskNumber;
            Panel = new Panel
            {
                BackColor = Color
            };
            Label label = new Label
            {
                Text = diskNumber.ToString(),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
            Panel.Controls.Add(label);
        }

        public void SetProperties(int width, int  height, Point location) 
        {
            Panel.Width = width;
            Panel.Height = height;
            Panel.Location = location;
        }

    }
}
