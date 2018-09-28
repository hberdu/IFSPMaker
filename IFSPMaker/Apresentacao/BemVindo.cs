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
    public partial class Bem_vindo : Form
    {
        public Bem_vindo()
        {
            InitializeComponent();
        }

        private void Bem_vindo_Load(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnEquipamentos_Click(object sender, EventArgs e)
        {
            Equipamentos equip = new Equipamentos();
            equip.Show();
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            ReservaSala reserva = new ReservaSala();
            reserva.Show();

        }

        private void btnCertificado_Click(object sender, EventArgs e)
        {
            Certificado cert = new Certificado();
            cert.Show();

        }

        private void btnEmprestimo_Click(object sender, EventArgs e)
        {
            Emprestimo emp = new Emprestimo();
            emp.Show();

        }

        private void btnAcesso_Click(object sender, EventArgs e)
        {
            Usuarios user = new Usuarios();
            user.Show();

        }
    }
}
