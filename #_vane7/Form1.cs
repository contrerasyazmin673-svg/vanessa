using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace __vane7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            if (textBox1.Text == "galleta" && textBox2.Text == "1234")
            {
                principal ventana = new principal();
                ventana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Acceso denegado");
            }
        }
    }
    }

