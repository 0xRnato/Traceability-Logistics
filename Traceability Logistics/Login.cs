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
    public partial class Login : Form
    {
        string path, pathUser, usuario, senha;

        public Login()
        {
            InitializeComponent();
            path = (System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + @"\..";
            pathUser = path + @"\user.file";
            Global.pathCarregamento = path + @"\carregamento.file";
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja mesmo sair?", "Atenção!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.OK)
                Application.Exit();
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Usuario.Text == "")
                    throw new Exception("Digite o usuário.");
                if (txt_Senha.Text == "")
                    throw new Exception("Digite a senha.");
                if (txt_Usuario.Text != usuario)
                    throw new Exception("Usuário incorreto.");
                if (txt_Senha.Text != senha)
                    throw new Exception("Senha incorreta.");

                Home form = new Home();
                form.statusBar1.Text += usuario;
                Hide();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (File.Exists(pathUser))
            {
                int i = 0;
                string s;
                StreamReader reader = File.OpenText(pathUser);
                while ((s = reader.ReadLine()) != null)
                {
                    if (i == 0)
                        usuario = s;
                    else
                        senha = s;
                    i++;
                }
            }
            else
            {
                MessageBox.Show("Não existe nenhuma senha cadastrada nete aparelho, contate o administrador do sistema para sincronizar a sua senha.", "Erro!!!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                Application.Exit();

                //btn_Entrar.Enabled = false;
                //txt_Usuario.Enabled = false;
                //txt_Senha.Enabled = false;

                //File.Create(pathUser).Close();
                //StreamWriter swFile = new StreamWriter(new FileStream(pathUser, FileMode.Append), Encoding.UTF8);
                //swFile.WriteLine("rnato");
                //swFile.Write("121473");
                //swFile.Close();
            }
        }
    }
    class Global
    {
        public static string pathCarregamento;
    }
}