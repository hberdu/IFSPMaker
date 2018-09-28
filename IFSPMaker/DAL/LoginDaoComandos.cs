using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace IFSPMaker.DAL
{
   /* class HashCode
    {
        public string PassHash(string data)
        {
            SHA1 sha = SHA1.Create();
            byte[] hashdata = sha.ComputeHash(Encoding.Default.GetBytes(data));
            StringBuilder returnValue = new StringBuilder();
            for (int i = 0; i < hashdata.Length; i++)
            {
                returnValue.Append(hashdata[i].ToString());
            }
            return returnValue.ToString();
        }

    } */

    class LoginDaoComandos
    {
        public bool tem;
        public string mensagem =  "";


        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;

        public bool verificarLogin(String login, String senha)
        {

            // procura no banco o login e senha
            cmd.CommandText = "select * from logins where email =@login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
          
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
               con.desconectar();
               dr.Close();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com Banco de Dados!";
                throw;
            }

            return tem;
        }



        public string cadastrar(String email, String senha,  String confsenha)
        {
 
            tem = false;
            if(senha.Equals(confsenha))
            {
                cmd.CommandText = "insert into logins values (@e,@s);";
                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@s", senha);

                try
                {
                    cmd.Connection = con.conectar();
                    cmd.ExecuteNonQuery();
                    con.desconectar();
                    this.mensagem = "Cadastrado com sucesso!";
                    tem = true;
                }
                catch (SqlException)
                {
                    this.mensagem = "Erro com Banco de Dados x";
                    
                }
            }else
            {
                this.mensagem = "Senhas não correspondem";
            }
            return mensagem;
        }
    }
}
