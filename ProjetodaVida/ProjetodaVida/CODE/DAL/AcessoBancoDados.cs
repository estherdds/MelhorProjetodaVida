using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace ProjetodaVida.CODE.DAL
{
    class AcessoBancoDados
    {
        MySqlConnection conexao;

        public void Conectar()
        {
            try
            {
                string conn = "Persist Security Info = false; " +
                              "server = localhost; " +
                              "database = Esther_Serpa; " +
                              "uid = root; pwd=root";

                conexao = new MySqlConnection(conn);
                conexao.Open();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Não foi possível conectar ao banco de dados.\n" + ex.Message);
            }
        }

        public DataTable ExecutarConsulta(string sql)
        {
            try
            {
                Conectar();
                MySqlDataAdapter dados = new MySqlDataAdapter(sql, conexao);
                DataTable dt = new DataTable();
                dados.Fill(dt);

                return dt;
            }
            catch (MySqlException ex)
            {
                throw new Exception("Não foi possível executar a CONSULTA solicitada.\n" + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public void ExecutarComando(string sql)
        {
            Conectar();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw new Exception("A instrução não foi realizada.\n" + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}