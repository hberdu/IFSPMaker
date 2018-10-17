using IFSPMaker.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IFSPMaker.Apresentacao
{
    public partial class CadastreSe : Form
    {
     

        public CadastreSe()
        {
            InitializeComponent();
        }

     
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            /* Controle controle = new Controle();
            controle.verificar(txtUsuario.Text);

            if (controle.mensagem.Equals(""))
            {
                 if (controle.tem)
                {
                    MessageBox.Show("USUARIO EXISTENTE");
                }
                else
                {
                    MessageBox.Show("ERRO");
                }
            }*/

            Controle controle2 = new Controle();
            String mensagem = controle2.cadastrar(txtUsuario.Text, txtSenha.Text, txtConfsenha.Text);

            if (controle2.tem)// mensagem de sucesso
            {
                string guid = System.Guid.NewGuid().ToString();

                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Email em = new Email();
                em.NewHeadlessEmail("henriqueberdu@gmail.com", "@Hberdu123", txtEmail.Text,"Seja bem vindo, Autentique - se no Software utilizando o código abaixo no corpo do e-mail", guid );

            }
            else
            {
                MessageBox.Show(controle2.mensagem); // mensagem de erro
            }


        }
            private void button1_Click(object sender, EventArgs e)
            {
                this.Close();
            }

    }
}


