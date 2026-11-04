using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progetto_crittografia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_conferma_Click(object sender, EventArgs e)
        {
            string stringa = txt_stringa.Text;
            int chiave = Convert.ToInt32( txt_chiave.Text);

            if (string.IsNullOrEmpty(stringa))
            {
                MessageBox.Show("inserisci una stringa e numero di chiave valido");
            }
            else
            {
                for (int i = 0; i < stringa.Length; i++) 
                {




                }


        }
    }
}
