namespace Traceability_Logistics
{
    partial class Leitura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Cod1 = new System.Windows.Forms.TextBox();
            this.txt_Cod2 = new System.Windows.Forms.TextBox();
            this.txt_Cod3 = new System.Windows.Forms.TextBox();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            this.mainMenu1.MenuItems.Add(this.menuItem3);
            this.mainMenu1.MenuItems.Add(this.menuItem2);
            // 
            // menuItem1
            // 
            this.menuItem1.Text = "Avançar";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Text = "Sobre";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "Sair";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 251);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(238, 24);
            this.statusBar1.Text = "Usuário:  ";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.Text = "CÓDIGO 1:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.Text = "CÓDIGO 3:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.Text = "CÓDIGO 2:";
            // 
            // txt_Cod1
            // 
            this.txt_Cod1.Location = new System.Drawing.Point(82, 55);
            this.txt_Cod1.Name = "txt_Cod1";
            this.txt_Cod1.Size = new System.Drawing.Size(153, 23);
            this.txt_Cod1.TabIndex = 1;
            this.txt_Cod1.TextChanged += new System.EventHandler(this.txt_Cod1_TextChanged);
            // 
            // txt_Cod2
            // 
            this.txt_Cod2.Location = new System.Drawing.Point(82, 84);
            this.txt_Cod2.Name = "txt_Cod2";
            this.txt_Cod2.Size = new System.Drawing.Size(153, 23);
            this.txt_Cod2.TabIndex = 2;
            this.txt_Cod2.TextChanged += new System.EventHandler(this.txt_Cod2_TextChanged);
            // 
            // txt_Cod3
            // 
            this.txt_Cod3.Location = new System.Drawing.Point(82, 113);
            this.txt_Cod3.Name = "txt_Cod3";
            this.txt_Cod3.Size = new System.Drawing.Size(153, 23);
            this.txt_Cod3.TabIndex = 3;
            this.txt_Cod3.TextChanged += new System.EventHandler(this.txt_Cod3_TextChanged);
            // 
            // btn_Next
            // 
            this.btn_Next.Enabled = false;
            this.btn_Next.Location = new System.Drawing.Point(123, 191);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(94, 29);
            this.btn_Next.TabIndex = 4;
            this.btn_Next.Text = "Próximo";
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Location = new System.Drawing.Point(23, 191);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(94, 29);
            this.btn_Limpar.TabIndex = 6;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // Leitura
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.txt_Cod3);
            this.Controls.Add(this.txt_Cod2);
            this.Controls.Add(this.txt_Cod1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusBar1);
            this.MaximizeBox = false;
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "Leitura";
            this.Text = "Leitura";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Cod1;
        private System.Windows.Forms.TextBox txt_Cod2;
        private System.Windows.Forms.TextBox txt_Cod3;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.MenuItem menuItem3;

    }
}