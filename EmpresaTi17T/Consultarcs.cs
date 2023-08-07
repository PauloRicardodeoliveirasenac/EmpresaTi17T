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
    public partial class Consultarcs : Form
    {
        public Consultarcs()
        {
            InitializeComponent();
            NomeColunas();
            ConfiguraDategrid();
        }

        public void NomeColunas()
        {
            dataGridView1.Columns[0].Name = "CPF";
            dataGridView1.Columns[1].Name = "nome";
            dataGridView1.Columns[3].Name = "telefone";
            dataGridView1.Columns[3].Name = "cidade";
            dataGridView1.Columns[4].Name = "uf";


        }//fim do metodo

        public void ConfiguraDategrid()
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.ColumnCount = 5;

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




    }
}
