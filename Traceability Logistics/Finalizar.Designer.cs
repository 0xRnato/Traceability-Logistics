namespace Traceability_Logistics
{
    partial class Finalizar
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
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.tab_Main = new System.Windows.Forms.TabControl();
            this.page_Paletes = new System.Windows.Forms.TabPage();
            this.page_Caixas = new System.Windows.Forms.TabPage();
            this.btn_Remover = new System.Windows.Forms.Button();
            this.grid_Paletes = new System.Windows.Forms.DataGrid();
            this.grid_Caixas = new System.Windows.Forms.DataGrid();
            this.tab_Main.SuspendLayout();
            this.page_Paletes.SuspendLayout();
            this.page_Caixas.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            this.mainMenu1.MenuItems.Add(this.menuItem4);
            this.mainMenu1.MenuItems.Add(this.menuItem2);
            this.mainMenu1.MenuItems.Add(this.menuItem3);
            // 
            // menuItem1
            // 
            this.menuItem1.Text = "Finalizar";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "Sobre";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Text = "Voltar";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Text = "Sair";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 251);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(238, 24);
            this.statusBar1.Text = "Usuário:  ";
            // 
            // tab_Main
            // 
            this.tab_Main.Controls.Add(this.page_Paletes);
            this.tab_Main.Controls.Add(this.page_Caixas);
            this.tab_Main.Location = new System.Drawing.Point(0, 27);
            this.tab_Main.Name = "tab_Main";
            this.tab_Main.SelectedIndex = 0;
            this.tab_Main.Size = new System.Drawing.Size(238, 192);
            this.tab_Main.TabIndex = 1;
            // 
            // page_Paletes
            // 
            this.page_Paletes.Controls.Add(this.grid_Paletes);
            this.page_Paletes.Location = new System.Drawing.Point(4, 25);
            this.page_Paletes.Name = "page_Paletes";
            this.page_Paletes.Size = new System.Drawing.Size(230, 163);
            this.page_Paletes.Text = "Paletes";
            // 
            // page_Caixas
            // 
            this.page_Caixas.Controls.Add(this.grid_Caixas);
            this.page_Caixas.Location = new System.Drawing.Point(4, 25);
            this.page_Caixas.Name = "page_Caixas";
            this.page_Caixas.Size = new System.Drawing.Size(230, 163);
            this.page_Caixas.Text = "Caixas";
            // 
            // btn_Remover
            // 
            this.btn_Remover.Location = new System.Drawing.Point(162, 225);
            this.btn_Remover.Name = "btn_Remover";
            this.btn_Remover.Size = new System.Drawing.Size(72, 20);
            this.btn_Remover.TabIndex = 2;
            this.btn_Remover.Text = "Remover";
            this.btn_Remover.Click += new System.EventHandler(this.btn_Remover_Click);
            // 
            // grid_Paletes
            // 
            this.grid_Paletes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.grid_Paletes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_Paletes.Location = new System.Drawing.Point(0, 0);
            this.grid_Paletes.Name = "grid_Paletes";
            this.grid_Paletes.Size = new System.Drawing.Size(230, 163);
            this.grid_Paletes.TabIndex = 0;
            // 
            // grid_Caixas
            // 
            this.grid_Caixas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.grid_Caixas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_Caixas.Location = new System.Drawing.Point(0, 0);
            this.grid_Caixas.Name = "grid_Caixas";
            this.grid_Caixas.Size = new System.Drawing.Size(230, 163);
            this.grid_Caixas.TabIndex = 1;
            // 
            // Finalizar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Remover);
            this.Controls.Add(this.tab_Main);
            this.Controls.Add(this.statusBar1);
            this.MaximizeBox = false;
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "Finalizar";
            this.Text = "Finalizar";
            this.Load += new System.EventHandler(this.Finalizar_Load);
            this.tab_Main.ResumeLayout(false);
            this.page_Paletes.ResumeLayout(false);
            this.page_Caixas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.TabControl tab_Main;
        private System.Windows.Forms.TabPage page_Paletes;
        private System.Windows.Forms.TabPage page_Caixas;
        private System.Windows.Forms.Button btn_Remover;
        private System.Windows.Forms.DataGrid grid_Paletes;
        private System.Windows.Forms.DataGrid grid_Caixas;

    }
}