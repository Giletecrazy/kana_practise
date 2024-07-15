using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace kanji_learner
{
    public partial class romanji_test : Form
    {
        SqlDataReader dr;
        List<string> symbol =new List<string>();
        List<string> romanji = new List<string>();
        int estadoshift = 0, numero,erradas=0;
        int tamanholista = 0;
        Random rnd = new Random();
        public romanji_test()
        {
            InitializeComponent();
        }

        private void romanji_test_Load(object sender, EventArgs e)
        {
            if (passagem.ComfirmacaoResposta == 1)
                btnNext.Text = "Verificar";
            if (passagem.hiraganaMain_selected == 1)
                lerdadosBD("HiraganaMain");
            if (passagem.hiraganaDakuten_selected == 1)
                lerdadosBD("HiraganaDakuten");
            if (passagem.hiraganaCombination_selected == 1)
                lerdadosBD("HiraganaCombination");
            if (passagem.KatakanaMain_selected == 1)
                lerdadosBD("KatakanaMain");
            if (passagem.KatakanDakuten_selected == 1)
                lerdadosBD("KatakanaDakuten");
            if (passagem.KatakanCombination_selected == 1)
                lerdadosBD("KatakanaaCombination");

            numero = rnd.Next(1, tamanholista);
            lblSymbol.Text=symbol[numero - 1];
            passagem.tamanhotabela = tamanholista;
        }

        void lerdadosBD(string tabela)
        {
            passagem.liga.Open();
            SqlCommand comando = new SqlCommand("Select * from "+ tabela, passagem.liga);
            dr = comando.ExecuteReader();
            while (dr.Read())
            {
                tamanholista++;
                symbol.Add(dr["Hiragana"].ToString());
                romanji.Add(dr["Romanji"].ToString());
            }
            passagem.liga.Close();
        }

        private void romanji_test_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnUkeyboard_Click(object sender, EventArgs e)
        {
            keyboardwrite(btnUkeyboard.Text);
        }

        private void btnOkeyboard_Click(object sender, EventArgs e)
        {
            keyboardwrite(btnOkeyboard.Text);
        }

        private void btnIkeyboard_Click(object sender, EventArgs e)
        {
            keyboardwrite(btnIkeyboard.Text);
        }

        private void btnEkeyboard_Click(object sender, EventArgs e)
        {
            keyboardwrite(btnEkeyboard.Text);
        }

        private void btnAkeyboard_Click(object sender, EventArgs e)
        {
            keyboardwrite(btnAkeyboard.Text);
        }
        void keyboardwrite(string letra)
        {
                txtResposta.AppendText(letra);
                if (estadoshift == 1)
                    btnShift.PerformClick();
        }

        private void btnShift_Click(object sender, EventArgs e)
        {
            if (estadoshift == 0)
            {
                btnShift.ForeColor = Color.Black;
                btnShift.BackColor = Color.White;
                btnAkeyboard.Text = "Ā";
                btnEkeyboard.Text = "Ē";
                btnIkeyboard.Text = "Ī";
                btnOkeyboard.Text = "Ō";
                btnUkeyboard.Text = "Ū";
                estadoshift = 1;
            }
            else
            {
                btnShift.ForeColor = Color.Black;
                btnShift.BackColor = Color.Thistle;
                btnAkeyboard.Text = "ā";
                btnEkeyboard.Text = "ē";
                btnIkeyboard.Text = "ī";
                btnOkeyboard.Text = "ō";
                btnUkeyboard.Text = "ū";
                estadoshift = 0;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(btnNext.Text=="Next")
            {
                passagem.symbol.Add(lblSymbol.Text);
                if (romanji[numero - 1] == txtResposta.Text)
                {
                    passagem.erradas.Add(erradas.ToString());
                }
                else
                    passagem.erradas.Add("1");
                newSymbol();
                if (passagem.ComfirmacaoResposta == 1)
                    btnNext.Text = "Verificar";
            }
            else
            {
                if (romanji[numero - 1] == txtResposta.Text)
                {
                    this.BackColor = Color.Green;
                    //passagem.erradas.Add(erradas.ToString());
                    btnNext.Text = "Next";
                }
                else
                {
                    this.BackColor = Color.Red;
                    erradas++;
                }
            }
        }

        private void txtResposta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnNext.PerformClick();
            }
        }

        void compararesposta()
        {
            
        }

        void newSymbol()
        {
            erradas = 0;
            txtResposta.Text = "";
            if(estadoshift == 1)
                btnShift.PerformClick();
                string tmp = symbol[numero - 1];
                symbol[numero - 1] = symbol[tamanholista-1];
                symbol[tamanholista - 1] = tmp;
                tmp = romanji[numero - 1];
                romanji[numero - 1] = romanji[tamanholista-1];
                romanji[tamanholista-1] = tmp;
                numero = rnd.Next(1, tamanholista);
                lblSymbol.Text = symbol[numero - 1];
            tamanholista--;
            this.BackColor = Color.RoyalBlue;
            if(tamanholista==0)
            {
                Resultado frm = new Resultado();
                frm.Show();
                this.Hide();
            }
        }
    }
}
