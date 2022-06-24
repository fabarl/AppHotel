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
    public partial class produto : Form
    {
         private MySqlConnection mConn;
        private DataSet bdDataSet; //MySQL
        private MySqlDataAdapter mAdapter;
        private DataSet mDataSet;
        private int linha_atual;
        private string item_selecionado;
        private string nome_selecionado;
        private string qtd_selecionado;
        private string vlr_selecionado;
        private string min_selecionado;
        public produto()
        {
            InitializeComponent();
            atualiza_produto();
            }

        void atualiza_produto()
        {
            mDataSet = new DataSet();

            //define string de conexao e cria a conexao
            mConn = new MySqlConnection("Persist Security Info=False;server=localhost;database=hotelban_central;uid=hotelban_fabarl;server=localhost;database=hotelban_central;uid=hotelban_fabarl;pwd=281200");

            try
            {
                //abre a conexao
                mConn.Open();
            }
            catch (System.Exception)
            {
                MessageBox.Show("Houve um Erro Ao Tentar Receber a Lista de Produtos", "[ ERRO Produtos ]", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

            //verificva se a conexão esta aberta
            if (mConn.State == ConnectionState.Open)
            {
                //cria um adapter usando a instrução SQL para acessar a tabela Clientes
                mAdapter = new MySqlDataAdapter("SELECT * FROM produtos order By id DESC", mConn);
                //preenche o dataset via adapter
                mAdapter.Fill(mDataSet, "produtos");
                //atribui a resultado a propriedade DataSource do DataGrid
                dataGridView1.DataSource = mDataSet;
                dataGridView1.DataMember = "produtos";
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.Columns.Clear();

                dataGridView1.Columns.Add("produto", "Produto");
                dataGridView1.Columns.Add("valor", "Valor Unitário");
                dataGridView1.Columns.Add("qtd", "Quantidade");
                dataGridView1.Columns.Add("min", "Minimo Estoque");
                dataGridView1.Columns.Add("consumido", "Consumido");
                dataGridView1.Columns.Add("id", "id");

                dataGridView1.Columns[0].DataPropertyName = "produto";
                dataGridView1.Columns[1].DataPropertyName = "valor";
                dataGridView1.Columns[2].DataPropertyName = "qtd";
                dataGridView1.Columns[3].DataPropertyName = "min";
                dataGridView1.Columns[4].DataPropertyName = "consumido";
                dataGridView1.Columns[5].DataPropertyName = "id";



                dataGridView1.Columns[0].Width = 210;
                dataGridView1.Columns[1].Width = 80;
                dataGridView1.Columns[2].Width = 80;
                dataGridView1.Columns[3].Width = 80;
                dataGridView1.Columns[4].Width = 80;
                dataGridView1.Columns[5].Width = 20;

               
            }
        }



        private void produto_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bdDataSet = new DataSet();
            //define string de conexao e cria a conexao
            mConn = new MySqlConnection("Persist Security Info=False;server=localhost;database=hotelban_central;uid=hotelban_fabarl;server=localhost;database=hotelban_central;uid=hotelban_fabarl;pwd=281200");
           
            try
            {
                mConn.Open();
            }
            catch
            {
                MessageBox.Show("Banco de Dados Local Incorreto");
            }
            if (mConn.State == ConnectionState.Open)
            {
                string date = DateTime.Now.ToString();
                //Se estiver aberta insere os dados na BD
                MySqlCommand commS = new MySqlCommand("INSERT INTO produtos (produto,valor,qtd,min)VALUES('" + prod.Text + "','" + vlr.Text + "','" + qtd.Text + "','" + mim.Text + "')", mConn);
                commS.BeginExecuteNonQuery();
                atualiza_produto();
                MessageBox.Show("O Produto Foi Inserido com Sucesso!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (select_produto.Text == "NENHUM PRODUTO SELECIONADO")
            {
                MessageBox.Show("O Produto a ser Atualizado Não Foi Selecionado", "[ ERRO ]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (MessageBox.Show("Confirmar Atualização de Estoque, Produto: " + nome_selecionado + "?", "Confirmar Produto!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (mConn.State == ConnectionState.Open)
                {
                    string date = DateTime.Now.ToString();
                    if (up_qtd.Text == "")
                        up_qtd.Text = "0";
                    double qq = Convert.ToDouble(qtd_selecionado);
                    double ww = Convert.ToDouble(up_qtd.Text);
                    double valor_total = qq + ww;
                   // MessageBox.Show("Quantidade[" + qtd_selecionado + "]  +  Update_quantidade[" + up_qtd.Text + "] resultad= [ " + valor_total + " ]");
                    //Se estiver aberta insere os dados na BD
                    /*double valor_total = Convert.ToDouble(qtd_selecionado) + Convert.ToDouble(up_qtd.Text);*/
                    MySqlCommand commS = new MySqlCommand("UPDATE produtos SET qtd = '"+valor_total+"', valor = '"+up_vlr.Text+"', min = '"+up_min.Text+"' WHERE id ='" + item_selecionado + "'", mConn);
                    commS.BeginExecuteNonQuery();
                    atualiza_produto();
                    valor_total = 0;
                    MessageBox.Show("Produto Atualizado com Sucesso!");
                    
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            linha_atual = int.Parse(e.RowIndex.ToString());
            item_selecionado = dataGridView1[5, linha_atual].Value.ToString();
            nome_selecionado = dataGridView1[0, linha_atual].Value.ToString();
            qtd_selecionado = dataGridView1[2, linha_atual].Value.ToString();
            vlr_selecionado = dataGridView1[1, linha_atual].Value.ToString();
            min_selecionado = dataGridView1[3, linha_atual].Value.ToString();
            select_produto.Text = nome_selecionado;
            up_min.Text = min_selecionado;
            up_vlr.Text = vlr_selecionado;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (item_selecionado != "")
            {
                string query = "DELETE FROM produtos WHERE id = '" + item_selecionado + "'";
                MySqlConnection con = new MySqlConnection("Persist Security Info=False;server=localhost;database=hotelban_central;uid=hotelban_fabarl;server=localhost;database=hotelban_central;uid=hotelban_fabarl;pwd=281200");
                MySqlCommand command = new MySqlCommand(query, con);
                con.Open();
                // TESTANDO CALCULO FRIGOBAR MessageBox.Show("Total Frigobar (" + total_frigobar + ")- Total a Retirar (" + total_a_retirar + ") = Resultado (" + resultado + ")");
                command.ExecuteNonQuery();
                con.Close();
                atualiza_produto();
            }
            else
            {
                MessageBox.Show("Nenhum Produto Selecionado, Exclusão Não realizada!","Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}
