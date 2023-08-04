using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoRpgInterface
{
    public partial class Login : Form
    {
        Form1 ent;
        public Login()
        {
            InitializeComponent();
            ent = new Form1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ent.ShowDialog();
        }//Iniciar
    }
}
