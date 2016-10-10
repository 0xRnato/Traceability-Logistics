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
    public partial class Leitura : Form
    {
        StreamWriter swFile;
        string tipo;

        public Leitura()
        {
            InitializeComponent();
            tipo = "";
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja mesmo sair?", "Atenção!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.OK)
                Application.Exit();
        }

        private void txt_Cod1_TextChanged(object sender, EventArgs e)
        {
            if (txt_Cod1.Text.Length == 32)
            {
                txt_Cod2.Focus();
                txt_Cod1.Enabled = false;
            }
        }

        private void txt_Cod2_TextChanged(object sender, EventArgs e)
        {
            if (txt_Cod2.Text.Length == 15)
            {
                txt_Cod3.Focus();
                txt_Cod2.Enabled = false;
            }
        }

        private void txt_Cod3_TextChanged(object sender, EventArgs e)
        {
            if (txt_Cod3.Text.Length == 19)
            {
                btn_Next.Enabled = true;
                txt_Cod3.Enabled = false;
            }
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_Cod1.Text = "";
            txt_Cod2.Text = "";
            txt_Cod3.Text = "";
            txt_Cod1.Enabled = true;
            txt_Cod2.Enabled = true;
            txt_Cod3.Enabled = true;
            btn_Next.Enabled = false;
            txt_Cod1.Focus();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Cod1.Text.Length != 32)
                {
                    txt_Cod1.Text = "";
                    txt_Cod1.Enabled = true;
                    txt_Cod1.Focus();
                    throw new Exception("O código 1 está incorreto.");
                }
                if (txt_Cod2.Text.Length != 15)
                {
                    txt_Cod2.Text = "";
                    txt_Cod2.Enabled = true;
                    txt_Cod2.Focus();
                    throw new Exception("O código 2 está incorreto.");
                }
                if (txt_Cod3.Text.Length != 19)
                {
                    txt_Cod3.Text = "";
                    txt_Cod3.Enabled = true;
                    txt_Cod3.Focus();
                    throw new Exception("O código 3 está incorreto.");
                }

                if (txt_Cod1.Text.StartsWith("01"))
                    tipo = "caixa";
                else if (txt_Cod1.Text.StartsWith("02"))
                    tipo = "palete";
                else
                    throw new Exception("Tipo de item não identificado.");

                swFile = new StreamWriter(new FileStream(Global.pathCarregamento, FileMode.Append), Encoding.UTF8);
                swFile.WriteLine(txt_Cod1.Text + ";" + txt_Cod2.Text + ";" + txt_Cod3.Text + ";" + tipo);
                swFile.Close();

                MessageBox.Show("Item lido com sucesso.", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                txt_Cod1.Text = "";
                txt_Cod2.Text = "";
                txt_Cod3.Text = "";
                txt_Cod1.Enabled = true;
                txt_Cod2.Enabled = true;
                txt_Cod3.Enabled = true;
                btn_Limpar.Enabled = false;
                txt_Cod1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza de que quer avançar?", "Atenção!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.OK)
            {
                Finalizar form = new Finalizar();
                form.statusBar1.Text = statusBar1.Text;
                form.ShowDialog();
            }
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            Sobre form = new Sobre();
            form.ShowDialog();
        }
    }
}