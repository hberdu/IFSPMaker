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

        public bool acessar(String login, String senha)
        {
            LoginDaoComandos LoginDao = new LoginDaoComandos();
            tem = LoginDao.verificarLogin(login, senha);
           if ( ! LoginDao.mensagem.Equals(""))
            {
                this.mensagem = LoginDao.mensagem;
            }
            return tem;
        }

        public string cadastrar(String email, String senha, String confsenha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem = loginDao.cadastrar(email, senha, confsenha);
            if(loginDao.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}
