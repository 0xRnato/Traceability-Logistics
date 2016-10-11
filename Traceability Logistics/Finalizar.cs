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
    public partial class Finalizar : Form
    {
        StreamWriter writer;

        List<string[]> items;
        public Finalizar()
        {
            InitializeComponent();
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja mesmo sair?", "Atenção!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.OK)
                Application.Exit();
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            Sobre form = new Sobre();
            form.ShowDialog();
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja mesmo finalizar o carregamento?", "Atenção!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btn_Remover_Click(object sender, EventArgs e)
        {
            string[] itemToRemove = new string[3];
            if (tab_Main.SelectedIndex == 0)
            {
                foreach (string[] item in items)
                {
                    if (item[0].StartsWith("02") && item[0] == grid_Paletes[grid_Paletes.CurrentRowIndex,0].ToString())
                        itemToRemove = item;
                }
            }
            else if (tab_Main.SelectedIndex == 1)
            {
                foreach (string[] item in items)
                {
                    if (item[0].StartsWith("01") && item[0] == grid_Caixas[grid_Caixas.CurrentRowIndex,0].ToString())
                        itemToRemove = item;
                }
            }

            items.Remove(itemToRemove);

            File.Delete(Global.pathCarregamento);
            File.Create(Global.pathCarregamento).Close();

            foreach (string[] item in items)
            {
                string tipo = "";
                if (item[0].StartsWith("01"))
                    tipo = "caixa";
                else if (item[0].StartsWith("02"))
                    tipo = "palete";

                writer = new StreamWriter(new FileStream(Global.pathCarregamento, FileMode.Append), Encoding.UTF8);

                writer.WriteLine(item[0] + ";" + item[1] + ";" + item[2] + ";" + tipo);
                writer.Close();
            }
            UpdateGrids();
        }

        private void Finalizar_Load(object sender, EventArgs e)
        {
            if (File.Exists(Global.pathCarregamento))
            {
                UpdateGrids();
            }
        }

        private void UpdateGrids()
        {
            try
            {
                items = new List<string[]>();
                string s;
                var source = new BindingSource();
                StreamReader reader = File.OpenText(Global.pathCarregamento);
                DataTable tablePalete = new DataTable();
                DataTable tableCaixa = new DataTable();

                while ((s = reader.ReadLine()) != null)
                {
                    string[] codigos = s.Split(';');
                    items.Add(codigos);
                }
                reader.Close();

                tablePalete.Columns.Add("Código 1");
                tablePalete.Columns.Add("Código 2");
                tablePalete.Columns.Add("Código 3");
                tableCaixa.Columns.Add("Código 1");
                tableCaixa.Columns.Add("Código 2");
                tableCaixa.Columns.Add("Código 3");

                foreach (string[] item in items)
                {
                    if (item[3] == "palete")
                    {
                        DataRow row = tablePalete.NewRow();
                        row[0] = item[0];
                        row[1] = item[1];
                        row[2] = item[2];
                        tablePalete.Rows.Add(row);
                    }
                    else if (item[3] == "caixa")
                    {
                        DataRow row = tableCaixa.NewRow();
                        row[0] = item[0];
                        row[1] = item[1];
                        row[2] = item[2];
                        tableCaixa.Rows.Add(row);
                    }
                    else
                        throw new Exception("Tipo de item não identificado!!");
                }
                tableCaixa.TableName = "Caixas";
                tablePalete.TableName = "Paletes";
                grid_Paletes.DataSource = tablePalete;
                grid_Caixas.DataSource = tableCaixa;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!!!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
        }
    }
}