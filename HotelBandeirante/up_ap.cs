using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HotelBandeirante
{
    public partial class up_ap : Form
    {
        private MySqlConnection mConn2;
        private MySqlDataAdapter mAdapter2;
        private DataSet mDataSet2;

        private int linha_atual;
        private string id;
        private string detalhe;
        private string valor;

        void atualiza_quartos()
        {
            mDataSet2 = new DataSet();

            //define string de conexao e cria a conexao
            mConn2 = new MySqlConnection("Persist Security Info=False;server=localhost;database=hotelban_central;uid=hotelban_fabarl;server=localhost;database=hotelban_central;uid=hotelban_fabarl;pwd=281200");

            try
            {
                //abre a conexao
                mConn2.Open();
            }
            catch (System.Exception)
            {
                MessageBox.Show("Houve um Erro Ao Tentar Receber a Lista de Quartose", "[ ERRO QUARTOS ]", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

            //verificva se a conexão esta aberta
            if (mConn2.State == ConnectionState.Open)
            {
                //cria um adapter usando a instrução SQL para acessar a tabela Clientes
                mAdapter2 = new MySqlDataAdapter("SELECT * FROM apartamento", mConn2);
                //preenche o dataset via adapter
                mAdapter2.Fill(mDataSet2, "abrirquarto");
                //atribui a resultado a propriedade DataSource do DataGrid
                dataGridView1.DataSource = mDataSet2;
                dataGridView1.DataMember = "abrirquarto";
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.Columns.Clear();

                dataGridView1.Columns.Add("quarto", "Apartamento");
                dataGridView1.Columns.Add("descricao", "Descricao");
                dataGridView1.Columns.Add("valordiaria", "Valor Diaria");
                dataGridView1.Columns[0].DataPropertyName = "quarto";
                dataGridView1.Columns[1].DataPropertyName = "descricao";
                dataGridView1.Columns[2].DataPropertyName = "valordiaria";

                dataGridView1.Columns[0].Width = 70;
                dataGridView1.Columns[1].Width = 150;
                dataGridView1.Columns[2].Width = 75;


                this.dataGridView1.DefaultCellStyle.ForeColor = Color.MidnightBlue;
                this.dataGridView1.DefaultCellStyle.BackColor = Color.LightBlue;
                this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 10);
                // this.dataGridView2.DefaultCellStyle.ForeColor = Color.Blue;
                // this.dataGridView2.DefaultCellStyle.BackColor = Color.Beige;
                // this.dataGridView2.DefaultCellStyle.SelectionForeColor = Color.Yellow;
                // this.dataGridView2.DefaultCellStyle.SelectionBackColor = Color.Black;

            }
        }


        public up_ap()
        {
            InitializeComponent();
            atualiza_quartos();
        }

        private void up_ap_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            linha_atual = int.Parse(e.RowIndex.ToString());
           id = dataGridView1[0, linha_atual].Value.ToString();
           detalhe = dataGridView1[1, linha_atual].Value.ToString(); 
           valor = dataGridView1[2, linha_atual].Value.ToString();
           tb_ap.Text = id;
           tb_de.Text = detalhe;
           tb_va.Text = valor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "UPDATE apartamento SET descricao = '" + tb_de.Text + "', valordiaria = '" + tb_va.Text + "' WHERE quarto='" + tb_ap.Text + "'";
            MySqlConnection con = new MySqlConnection("Persist Security Info=False;server=localhost;database=hotelban_central;uid=hotelban_fabarl;server=localhost;database=hotelban_central;uid=hotelban_fabarl;pwd=281200");
            MySqlCommand command = new MySqlCommand(query, con);
            con.Open();
            
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Apartamento Atualizado com Sucesso!", "Sucesso");
            atualiza_quartos();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string queryy = "INSERT INTO apartamento (quarto,descricao,valordiaria) VALUES ('" + tb_ap.Text + "','" + tb_de.Text + "','"+tb_va.Text+"')";
            MySqlConnection con = new MySqlConnection("Persist Security Info=False;server=localhost;database=hotelban_central;uid=hotelban_fabarl;server=localhost;database=hotelban_central;uid=hotelban_fabarl;pwd=281200");
            MySqlCommand comand = new MySqlCommand(queryy, con);
            con.Open();
            comand.ExecuteNonQuery();
            MessageBox.Show("Apartamento Inserido com Sucesso!","Sucesso");
            con.Close();
            atualiza_quartos();
        }

        private void excluirApartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = (dataGridView1.CurrentCell.RowIndex);

            this.dataGridView1.Rows[rowIndex].Selected = true;

            string Col1 = dataGridView1[0, dataGridView1.CurrentCellAddress.Y].Value.ToString();

            string query = "DELETE FROM apartamento WHERE quarto = '" + Col1 + "'";
            MySqlConnection con = new MySqlConnection("Persist Security Info=False;server=localhost;database=hotelban_central;uid=hotelban_fabarl;server=localhost;database=hotelban_central;uid=hotelban_fabarl;pwd=281200");
            MySqlCommand command = new MySqlCommand(query, con);
            con.Open();
            // TESTANDO CALCULO FRIGOBAR MessageBox.Show("Total Frigobar (" + total_frigobar + ")- Total a Retirar (" + total_a_retirar + ") = Resultado (" + resultado + ")");
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Apartamento Excluido com Sucesso!", "Sucesso");
            atualiza_quartos();
        }
    }
}
