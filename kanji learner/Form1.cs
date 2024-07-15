using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kanji_learner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'bdJPWRITINGSYSTEMDataSet.HiraganaMain' table. You can move, or remove it, as needed.
                this.hiraganaMainTableAdapter.Fill(this.bdJPWRITINGSYSTEMDataSet.HiraganaMain);
            }
            catch {
                SQLInstall firstsetup = new SQLInstall();
                firstsetup.ShowDialog();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int something = 0;
            if (ckbHMAIN.Checked == true)
            {
                passagem.hiraganaMain_selected = 1;
                something = 1;
            }
            if (ckbHDAKUTEN.Checked == true)
            {
                passagem.hiraganaDakuten_selected = 1;
                something = 1;
            }
            if (ckbHCOMBINATION.Checked == true)
            {
                passagem.hiraganaCombination_selected = 1;
                something = 1;
            }
            if (ckbKMAIN.Checked == true)
            {
                passagem.KatakanaMain_selected = 1;
                something = 1;
            }
            if (ckbKDAKUTEN.Checked == true)
            {
                passagem.KatakanDakuten_selected = 1;
                something = 1;
            }
            if (ckbKCOMBINATION.Checked == true)
            {
                passagem.KatakanCombination_selected = 1;
                something = 1;
            }
            if (ckbConfirmar.Checked == false)
                passagem.ComfirmacaoResposta = 0;

            if (something != 0)
            {
                romanji_test frmromanji_Test = new romanji_test();
                frmromanji_Test.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tem de selecionar pelo menos uma das opções.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMselction_Click(object sender, EventArgs e)
        {
            int cicloadecorrer = 0;
            if (btnMselction.Text == "ALL")
            {
                ckbHMAIN.Checked = true;
                ckbHDAKUTEN.Checked = true;
                ckbHCOMBINATION.Checked = true;
                ckbKMAIN.Checked = true;
                ckbKDAKUTEN.Checked = true;
                ckbKCOMBINATION.Checked = true;
                btnMselction.Text = "NONE";
                cicloadecorrer = 1;
            }
            if (btnMselction.Text == "NONE" && cicloadecorrer == 0)
            {
                ckbHMAIN.Checked = false;
                ckbHDAKUTEN.Checked = false;
                ckbHCOMBINATION.Checked = false;
                ckbKMAIN.Checked = false;
                ckbKDAKUTEN.Checked = false;
                ckbKCOMBINATION.Checked = false;
                btnMselction.Text = "ALL";
            }
            cicloadecorrer = 0;
        }

        private void ckbHMAIN_CheckedChanged(object sender, EventArgs e)
        {
            buttonmselctverify();
        }

        private void ckbKMAIN_CheckedChanged(object sender, EventArgs e)
        {
            buttonmselctverify();
        }

        private void ckbHDAKUTEN_CheckedChanged(object sender, EventArgs e)
        {
            buttonmselctverify();
        }

        private void ckbKDAKUTEN_CheckedChanged(object sender, EventArgs e)
        {
            buttonmselctverify();
        }

        private void ckbHCOMBINATION_CheckedChanged(object sender, EventArgs e)
        {
            buttonmselctverify();
        }

        private void ckbKCOMBINATION_CheckedChanged(object sender, EventArgs e)
        {
            buttonmselctverify();
        }

        void buttonmselctverify()
        {
            if (ckbHMAIN.Checked == true && ckbHDAKUTEN.Checked == true && ckbHCOMBINATION.Checked == true && ckbKMAIN.Checked == true && ckbKDAKUTEN.Checked == true && ckbKCOMBINATION.Checked == true)
            {
                btnMselction.Text = "NONE";
            }
            else
                btnMselction.Text = "ALL";
        }

        private void btnEditar_BD_Click(object sender, EventArgs e)
        {
            editorBD frmromanji_Test = new editorBD();
            frmromanji_Test.Show();
            this.Hide();
        }
    }
}
