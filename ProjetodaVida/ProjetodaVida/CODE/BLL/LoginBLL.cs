using ProjetodaVida.CODE.DAL;
using ProjetodaVida.CODE.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetodaVida.CODE.BLL
{
    class LoginBLL
    {
        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "tbl_Login";

        public bool RealizarLogin(LoginDTO login)
        {
            string sql = $"select * from {tabela} where email='{login.Email}' and senha='{login.Senha}'";
            DataTable dt = conexao.ExecutarConsulta(sql);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public string RetornarSenha(LoginDTO login)
        {
            string sql = $"select * from {tabela} where email='{login.Email}'";
            DataTable dt = conexao.ExecutarConsulta(sql);

            if (dt.Rows.Count > 0)
                return dt.Rows[0]["senha"].ToString();
            else
                return "false";
        }

    }
}