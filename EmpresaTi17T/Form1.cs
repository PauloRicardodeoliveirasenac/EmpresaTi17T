using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaTi17T
{
    public partial class Form1 : Form
    {
        Cadastrar cad;
        Consultarcs con;
        Atualizar atu;
        Excluir exc;
  



        public Form1()
        {
            InitializeComponent();
            cad = new Cadastrar();
            con = new Consultarcs();
            atu = new Atualizar();
            exc = new Excluir();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }//FIM DO ATUALIZAR

        private void button1_Click(object sender, EventArgs e)
        {
          

        }//FIM DO CADASTRAR

        private void button3_Click(object sender, EventArgs e)
        {

        }//FIM DO EXCLUIR

        private void button4_Click(object sender, EventArgs e)
        {

        }//FIM DO CONSULTAR

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
