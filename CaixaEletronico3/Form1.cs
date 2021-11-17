using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronico3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta lucas = new Conta();
            Conta mario = new Conta();
                       

            lucas.saldo = 4500.0;
            mario.saldo = 3570.0;

            lucas.Transfere(200,mario);
            MessageBox.Show("Lucas" + lucas.saldo);
            MessageBox.Show("Mario" + mario.saldo);
        }
    }
}
