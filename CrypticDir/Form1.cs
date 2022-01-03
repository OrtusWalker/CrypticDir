﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrypticDir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Point lastMousePosition;
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActiveForm.WindowState = FormWindowState.Minimized;
        }

        private void Form_MouseDownFormMoving(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void formMoving(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePosition = MousePosition;
                int dx = mousePosition.X - lastMousePosition.X;
                int dy = mousePosition.Y - lastMousePosition.Y;
                Point _Location = new Point(Location.X + dx, Location.Y + dy);
                Location = _Location;
                lastMousePosition = mousePosition;
                if (Location.Y < 0)
                {
                    Location = new Point(Location.X, 0);
                }
            }
        } //   ***DONE***

        private void formMovingSetPoint(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lastMousePosition = MousePosition;
            }
        } //   ***DONE***

        public void formMovingEvents(Control control)
        {
            control.MouseDown += formMovingSetPoint;
            control.MouseMove += formMoving;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            formMovingEvents(programTitlePanel);
            foreach (Control item in programTitlePanel.Controls)
            {
                formMovingEvents(item);
            }
            programBodyPanel.Dock = DockStyle.Fill;
        }
    }
}
