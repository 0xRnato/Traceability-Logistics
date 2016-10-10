using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Traceability_Logistics
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja mesmo sair?", "Atenção!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2); ;
            if (result == DialogResult.OK)
                Application.Exit();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            Sobre form = new Sobre();
            form.ShowDialog();
        }

        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            if (File.Exists(Global.pathCarregamento))
            {
                DialogResult result = MessageBox.Show("Quer deletar todos dados salvos e iniciar um novo carregamento?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    File.Delete(Global.pathCarregamento);
                    File.Create(Global.pathCarregamento).Close();
                    Leitura form = new Leitura();
                    form.statusBar1.Text = statusBar1.Text;
                    this.Close();
                    form.Show();
                }
            }
            else
            {
                File.Create(Global.pathCarregamento).Close();
                Leitura form = new Leitura();
                form.statusBar1.Text = statusBar1.Text;
                this.Close();
                form.Show();
            }
        }

        private void btn_Continuar_Click(object sender, EventArgs e)
        {
            if (File.Exists(Global.pathCarregamento))
            {
                Leitura form = new Leitura();
                form.statusBar1.Text = statusBar1.Text;
                this.Close();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Não há nenhum carregamento em andamento neste aparelho, inicie um novo carregamento.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
        }
    }
}