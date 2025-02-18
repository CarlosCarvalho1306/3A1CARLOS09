﻿using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARLOSEDUARDO3A1_09.Codigo.DAL
{
    class BancoDAL
    {

        MySqlConnection conexao;

        public void Conectar()
        {
            try
            {
                string conn = "Persist Security Info = false; " +
                              "server = localhost; " +
                              "database = BancoCadu; " +
                              "uid = root; pwd=;convert zero datetime=True";

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
