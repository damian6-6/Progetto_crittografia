using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

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

            if (string.IsNullOrEmpty(stringa) || string.IsNullOrEmpty(txt_chiave2.Text))
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

        private void btn_conferma3_Click(object sender, EventArgs e)
        {
            string stringa = txt_stringa2.Text;
            string chiave = txt_chiave3.Text;
            if (string.IsNullOrEmpty(stringa) || string.IsNullOrEmpty(chiave))
                return;

            string alfabetoMinuscolo = "abcdefghijklmnopqrstuvwxyz";
            string alfabetoMaiuscolo = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string chiaveMinuscola = chiave.ToLower();

            string risultato = "";
            int indiceChiave = 0;

            foreach (char letteraTesto in stringa)
            {
                if (char.IsLetter(letteraTesto))
                {
                    
                    bool eMaiuscola = char.IsUpper(letteraTesto);
                    string alfabeto = eMaiuscola ? alfabetoMaiuscolo : alfabetoMinuscolo;

                   
                    int posizioneTesto = alfabeto.IndexOf(letteraTesto);

                   
                    char letteraChiave = chiaveMinuscola[indiceChiave % chiaveMinuscola.Length];
                    int posizioneChiave = alfabetoMinuscolo.IndexOf(letteraChiave);

                    
                    int nuovaPosizione = posizioneTesto + posizioneChiave;

                   
                    if (nuovaPosizione >= 26)
                    {
                        nuovaPosizione = nuovaPosizione - 26;
                    }

                    
                    char letteraCifrata = alfabeto[nuovaPosizione];
                    risultato = risultato + letteraCifrata;

                    
                    indiceChiave++;
                }
                else
                {
                    
                    risultato = risultato + letteraTesto;
                }
            }

            lbl_n9.Text = risultato;

        }

        private void btn_conferma4_Click(object sender, EventArgs e)
        {
            string stringa = txt_codice2.Text;
            string chiave = txt_chiave4.Text;
            if (string.IsNullOrEmpty(stringa) || string.IsNullOrEmpty(chiave))
                return;

            string alfabetoMinuscolo = "abcdefghijklmnopqrstuvwxyz";
            string alfabetoMaiuscolo = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string chiaveMinuscola = chiave.ToLower().Trim();

            string risultato = "";
            int indiceChiave = 0;

            foreach (char letteraTesto in stringa)
            {
                if (char.IsLetter(letteraTesto))
                {

                    bool eMaiuscola = char.IsUpper(letteraTesto);
                    string alfabeto = eMaiuscola ? alfabetoMaiuscolo : alfabetoMinuscolo;


                    int posizioneTesto = alfabeto.IndexOf(letteraTesto);


                    char letteraChiave = chiaveMinuscola[indiceChiave % chiaveMinuscola.Length];
                    int posizioneChiave = alfabetoMinuscolo.IndexOf(letteraChiave);


                    int nuovaPosizione = posizioneTesto - posizioneChiave;


                    if (nuovaPosizione < 0)
                    {
                        nuovaPosizione = nuovaPosizione + 26;
                    }


                    char letteraCifrata = alfabeto[nuovaPosizione];
                    risultato = risultato + letteraCifrata;


                    indiceChiave++;
                }
                else
                {

                    risultato = risultato + letteraTesto;
                }
            }

            lbl_n12.Text = risultato;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    }


