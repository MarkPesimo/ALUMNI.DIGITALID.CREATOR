using AlumniDigitalIDTool.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlumniDigitalIDCreator
{
    public partial class menu_frm : Form
    {
        public menu_frm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlumniIdCreator _frm = new AlumniIdCreator();
            _frm.BringToFront();
            _frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //QRGenerator _frm = new QRGenerator();
            QRCodeGenerator _frm = new QRCodeGenerator();
            _frm.BringToFront();
            _frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PasswordGenerator _frm = new PasswordGenerator();
            _frm.BringToFront();
            _frm.ShowDialog();
        }
    }
}
