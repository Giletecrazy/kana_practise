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
    public partial class Resultado : Form
    {
        public Resultado()
        {
            InitializeComponent();
        }

        private void Resultado_Load(object sender, EventArgs e)
        {
            int erradosxcount=0;
            int i = 0;
            while (i <passagem.tamanhotabela)
            {
                //this.dgvResultados.Rows.Insert(i,passagem.symbol[i], passagem.erradas[i]);
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvResultados);
                row.Cells[0].Value = passagem.symbol[i];
                row.Cells[1].Value = passagem.erradas[i];
                row.Height = 30;
                dgvResultados.Rows.Add(row);
                if (Convert.ToInt16(passagem.erradas[i]) != 0)
                    erradosxcount++;
                i++;
            }
            lblCertos.Text = (passagem.tamanhotabela - erradosxcount).ToString() + "/" + passagem.tamanhotabela.ToString();
        }

        private void Resultado_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
