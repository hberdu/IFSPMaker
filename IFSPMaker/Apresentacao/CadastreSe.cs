using IFSPMaker.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            Controle controle = new Controle();
            String mensagem = controle.cadastrar(txtUsuario.Text, txtSenha.Text, txtConfsenha.Text);
            if(controle.tem)// mensagem de sucesso
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }else
            {
                MessageBox.Show(controle.mensagem);// mensagem de erro
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
