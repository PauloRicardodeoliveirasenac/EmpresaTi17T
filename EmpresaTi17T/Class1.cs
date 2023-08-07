using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EmpresaTi17T
{
    internal class Class1
    {

        class DAO
        {
            public MySqlConnection conexao;

            public DAO()
            {

                conexao = new MySqlConnection("server=localhost;Database=EmpresaTi17T;Uid=root;password=");
                try
                {
                    conexao.Open();//abrir a conexão com o banco de dados


                }
                catch (Exception erro)

                {
                    MessageBox.Show("algo deu errado!\n\n" + erro.Message);

                }

                //Metodo de inserção
                public string inserir(long CPF, string nome, string telefone, string cidade, string uf, string nomeTabela)
                {
                    string inserir = $ "insert into {nomeTabela}(CPF, nome, telefone, cidade, uf) values('{CPF}','{nome}''{telefone}''{cidade}''{uf}' '");
                MySqlCommand sql = new MySqlCommand(inseir, conexao);
                string resultado = sql.ExecuteNonQuery() + "Executado!";
                return resultado;
          }
