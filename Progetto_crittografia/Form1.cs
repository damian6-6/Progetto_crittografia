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
            int chiave = Convert.ToInt32(txt_chiave.Text) %26;

            if (string.IsNullOrEmpty(stringa))
            {
                MessageBox.Show("inserisci una stringa e numero di chiave valido");
            }
            else
            {
                char[] risultato = stringa.ToCharArray();
                for (int i = 0; i < stringa.Length; i++)
                {
                    char c = risultato[i]; 
                    if (c >= 'A' && c <= 'Z')
                    {
                        risultato[i] = (char)('A' + (c - 'A' + chiave + 26) % 26);
                    }
                    else if (c >= 'a' && c <= 'z')
                    {
                        risultato[i] = (char)('a' + (c - 'a' + chiave + 26) % 26);
                    }
                    lbl_n3.Text = new string(risultato);


                }


            }
        }

        private void btn_conferma2_Click(object sender, EventArgs e)
        {
            string stringa = txt_codice.Text;
            int chiave = Convert.ToInt32(txt_chiave2.Text) %26;

            if (string.IsNullOrEmpty(stringa))
            {
                MessageBox.Show("inserisci una stringa e numero di chiave valido");
            }
            else
            {
                char[] risultato = stringa.ToCharArray();
                for (int i = 0; i < stringa.Length; i++)
                {
                    char c = risultato[i];
                    if (c >= 'A' && c <= 'Z')
                    {
                        risultato[i] = (char)('A' + (c - 'A'-chiave + 26) % 26);
                    }
                    
            else if (c >= 'a' && c <= 'z')
                    {
                        risultato[i] = (char)('a' + (c - 'a' - chiave + 26) % 26);
                    }
                    lbl_n6.Text = new string(risultato);


                }


            }
        }
    }
    }


