using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices.ActiveDirectory;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace shifr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        connect database = new connect();

        void encryptCaeser()
        {
            string alphabet = " abcdefghijklmnopqrstuvwxyz";
            string need_enc=NeedEncrCaesar.Text.ToString();
            string encrypted = "";
            int KEY = Convert.ToInt16(keyCaeser.Text);
            for(int i=0; i<need_enc.Length; i++)
            {                
                int find = alphabet.IndexOf(need_enc[i]);
                if(find+KEY<alphabet.Length)
                {
                    encrypted += alphabet[find + KEY];
                }
                else
                {
                    int refind = alphabet.Length - find + KEY-1;
                    encrypted += alphabet[refind];
                }
                
            }
            encCaesar.Text = encrypted;
        }
        void hackingCaeser()
        {
            
            string alphabet = " abcdefghijklmnopqrstuvwxyz";
            string encrypted = encCaesar.Text.ToString();
            string hacked = "";
            for(int key=0; key<alphabet.Length; key++)
            {
                hacked = "";
                for (int i = 0; i < encrypted.Length; i++)
                {
                    int find = alphabet.IndexOf(encrypted[i]);
                    if (find - key < 0)
                    {
                        hacked += alphabet[key-find-1];
                    }
                    else
                    {
                        int refind = find - key;
                        hacked += alphabet[refind];
                    }
                }
                hackedWordsCaeser.Items.Add(hacked);
            }
        }

        void encryptVisionere()
        {
            string alphabet = " abcdefghijklmnopqrstuvwxyz";
            string need_enc = needEncryptVisinere.Text.ToString();
            int length = need_enc.Length;
            string encrypted = "";
            string key_word = keyVisinere.Text.ToString();
            string key = "";
            int k = 0;
            int i = 0;
            while(k<length)
            {
                if (i >= key_word.Length) i = 0;
                key+= key_word[i];
                k++;
                i++;
            }
            VisinereFinishKey.Text = key;
            for(int j=0; j<length; j++)
            {
                int x = alphabet.IndexOf(need_enc[j]);
                int y = alphabet.IndexOf(key[j]);
                if (x + y >= alphabet.Length)
                {                   
                    encrypted+= alphabet[x + y - alphabet.Length];
                }
                else
                {
                    encrypted += alphabet[x + y];
                }
            }
            encVisinere.Text = encrypted;
        }
        void hackCeaser(string encrypted)
        {
            string alphabet = " abcdefghijklmnopqrstuvwxyz";
            char[] pass = encrypted.ToCharArray();
            char frequentLetter = ' ';
            int frequencyMax = 0;
            int frequency = 0;
            int raznisa;
            char[] text = new char[encCaesar.Text.Length];


            for (int i = 0; i < pass.Length; i++)
            {
                frequentLetter = pass[i];
                for (int j = 0; j < pass.Length; j++)
                {
                    if (frequentLetter == pass[j] && i!=j)
                    {
                        frequency++;
                    }
                }
                if (frequencyMax < frequency)
                {
                    frequencyMax = frequency;
                    frequentLetter = pass[i];
                    frequency = 0;
                }
                else
                {
                    frequentLetter = pass[i];
                }
            }
            string frec = "";
                frec += frequentLetter;
            for (int i = 0; i < pass.Length; i++)
            {

                raznisa = Math.Abs(alphabet.IndexOf(frec) - alphabet.IndexOf("a"));
                string ch = "";
                int x = alphabet.IndexOf(pass[i]);
                if ( x- raznisa < 0)
                {
                    ch += alphabet[alphabet.Length + x - raznisa];
                    text[i] = ch[0];
                }
                else
                {
                    ch += alphabet[x - raznisa];
                    text[i] = ch[0];
                }
            }
            hackedWordsCaeser.Items.Add(new string(text));
            for (int i = 0; i < pass.Length; i++)
            {
                raznisa = Math.Abs(alphabet.IndexOf(frec) - alphabet.IndexOf("e"));
                string ch = "";
                int x = alphabet.IndexOf(pass[i]);
                if (x - raznisa < 0)
                {
                    ch += alphabet[alphabet.Length + x - raznisa];
                    text[i] = ch[0];
                }
                else
                {
                    ch += alphabet[x - raznisa];
                    text[i] = ch[0];
                }
            }
            hackedWordsCaeser.Items.Add(new string(text));
            for (int i = 0; i < pass.Length; i++)
            {
                raznisa = Math.Abs(alphabet.IndexOf(frec) - alphabet.IndexOf("o"));

                string ch = "";
                int x = alphabet.IndexOf(pass[i]);
                if (x - raznisa < 0)
                {
                    ch += alphabet[alphabet.Length + x - raznisa];
                    text[i] = ch[0];
                }
                else
                {
                    ch += alphabet[x - raznisa];
                    text[i] = ch[0];
                }

            }

            hackedWordsCaeser.Items.Add(new string(text));
        }
        void hackVisionere()
        {
            int length_key = Convert.ToInt16(hackVisineretxt.Text);
            string need_deEnc = encVisinere.Text.ToString();
            int length = need_deEnc.Length;
            string encrypted = "";
            string query = $"select word from all_words where LEN(word)={length_key}";
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand(query, database.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count != 0)
            {
                dataGrid.DataSource = table;
            }
            string alphabet = " abcdefghijklmnopqrstuvwxyz";
            string key = "";
            string key_word = "";

            for (int i = 0; i < dataGrid.Rows.Count-1; i++)
            {
                key_word = dataGrid.Rows[i].Cells[0].Value.ToString();
                key = "";
                encrypted = "";
                int k = 0;
                int l = 0;
                while (k < need_deEnc.Length)
                {
                    if (l >= key_word.Length && l != 0) l = 0;
                    key += key_word[l];
                    k++;
                    l++;
                }
                for (int j = 0; j < length; j++)
                {
                    int x = alphabet.IndexOf(need_deEnc[j]);
                    int y = alphabet.IndexOf(key[j]);
                    if (x - y < 0)
                    {
                        encrypted += alphabet[x - y + alphabet.Length];
                    }
                    else
                    {
                        encrypted += alphabet[x - y];
                    }
                }
                hackWordsVisinere.Items.Add(encrypted);
            }


        }
        void deEncrypteVisinere()
        {

            string alphabet = " abcdefghijklmnopqrstuvwxyz";
            string need_deEnc = encVisinere.Text.ToString();
            int length = need_deEnc.Length;
            string encrypted = "";           
            string key = VisinereFinishKey.Text.ToString();
            for (int j = 0; j < length; j++)
            {
                int x = alphabet.IndexOf(need_deEnc[j]);
                int y = alphabet.IndexOf(key[j]);
                if (x - y < 0)
                {
                    encrypted += alphabet[x - y + alphabet.Length];
                }
                else
                {
                    encrypted += alphabet[x - y];
                }
            }
            deEncryptedVisinere.Text = encrypted;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            encryptCaeser();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            encryptVisionere();
        }

        private void hackCaeser_Click(object sender, EventArgs e)
        {
            //hackCeaser(encCaesar.Text);
            hackingCaeser();
        }

        private void deEncVisinere_Click(object sender, EventArgs e)
        {
            deEncrypteVisinere();
        }

        private void hackVisinere_Click(object sender, EventArgs e)
        {
            hackVisionere();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}