namespace IFSPMaker.Apresentacao
{
    partial class Bem_vindo
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
            System.Windows.Forms.Button btnSair;
            System.Windows.Forms.Button btnLogout;
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.btnReserva = new System.Windows.Forms.Button();
            this.btnCertificado = new System.Windows.Forms.Button();
            this.btnEmprestimo = new System.Windows.Forms.Button();
            this.BtnEquipamentos = new System.Windows.Forms.Button();
            this.btnAcesso = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            btnSair = new System.Windows.Forms.Button();
            btnLogout = new System.Windows.Forms.Button();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            btnSair.BackColor = System.Drawing.Color.Firebrick;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSair.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnSair.ForeColor = System.Drawing.Color.Black;
            btnSair.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            btnSair.Location = new System.Drawing.Point(89, 383);
            btnSair.Name = "btnSair";
            btnSair.Size = new System.Drawing.Size(56, 29);
            btnSair.TabIndex = 6;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLogout
            // 
            btnLogout.BackColor = System.Drawing.Color.FloralWhite;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogout.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnLogout.ForeColor = System.Drawing.Color.Black;
            btnLogout.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            btnLogout.Location = new System.Drawing.Point(12, 383);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(71, 29);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.White;
            this.lblWelcome.Font = new System.Drawing.Font("Bebas Neue", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Black;
            this.lblWelcome.Location = new System.Drawing.Point(255, 12);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(375, 52);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome to Maker Space";
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.White;
            this.pnlTitulo.Controls.Add(this.lblWelcome);
            this.pnlTitulo.Location = new System.Drawing.Point(-2, -3);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(918, 67);
            this.pnlTitulo.TabIndex = 3;
            // 
            // btnReserva
            // 
            this.btnReserva.BackColor = System.Drawing.Color.MintCream;
            this.btnReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserva.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserva.Location = new System.Drawing.Point(12, 207);
            this.btnReserva.Name = "btnReserva";
            this.btnReserva.Size = new System.Drawing.Size(223, 36);
            this.btnReserva.TabIndex = 2;
            this.btnReserva.Text = "Gerenciar Reserva de Sala";
            this.btnReserva.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnReserva.UseVisualStyleBackColor = false;
            this.btnReserva.Click += new System.EventHandler(this.btnReserva_Click);
            // 
            // btnCertificado
            // 
            this.btnCertificado.BackColor = System.Drawing.Color.MintCream;
            this.btnCertificado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCertificado.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCertificado.Location = new System.Drawing.Point(12, 260);
            this.btnCertificado.Name = "btnCertificado";
            this.btnCertificado.Size = new System.Drawing.Size(223, 36);
            this.btnCertificado.TabIndex = 3;
            this.btnCertificado.Text = "Gerenciar Certificados";
            this.btnCertificado.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCertificado.UseVisualStyleBackColor = false;
            this.btnCertificado.Click += new System.EventHandler(this.btnCertificado_Click);
            // 
            // btnEmprestimo
            // 
            this.btnEmprestimo.BackColor = System.Drawing.Color.MintCream;
            this.btnEmprestimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmprestimo.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmprestimo.Location = new System.Drawing.Point(12, 152);
            this.btnEmprestimo.Name = "btnEmprestimo";
            this.btnEmprestimo.Size = new System.Drawing.Size(223, 36);
            this.btnEmprestimo.TabIndex = 4;
            this.btnEmprestimo.Text = "Gerenciar Empréstimos";
            this.btnEmprestimo.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEmprestimo.UseVisualStyleBackColor = false;
            this.btnEmprestimo.Click += new System.EventHandler(this.btnEmprestimo_Click);
            // 
            // BtnEquipamentos
            // 
            this.BtnEquipamentos.BackColor = System.Drawing.Color.MintCream;
            this.BtnEquipamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEquipamentos.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEquipamentos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnEquipamentos.Location = new System.Drawing.Point(12, 99);
            this.BtnEquipamentos.Name = "BtnEquipamentos";
            this.BtnEquipamentos.Size = new System.Drawing.Size(223, 36);
            this.BtnEquipamentos.TabIndex = 1;
            this.BtnEquipamentos.Text = "Gerenciar Equipamentos";
            this.BtnEquipamentos.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnEquipamentos.UseVisualStyleBackColor = false;
            this.BtnEquipamentos.Click += new System.EventHandler(this.BtnEquipamentos_Click);
            // 
            // btnAcesso
            // 
            this.btnAcesso.BackColor = System.Drawing.Color.MintCream;
            this.btnAcesso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcesso.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcesso.Location = new System.Drawing.Point(12, 315);
            this.btnAcesso.Name = "btnAcesso";
            this.btnAcesso.Size = new System.Drawing.Size(223, 36);
            this.btnAcesso.TabIndex = 5;
            this.btnAcesso.Text = "Gerenciar Acesso ao Software";
            this.btnAcesso.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAcesso.UseVisualStyleBackColor = false;
            this.btnAcesso.Click += new System.EventHandler(this.btnAcesso_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(262, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 345);
            this.panel1.TabIndex = 8;
            // 
            // Bem_vindo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(862, 424);
            this.Controls.Add(this.panel1);
            this.Controls.Add(btnLogout);
            this.Controls.Add(btnSair);
            this.Controls.Add(this.btnAcesso);
            this.Controls.Add(this.btnEmprestimo);
            this.Controls.Add(this.btnCertificado);
            this.Controls.Add(this.btnReserva);
            this.Controls.Add(this.BtnEquipamentos);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Bem_vindo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Bem_vindo_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Button btnEmprestimo;
        private System.Windows.Forms.Button btnCertificado;
        private System.Windows.Forms.Button btnReserva;
        private System.Windows.Forms.Button BtnEquipamentos;
        private System.Windows.Forms.Button btnAcesso;
        private System.Windows.Forms.Panel panel1;
    }
}