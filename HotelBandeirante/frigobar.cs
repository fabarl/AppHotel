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
    public partial class frigobar : Form
    {
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private DataSet mDataSet;

        private MySqlConnection fConn;
        private DataSet fDataSet;

        private int linha_atual;
        private string id_selecionado;
        private string nome_selecionado;
        private string vlr_selecionado;
        private string id_frigobar;
        private int is_frigobar;
        string vlr_frigobar;


        void estoque(string prod, string con, string tipo)
        {
            int resul = 0, qtd = 0, min = 0, consu = 0;
            if (tipo == "normal")
            {
                MySqlConnection conn = new MySqlConnection("Persist Security Info=False;server=localhost;database=hotelban_central;uid=hotelban_fabarl;server=localhost;database=hotelban_central;uid=hotelban_fabarl;pwd=281200");
                MySqlDataReader duest;
                MySqlCommand est = conn.CreateCommand();

                est.CommandText = "select * from produtos where produto = '" + prod + "'";
                conn.Open();
                duest = est.ExecuteReader();
                duest.Read();
                qtd = Convert.ToInt32(duest["qtd"].ToString());
                min = Convert.ToInt32(duest["min"].ToString());
                consu = Convert.ToInt32(duest["consumido"].ToString());
                conn.Close();

                if (qtd >= Convert.ToInt32(con))
                {
                    resul = qtd - Convert.ToInt32(con);
                    consu = consu + Convert.ToInt32(con);
                    if (resul <= min)
                        MessageBox.Show("Este Produto Está com Estoque no Minimo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (qtd < Convert.ToInt32(con))
                {
                    resul = 0;
                    consu = consu + Convert.ToInt32(con);
                    MessageBox.Show("Este Produto Está com Estoque Negativo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                string ult = "UPDATE produtos SET qtd ='" + resul + "', consumido = '" + consu + "' WHERE produto = '" + prod + "'";
                MySqlCommand cmd = new MySqlCommand(ult, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        //QUARTOS
        void atualiza_produtos(string item)
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
                MessageBox.Show("Houve um Erro Ao Tentar Receber a Lista de Produtos", "[ ERRO ]", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

            //verificva se a conexão esta aberta
            if (mConn.State == ConnectionState.Open)
            {
                //cria um adapter usando a instrução SQL para acessar a tabela Clientes
                if (item == "padrao")
                {
                    mAdapter = new MySqlDataAdapter("SELECT * FROM produtos", mConn);
                }
                else
                {
                    mAdapter = new MySqlDataAdapter("SELECT * FROM produtos WHERE produto LIKE '%" + item + "%'", mConn);
                }
                //preenche o dataset via adapter
                mAdapter.Fill(mDataSet, "pro");
                //atribui a resultado a propriedade DataSource do DataGrid
                dataGridView.DataSource = mDataSet;
                dataGridView.DataMember = "pro";
                dataGridView.AutoGenerateColumns = false;
                dataGridView.Columns.Clear();

                dataGridView.Columns.Add("id", "ID");
                dataGridView.Columns.Add("produto", "Produto");
                dataGridView.Columns.Add("valor", "Valor");
                 dataGridView.Columns[0].DataPropertyName = "id";
                dataGridView.Columns[1].DataPropertyName = "produto";
                dataGridView.Columns[2].DataPropertyName = "valor";



                dataGridView.Columns[0].Width = 30;
                dataGridView.Columns[1].Width = 200;
                dataGridView.Columns[2].Width = 75;


                this.dataGridView.DefaultCellStyle.ForeColor = Color.MidnightBlue;
                this.dataGridView.DefaultCellStyle.BackColor = Color.LightBlue;
                this.dataGridView.DefaultCellStyle.Font = new Font("Tahoma", 10);
                // this.dataGridView2.DefaultCellStyle.ForeColor = Color.Blue;
                // this.dataGridView2.DefaultCellStyle.BackColor = Color.Beige;
                // this.dataGridView2.DefaultCellStyle.SelectionForeColor = Color.Yellow;
                // this.dataGridView2.DefaultCellStyle.SelectionBackColor = Color.Black;

            }
            mConn.Close();
        }
        void controlr_frigobar()
        {
            string que = "SELECT * FROM historico_frigobar WHERE id_frigobar='" + id_frigobar + "'";
            MySqlConnection conect = new MySqlConnection("Persist Security Info=False;server=localhost;database=hotelban_central;uid=hotelban_fabarl;server=localhost;database=hotelban_central;uid=hotelban_fabarl;pwd=281200");
            MySqlDataReader dr;
            MySqlCommand comman = conect.CreateCommand();
            comman.CommandText = que;

            conect.Open();
            dr = comman.ExecuteReader();
            dr.Read();

            is_frigobar = Convert.ToInt32(dr["id"].ToString());
            is_frigobar = is_frigobar + 1;
            conect.Close();

        }
        // FIM QUARTOS
        void calculo()
        {
            fConn = new MySqlConnection("Persist Security Info=False;server=localhost;database=hotelban_central;uid=hotelban_fabarl;server=localhost;database=hotelban_central;uid=hotelban_fabarl;pwd=281200");
            fConn.Open();
            string query = "SELECT * FROM historico_frigobar ORDER BY id DESC limit 1";
            MySqlDataReader dr;
            MySqlCommand command = fConn.CreateCommand();
            command.CommandText = query;
            dr = command.ExecuteReader();
            dr.Read();
            is_frigobar = Convert.ToInt32(dr["id"].ToString());
            is_frigobar = is_frigobar + 1;
            fConn.Close();
            // colocar a contagem do  historico

        }
        // INSERIR PRODUTO
        void inserir_produto(string ap, string prod, string qtd, string valor, string tipo)
        {
            double s_qtd, s_valor,s_total;
       
            s_qtd = Convert.ToDouble(qtd);
            s_valor = Convert.ToDouble(valor);
            s_total = s_valor * s_qtd;
            decimal result = Convert.ToDecimal(s_total);

            fDataSet = new DataSet();
            //define string de conexao e cria a conexao
            fConn = new MySqlConnection("Persist Security Info=False;server=localhost;database=hotelban_central;uid=hotelban_fabarl;server=localhost;database=hotelban_central;uid=hotelban_fabarl;pwd=281200");

            try
            {
                fConn.Open();
            }
            catch
            {
                MessageBox.Show("Banco de Dados Local Incorreto");
            }
            if (fConn.State == ConnectionState.Open)
            {

                double total_frigobar;
                string query = "SELECT * FROM apartamento WHERE quarto='" + apartamento.Text + "'";
                MySqlDataReader dr;
                MySqlCommand command = fConn.CreateCommand();
                command.CommandText = query;
                 dr = command.ExecuteReader();
                dr.Read();
                vlr_frigobar = dr["frigobar"].ToString();
                id_frigobar = dr["id_frigobar"].ToString();
                total_frigobar = Convert.ToDouble(vlr_frigobar) + s_total;
                string date = DateTime.Now.ToString();
                decimal res = Convert.ToDecimal(total_frigobar);
                fConn.Close();
                calculo();
                fConn.Open();  
                //Se estiver aberta insere os dados na BD
                MySqlCommand commS = new MySqlCommand("INSERT INTO frigobar (apartamento,produto,quantidade,valor,md5,id_frigobar)" + "VALUES('" + ap + "','" + prod + "','" + qtd + "','" + valor + "','" + result + "','" + is_frigobar + "')", fConn);
                MySqlCommand his = new MySqlCommand("INSERT INTO historico_frigobar (produto,quantidade,valor,total,id_frigobar)" + "VALUES('" + prod + "','" + qtd + "','" + valor + "','" + result + "','" + id_frigobar + "')", fConn);
                MySqlCommand vlr = new MySqlCommand("UPDATE apartamento SET frigobar ='" + res + "' WHERE quarto ='" + ap + "'", fConn);
              
                commS.ExecuteNonQuery();
                his.ExecuteNonQuery();
                vlr.ExecuteNonQuery();
                estoque(prod,qtd,tipo);
                MessageBox.Show("O Produto Foi Inserido com Sucesso!");
            }
            fConn.Close();

        }
        //FECHAR INSERIR PRODUTO

        public frigobar(string quarto)
        {
            InitializeComponent();
            apartamento.Text = quarto;
              atualiza_produtos("padrao");
        }

        private void frigobar_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            linha_atual = int.Parse(e.RowIndex.ToString());
            id_selecionado = dataGridView[0, linha_atual].Value.ToString();
            nome_selecionado = dataGridView[1, linha_atual].Value.ToString();
            vlr_selecionado = dataGridView[2, linha_atual].Value.ToString();

            label4.Text = nome_selecionado;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label4.Text == "NENHUM PRODUTO")
            {
                MessageBox.Show("Selecione Um produto Antes");
            }
            if (quantidade.Text == "")
            {
                quantidade.Text = "1";
            }
            if (label4.Text != "NENHUM PRODUTO" && quantidade.Text != "")
            {
                inserir_produto(apartamento.Text, nome_selecionado, quantidade.Text, vlr_selecionado, "normal");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            inserir_produto(apartamento.Text, d_extra.Text, qtd_extra.Text, valor_extra.Text,"extra");     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            atualiza_produtos(pes_nome.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
