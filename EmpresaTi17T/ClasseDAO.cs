using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaTi17T
{
    internal class DAO
    {

        public MySqlConnection conexao;
        public long[] CPF;
        public string[] nome;
        public string[] telefone;
        public string[] cidade;
        public string[] uf;



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

             
        }//fim da classe

        public string inserir(long CPF, string nome, string telefone, string cidade, string uf, string nomeTabela)
        {
            string inserir = $"insert into {nomeTabela}(CPF, nome, telefone, cidade, uf) values('{CPF}','{nome}','{telefone}','{cidade}','{uf}')";
            MySqlCommand sql = new MySqlCommand(inserir, conexao);
            string resultado = sql.ExecuteNonQuery() + "Executado!";
            return resultado;
        }//fim do metodo

        public void preenchervetor()
        {
            string query = " select * from pessoa"

                //instanciar
                this.CPF=
                this.nome =
                this.telefone =
                this.cidade =
                this.uf =

        }


        public string atualizarnome(long CPF, string nometabela,string campo, string dado,string nome)
        {
            string query = $"update pessoa {nometabela} set {campo} = '{dado}' where CPF = '{CPF}'";
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + "atualizado!";
            return resultado;
        }//fim do metodo

        public string Excluir(long CPF)
        {
            string query = $"delete from {nomeTabela} where CPF = '{CPF}'";
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + "excluido!";
            return resultado;
        }

    }//fim da classe
} //fim do projeto









