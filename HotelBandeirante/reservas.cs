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
    public partial class reservas : Form
    {
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private DataSet mDataSet;
        private int linha_atual;
        private string item_selecionado;
        private string nome_selecionado;
        void atualiza_reserva(string filtro)
        {
            mDataSet = new DataSet();

            //define string de conexao e cria a conexao
            mConn = new MySqlConnection("Persist Security Info=False;server=108.168.144.37;database=hotelban_central;uid=hotelban_fabarl;server=108.168.144.37;database=hotelban_central;uid=hotelban_fabarl;pwd=281200");

            try
            {
                //abre a conexao
                mConn.Open();
            }
            catch (System.Exception)
            {
                MessageBox.Show("Houve um Erro Ao Tentar Receber a Lista de Reservas On-Line", "[ ERRO RESERVA ]", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

            //verificva se a conexão esta aberta
            if (mConn.State == ConnectionState.Open)
            {
                //cria um adapter usando a instrução SQL para acessar a tabela Clientes
                if (filtro == "vazio")
                {
                    mAdapter = new MySqlDataAdapter("SELECT * FROM reserva order By id DESC", mConn);
                }
                else
                {
                    mAdapter = new MySqlDataAdapter("SELECT * FROM reserva WHERE status = '"+filtro+"' order By id DESC", mConn);
                }
                //preenche o dataset via adapter
                mAdapter.Fill(mDataSet, "reserva");
                //atribui a resultado a propriedade DataSource do DataGrid
                dataGridView1.DataSource = mDataSet;
                dataGridView1.DataMember = "reserva";
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.Columns.Clear();

                dataGridView1.Columns.Add("nome", "Hospede");
                dataGridView1.Columns.Add("email", "E-Mail");
                dataGridView1.Columns.Add("telefone", "Telefone");
                dataGridView1.Columns.Add("entrada", "Check-IN");
                dataGridView1.Columns.Add("saida", "Check-OUT");
                dataGridView1.Columns.Add("status", "Status");
                dataGridView1.Columns.Add("id", "id");

                dataGridView1.Columns[0].DataPropertyName = "nome";
                dataGridView1.Columns[1].DataPropertyName = "email";
                dataGridView1.Columns[2].DataPropertyName = "telefone";
                dataGridView1.Columns[3].DataPropertyName = "entrada";
                dataGridView1.Columns[4].DataPropertyName = "saida";
                dataGridView1.Columns[5].DataPropertyName = "status";
                dataGridView1.Columns[6].DataPropertyName = "id";



                dataGridView1.Columns[0].Width = 200;
                dataGridView1.Columns[1].Width = 170;
                dataGridView1.Columns[2].Width = 75;
                dataGridView1.Columns[3].Width = 75;
                dataGridView1.Columns[4].Width = 75;
                dataGridView1.Columns[5].Width = 120;
                dataGridView1.Columns[6].Width = 20;
            }
        }
        public reservas()
        {
            InitializeComponent();
            atualiza_reserva("vazio");

         }

        private void reservas_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            linha_atual = int.Parse(e.RowIndex.ToString());
        }

        private void conf_reserva_Click(object sender, EventArgs e)
        {
            item_selecionado = dataGridView1[6, linha_atual].Value.ToString();
            nome_selecionado = dataGridView1[0, linha_atual].Value.ToString();
            if (MessageBox.Show("Confirmar a Reserva de " + nome_selecionado + "?", "Confirmar Reserva!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (mConn.State == ConnectionState.Open)
                {
                    string date = DateTime.Now.ToString();
                    //Se estiver aberta insere os dados na BD
                    MySqlCommand commS = new MySqlCommand("UPDATE reserva SET status = 'Reserva Confirmada', local = 'Software' WHERE id ='"+item_selecionado+"'", mConn);
                    commS.BeginExecuteNonQuery();
                    MessageBox.Show("Reserva Confirmada com Sucesso!");
                    atualiza_reserva("vazio");
                }
            }
        }

        private void can_reserva_Click(object sender, EventArgs e)
        {
            item_selecionado = dataGridView1[6, linha_atual].Value.ToString();
            nome_selecionado = dataGridView1[0, linha_atual].Value.ToString();
            if (MessageBox.Show("Cancelar a Reserva de " + nome_selecionado + "?", "Cancelar Reserva!", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (mConn.State == ConnectionState.Open)
                {
                    string date = DateTime.Now.ToString();
                    //Se estiver aberta insere os dados na BD
                    MySqlCommand commS = new MySqlCommand("UPDATE reserva SET status = 'Reserva Cancelada', local = 'Software' WHERE id ='" + item_selecionado + "'", mConn);
                    commS.BeginExecuteNonQuery();
                    MessageBox.Show("Reserva Cancelada com Sucesso!");
                    atualiza_reserva("vazio");
                }
            }
        }

        private void exc_reserva_Click(object sender, EventArgs e)
        {
            item_selecionado = dataGridView1[6, linha_atual].Value.ToString();
            nome_selecionado = dataGridView1[0, linha_atual].Value.ToString();
            if (MessageBox.Show("Apagar totalmente do Sistemta a Reserva de " + nome_selecionado + "?", "Cancelar Reserva!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (mConn.State == ConnectionState.Open)
                {
                    string date = DateTime.Now.ToString();
                    //Se estiver aberta insere os dados na BD
                    MySqlCommand commS = new MySqlCommand("DELETE FROM reserva WHERE id='" + item_selecionado + "'", mConn);
                    commS.BeginExecuteNonQuery();
                    MessageBox.Show("Reserva Cancelada com Sucesso!");
                    atualiza_reserva("vazio");
                }
            }
        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            if (mConn.State == ConnectionState.Open)
            {
                string date = DateTime.Now.ToString();
                //Se estiver aberta insere os dados na BD
                MySqlCommand commS = new MySqlCommand("INSERT INTO reserva (apartamento,data,entrada,saida,nome,email,telefone,status,local)VALUES('" + pessoas.Text + "','" + date + "','" + entrada.Text + "','" + saida.Text + "','" + nome.Text + "','" + email.Text + "','" + telefone.Text + "','Aguardando Hotel','Software')", mConn);
                commS.BeginExecuteNonQuery();
                atualiza_reserva("vazio"); 
                MessageBox.Show("Reserva Realizada Com Sucesso!", "Reservas",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (cb_filtro.Text)
            {
                case "Em Aberta":
                    atualiza_reserva("Aguardando Hotel");
                    break;
                case "Confirmada":
                    atualiza_reserva("Reserva Confirmada");

                    break;
                case "Cancelada":
                    atualiza_reserva("Reserva Cancelada");
                    break;
            }
        }

    }
}
