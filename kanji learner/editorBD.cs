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
    public partial class editorBD : Form
    {
        int estadoshift=0,NONEDIT=0;
        public editorBD()
        {
            InitializeComponent();
        }

        private void editorBD_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void hiraganaToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            ClearALL();
            readonlytext();
            hiraganaToolStripMenuItem.PerformClick();
            hiraganaToolStripMenuItem.ShowDropDown();
            lblType.Text = "Hiragana:";
        }

        private void katakanaToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            ClearALL();
            readonlytext();
            katakanaToolStripMenuItem.PerformClick();
            katakanaToolStripMenuItem.ShowDropDown();
            lblType.Text = "Katakana:";
        }
        private void hiraganaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearALL();
            readonlytext();
            lblType.Text = "Hiragana:";
        }

        private void katakanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearALL();
            readonlytext();
            lblType.Text = "Katakana:";
        }
        void readonlytext()
        {
            txtROMANJI.ReadOnly = true;
        }

        void ClearALL()
        {
            dgvHMAIN.Visible = false;
            dgvHDAKUTEN.Visible = false;
            dgvHCOMBINATIONS.Visible =false;
            dgvKMAIN.Visible = false;
            dgvKDAKUTEN.Visible = false;
            dgvKCOMBINATIONS.Visible = false;
            gpbEDIT.Visible = false;
            txtROMANJI.Text = "";
            txtSCRIBLE.Text = "";
            NONEDIT = 0;
        }
        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearALL();
            dgvHMAIN.Visible = true;
        }

        private void dakutenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearALL();
            dgvHDAKUTEN.Visible = true;
        }

        private void combinationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearALL();
            dgvHCOMBINATIONS.Visible = true;
        }

        private void mainToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClearALL();
            dgvKMAIN.Visible = true;
        }

        private void dakutenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClearALL();
            dgvKDAKUTEN.Visible = true;
        }

        private void combinationsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClearALL();
            dgvKCOMBINATIONS.Visible = true;
        }

        private void editorBD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bdJPWRITINGSYSTEMDataSet6.KatakanaaCombination' table. You can move, or remove it, as needed.
            this.katakanaaCombinationTableAdapter.Fill(this.bdJPWRITINGSYSTEMDataSet6.KatakanaaCombination);
            // TODO: This line of code loads data into the 'bdJPWRITINGSYSTEMDataSet5.KatakanaDakuten' table. You can move, or remove it, as needed.
            this.katakanaDakutenTableAdapter.Fill(this.bdJPWRITINGSYSTEMDataSet5.KatakanaDakuten);
            // TODO: This line of code loads data into the 'bdJPWRITINGSYSTEMDataSet4.KatakanaMain' table. You can move, or remove it, as needed.
            this.katakanaMainTableAdapter.Fill(this.bdJPWRITINGSYSTEMDataSet4.KatakanaMain);
            // TODO: This line of code loads data into the 'bdJPWRITINGSYSTEMDataSet3.HiraganaCombination' table. You can move, or remove it, as needed.
            this.hiraganaCombinationTableAdapter.Fill(this.bdJPWRITINGSYSTEMDataSet3.HiraganaCombination);
            // TODO: This line of code loads data into the 'bdJPWRITINGSYSTEMDataSet2.HiraganaDakuten' table. You can move, or remove it, as needed.
            this.hiraganaDakutenTableAdapter.Fill(this.bdJPWRITINGSYSTEMDataSet2.HiraganaDakuten);
            // TODO: This line of code loads data into the 'bdJPWRITINGSYSTEMDataSet1.HiraganaMain' table. You can move, or remove it, as needed.
            this.hiraganaMainTableAdapter.Fill(this.bdJPWRITINGSYSTEMDataSet1.HiraganaMain);

        }

        private void dgvHMAIN_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lblID.Text=dgvHMAIN.SelectedRows[0].Cells[0].Value.ToString();
            txtSCRIBLE.Text = dgvHMAIN.SelectedRows[0].Cells[1].Value.ToString();
            txtROMANJI.Text = dgvHMAIN.SelectedRows[0].Cells[2].Value.ToString();
            ResetKEdit();
        }
        private void dgvKMAIN_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lblID.Text = dgvKMAIN.SelectedRows[0].Cells[0].Value.ToString();
            txtSCRIBLE.Text = dgvKMAIN.SelectedRows[0].Cells[1].Value.ToString();
            txtROMANJI.Text = dgvKMAIN.SelectedRows[0].Cells[2].Value.ToString();
            ResetKEdit();
        }

        private void dgvHDAKUTEN_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lblID.Text = dgvHDAKUTEN.SelectedRows[0].Cells[0].Value.ToString();
            txtSCRIBLE.Text = dgvHDAKUTEN.SelectedRows[0].Cells[1].Value.ToString();
            txtROMANJI.Text = dgvHDAKUTEN.SelectedRows[0].Cells[2].Value.ToString();
            ResetKEdit();
        }

        private void dgvKDAKUTEN_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lblID.Text = dgvKDAKUTEN.SelectedRows[0].Cells[0].Value.ToString();
            txtSCRIBLE.Text = dgvKDAKUTEN.SelectedRows[0].Cells[1].Value.ToString();
            txtROMANJI.Text = dgvKDAKUTEN.SelectedRows[0].Cells[2].Value.ToString();
            ResetKEdit();
        }

        private void dgvKCOMBINATIONS_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lblID.Text = dgvKCOMBINATIONS.SelectedRows[0].Cells[0].Value.ToString();
            txtSCRIBLE.Text = dgvKCOMBINATIONS.SelectedRows[0].Cells[1].Value.ToString();
            txtROMANJI.Text = dgvKCOMBINATIONS.SelectedRows[0].Cells[2].Value.ToString();
            ResetKEdit();
        }

        private void dgvHCOMBINATIONS_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lblID.Text = dgvHCOMBINATIONS.SelectedRows[0].Cells[0].Value.ToString();
            txtSCRIBLE.Text = dgvHCOMBINATIONS.SelectedRows[0].Cells[1].Value.ToString();
            txtROMANJI.Text = dgvHCOMBINATIONS.SelectedRows[0].Cells[2].Value.ToString();
            ResetKEdit();
        }
        void ResetKEdit()
        {
            gpbEDIT.Visible = true;
            if (estadoshift == 1)
            {
                btnShift.PerformClick();
            }
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

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void hiraganaMainBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        void keyboardwrite(string letra)
        {
            if (NONEDIT != 0)
            {
                txtROMANJI.AppendText(letra);
                if(estadoshift==1)
                btnShift.PerformClick();
            }
            else
                MessageBox.Show("Não podes editar a base de dados dos Hiraganas ou Katakanas.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
