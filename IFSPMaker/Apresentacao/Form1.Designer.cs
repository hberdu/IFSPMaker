namespace IFSPMaker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.Windows.Forms.Button btnEntrar;
            System.Windows.Forms.Button btnSair;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pnlRodape = new System.Windows.Forms.Panel();
            this.btnCadastre = new System.Windows.Forms.Button();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblMaker = new System.Windows.Forms.Label();
            this.lblifsp = new System.Windows.Forms.Label();
            btnEntrar = new System.Windows.Forms.Button();
            btnSair = new System.Windows.Forms.Button();
            this.pnlRodape.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = System.Drawing.Color.PaleGreen;
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEntrar.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnEntrar.ForeColor = System.Drawing.Color.Black;
            btnEntrar.Location = new System.Drawing.Point(143, 170);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new System.Drawing.Size(69, 30);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(143, 100);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(194, 22);
            this.txtUsuario.TabIndex = 5;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // btnSair
            // 
            btnSair.BackColor = System.Drawing.Color.Firebrick;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSair.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnSair.ForeColor = System.Drawing.Color.Black;
            btnSair.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            btnSair.Location = new System.Drawing.Point(363, 7);
            btnSair.Name = "btnSair";
            btnSair.Size = new System.Drawing.Size(56, 29);
            btnSair.TabIndex = 1;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.Ivory;
            this.lblSenha.Location = new System.Drawing.Point(79, 124);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(49, 24);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha";
            this.lblSenha.Click += new System.EventHandler(this.lblSenha_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(143, 126);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(194, 22);
            this.txtSenha.TabIndex = 6;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.Ivory;
            this.lblUsuario.Location = new System.Drawing.Point(67, 98);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(61, 24);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuário";
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // pnlRodape
            // 
            this.pnlRodape.BackColor = System.Drawing.Color.White;
            this.pnlRodape.Controls.Add(this.lblifsp);
            this.pnlRodape.Controls.Add(btnSair);
            this.pnlRodape.Location = new System.Drawing.Point(3, 268);
            this.pnlRodape.Name = "pnlRodape";
            this.pnlRodape.Size = new System.Drawing.Size(478, 44);
            this.pnlRodape.TabIndex = 15;
            this.pnlRodape.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnCadastre
            // 
            this.btnCadastre.BackColor = System.Drawing.Color.White;
            this.btnCadastre.FlatAppearance.BorderSize = 0;
            this.btnCadastre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastre.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastre.ForeColor = System.Drawing.Color.Black;
            this.btnCadastre.Location = new System.Drawing.Point(235, 172);
            this.btnCadastre.Name = "btnCadastre";
            this.btnCadastre.Size = new System.Drawing.Size(102, 28);
            this.btnCadastre.TabIndex = 7;
            this.btnCadastre.Text = "Cadastre-se";
            this.btnCadastre.UseVisualStyleBackColor = false;
            this.btnCadastre.Click += new System.EventHandler(this.button3_Click);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.White;
            this.pnlTitulo.Controls.Add(this.lblMaker);
            this.pnlTitulo.Location = new System.Drawing.Point(-2, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(439, 64);
            this.pnlTitulo.TabIndex = 13;
            // 
            // lblMaker
            // 
            this.lblMaker.AutoSize = true;
            this.lblMaker.BackColor = System.Drawing.Color.White;
            this.lblMaker.Font = new System.Drawing.Font("Bebas Neue", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaker.ForeColor = System.Drawing.Color.Black;
            this.lblMaker.Location = new System.Drawing.Point(121, 9);
            this.lblMaker.Name = "lblMaker";
            this.lblMaker.Size = new System.Drawing.Size(218, 56);
            this.lblMaker.TabIndex = 1;
            this.lblMaker.Text = "Maker Space";
            // 
            // lblifsp
            // 
            this.lblifsp.AutoSize = true;
            this.lblifsp.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblifsp.Location = new System.Drawing.Point(13, 14);
            this.lblifsp.Name = "lblifsp";
            this.lblifsp.Size = new System.Drawing.Size(321, 17);
            this.lblifsp.TabIndex = 2;
            this.lblifsp.Text = "Instituto Federal de São Paulo - Campus Capivari ";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(434, 314);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.btnCadastre);
            this.Controls.Add(this.pnlRodape);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(btnEntrar);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Maker Space";
            this.pnlRodape.ResumeLayout(false);
            this.pnlRodape.PerformLayout();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Panel pnlRodape;
        private System.Windows.Forms.Button btnCadastre;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblMaker;
        private System.Windows.Forms.Label lblifsp;
    }
}

