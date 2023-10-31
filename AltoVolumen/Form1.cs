using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AltoVolumen
{
    public partial class Form1 : Form
    {
        RegUsuForm regUsu;  
        public Form1()
        {
            InitializeComponent();

            regUsu = new RegUsuForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AceptarB_Click(object sender, EventArgs e)
        {
            regUsu.ShowDialog();
        }
    }
}
