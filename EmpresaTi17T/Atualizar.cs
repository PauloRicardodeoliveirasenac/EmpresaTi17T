using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaTi17T
{
    public partial class Atualizar : Form
    {
        public Atualizar()
        {
            InitializeComponent();
            atu = new DAO();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            atu.atualizar(Convert.ToUInt64(CPF.Text), "pessoa", "nome", nome.Text);//atualizar nome
            atu.atualizar(Convert.ToUInt64(CPF.Text), "pessoa", "telefone", telefone.Text);//atualizar nome
            atu.atualizar(Convert.ToUInt64(CPF.Text), "pessoa", "cidade", cidade.Text);//atualizar nome
            atu.atualizar(Convert.ToUInt64(CPF.Text), "pessoa", "uf", uf.Text);//atualizar nome
            MessageBox.Show("dados atualizados com Sucesso");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }//fim da classe
}//fim do projeto
