using IFSPMaker.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPMaker.Modelo
{
    public class Controle
    {
        public bool tem;
        public string mensagem = "";

        public bool acessar(String usuario, String senha)
        {
            LoginDaoComandos LoginDao = new LoginDaoComandos();
            tem = LoginDao.AutenticarLogin(usuario, senha);
            if (!LoginDao.mensagem.Equals(""))
            {
                this.mensagem = LoginDao.mensagem;
            }
            return tem;
        }

        public bool verificar(String usuario)
        {
            LoginDaoComandos LoginDao = new LoginDaoComandos();
            tem = LoginDao.VerificarDupes(usuario);
            if (!LoginDao.mensagem.Equals(""))
            {
                this.mensagem = LoginDao.mensagem;
            }
            return tem;
        }
    

    public string cadastrar(String usuario, String senha, String confsenha)
    {
        LoginDaoComandos loginDao = new LoginDaoComandos();
        this.mensagem = loginDao.cadastrar(usuario, senha, confsenha);
        if (loginDao.tem)
        {
            this.tem = true;
        }
        return mensagem;
    }

    }
}

