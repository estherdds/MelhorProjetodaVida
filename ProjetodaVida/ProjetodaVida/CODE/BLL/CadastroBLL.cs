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
    class CadastroBLL
    {
        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "tbl_usuario";

        public void Inserir(CadastroDTO cadastroDTO)
        {
            string inserir = $"insert into {tabela} values(null,'{cadastroDTO.Nome}','{cadastroDTO.Telefone}','{cadastroDTO.Email}','{cadastroDTO.Senha}')";
            conexao.ExecutarComando(inserir);
        }

        public DataTable Listar()
        {
            string sql = $"select * from {tabela} order by id;";
            return conexao.ExecutarConsulta(sql);
        }

        public void Editar(CadastroDTO cadastroDTO)
        {
            string alterar = $"update {tabela} set nome = '{cadastroDTO.Telefone}', '{cadastroDTO.Email}', '{cadastroDTO.Senha}' where Nome = '{cadastroDTO.Nome}';";
            conexao.ExecutarComando(alterar);
        }


        public void Excluir(CadastroDTO cadastroDTO)
        {
            string excluir = $"delete from {tabela} where Nome = '{cadastroDTO.Nome}';";
            conexao.ExecutarComando(excluir);
        }
    }
}