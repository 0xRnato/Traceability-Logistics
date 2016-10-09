using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Traceability_Logistics
{
    public partial class Finalizar : Form
    {
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
                Application.Exit();
        }
    }
}