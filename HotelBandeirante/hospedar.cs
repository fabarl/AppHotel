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
    public partial class hospedar : Form
    {
        private MySqlConnection mConn2;
        private MySqlDataAdapter mAdapter2;
        private DataSet mDataSet2;
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private DataSet mDataSet;
        private int linha_atual;
        private string email_selecionado;
        private string nome_selecionado;
        private string telefone_selecionado;
        private string id_cliente_selecionado;
        public MySqlConnection fConn;
        public MySqlDataAdapter fAdp;
        public DataSet fDataSet;
        private int id_frigobar;
        bool liberar = false;
        private string empresa = "0";


         string r_desconto;
         string r_descricao;
         string r_valor;
         string r_usado;

         public string getMD5Hash(string input)
         {
             System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
             byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
             byte[] hash = md5.ComputeHash(inputBytes);
             System.Text.StringBuilder sb = new System.Text.StringBuilder();
             for (int i = 0; i < hash.Length; i++)
             {
                 sb.Append(hash[i].ToString("X2"));
             }
             return sb.ToString();
         }

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
                MessageBox.Show("Houve um Erro Ao Tentar Receber a Lista de CLientes", "[ ERRO HOSPEDAR ]", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

            //verificva se a conexão esta aberta
            if (mConn2.State == ConnectionState.Open)
            {
                //cria um adapter usando a instrução SQL para acessar a tabela Clientes
                mAdapter2 = new MySqlDataAdapter("SELECT * FROM apartamento WHERE status = 'Livre'", mConn2);
               

            }
        }

        

        // FUNÇÃO DADOS APARTAMENTO
        void dados_apartamento(string num)
        {
            string query = "SELECT * FROM apartamento WHERE quarto='" + num + "'";
            MySqlConnection con = new MySqlConnection("Persist Security Info=False;server=localhost;database=hotelban_central;uid=hotelban_fabarl;server=localhost;database=hotelban_central;uid=hotelban_fabarl;pwd=281200");
            MySqlDataReader dr;
            MySqlCommand command = con.CreateCommand();
            command.CommandText = query;
           
                con.Open();
                    dr = command.ExecuteReader();
                    dr.Read();

                    r_descricao = dr["descricao"].ToString();
                    r_desconto = dr["desconto"].ToString();
                    r_valor = dr["valordiaria"].ToString();
                    r_usado = dr["usado"].ToString();

                    desconto.Text = r_desconto;
                    descricao.Text = r_descricao;
                    vlr_diaria.Text = r_valor;
                    entrada.Text = Convert.ToString(DateTime.Now);
                    DateTime agora = DateTime.Now;
                    hora.Text = Convert.ToString(agora.ToString("HH:mm"));
         
        }
        // FUM FUNÇÃO DADOS APARTAMENTO
        void calculo()
        {
            /*MySqlConnection cin = new MySqlConnection("Persist Security Info=False;server=localhost;database=hotelban_central;uid=hotelban_fabarl;server=localhost;database=hotelban_central;uid=hotelban_fabarl;pwd=281200");
            MySqlCommand tt_id_frigobar = new MySqlCommand("select * from historico", cin);

            cin.Open();
            MySqlDataReader tantan;

            tantan = tt_id_frigobar.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            int contagem = 0;
            while (tantan.Read())
            {
                contagem = contagem + 1;
            }
            id_frigobar = contagem + 1;
            cin.Close();*/
            // colocar a contagem do  historico



            string query = "SELECT * FROM historico ORDER BY id DESC LIMIT 1";
            MySqlConnection cin = new MySqlConnection("Persist Security Info=False;server=localhost;database=hotelban_central;uid=hotelban_fabarl;server=localhost;database=hotelban_central;uid=hotelban_fabarl;pwd=281200");
            MySqlDataReader dir;
            MySqlCommand cun = cin.CreateCommand();
            cun.CommandText = query;

            cin.Open();
            dir = cun.ExecuteReader();
            dir.Read();

            int n_numero = Convert.ToInt32(dir["id"].ToString());
            id_frigobar = n_numero + 1;
            //MessageBox.Show("ID do HISTORICO = "+id_frigobar);

        }
        // FUNÇÃO PROCURAR
        string ver_camp;

        void procurar(string campo, string valor)
        {

            mDataSet = new DataSet();
            switch (campo)
            {
                case "Nome":
                    ver_camp = "nome";
                    break;
                case "Telefone":
                    ver_camp = "telefone";
                    break;
                case "Empresa":
                    ver_camp = "empresa";
                    break;
                case "CPF":
                    ver_camp = "cpf";
                    break;
                case "RG":
                    ver_camp = "rg";
                    break;
                default:
                    ver_camp = "nome";
                    break;
            }
            //define string de conexao e cria a conexao
            mConn = new MySqlConnection("Persist Security Info=False;server=localhost;database=hotelban_central;uid=hotelban_fabarl;server=localhost;database=hotelban_central;uid=hotelban_fabarl;pwd=281200");

            try
            {
                //abre a conexao
                mConn.Open();
            }
            catch (System.Exception)
            {
                MessageBox.Show("Houve um Erro Ao Tentar Conectar ao Banco de Dados", "[ ERRO RESERVA ]", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

            //verificva se a conexão esta aberta
            if (mConn.State == ConnectionState.Open)
            {
                //cria um adapter usando a instrução SQL para acessar a tabela Clientes
                mAdapter = new MySqlDataAdapter("SELECT * FROM clientes WHERE " + ver_camp + " LIKE '%" + valor + "%'", mConn);
                //preenche o dataset via adapter
                mAdapter.Fill(mDataSet, "clientes");
                //atribui a resultado a propriedade DataSource do DataGrid
                dataGridView1.DataSource = mDataSet;
                dataGridView1.DataMember = "clientes";
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("nome", "Hospede");
                dataGridView1.Columns.Add("empresa", "Empresa");
                dataGridView1.Columns.Add("telefone", "Telefone");
                dataGridView1.Columns.Add("id", "id");
                dataGridView1.Columns.Add("email", "E-Mail");
               

                dataGridView1.Columns[0].DataPropertyName = "nome";
                dataGridView1.Columns[1].DataPropertyName = "empresa";
                dataGridView1.Columns[2].DataPropertyName = "telefone";
                dataGridView1.Columns[3].DataPropertyName = "id";
                dataGridView1.Columns[4].DataPropertyName = "email";
                dataGridView1.Columns[0].Width = 200;
                dataGridView1.Columns[1].Width = 100;
                dataGridView1.Columns[2].Width = 100;
                dataGridView1.Columns[3].Width = 30;
                dataGridView1.Columns[4].Width = 0;
                
            }
        }

        // FIM DA FUNÇÃO PROCURAR
        public hospedar(string quarto)
        {
            InitializeComponent();
            numero.Text = quarto;
            dados_apartamento(quarto);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form cad_clientes = new cad_cliente();

            cad_clientes.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

           private void button5_Click(object sender, EventArgs e)
        {
            procurar(cb_campo.Text, tb_procurar.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {

            nome.Text = nome_selecionado;
            email.Text = email_selecionado;
            telefone.Text = telefone_selecionado;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            linha_atual = int.Parse(e.RowIndex.ToString());
            nome_selecionado = dataGridView1[0, linha_atual].Value.ToString();
            email_selecionado = dataGridView1[4, linha_atual].Value.ToString();
            telefone_selecionado = dataGridView1[2, linha_atual].Value.ToString();
            id_cliente_selecionado = dataGridView1[3, linha_atual].Value.ToString();
            empresa = dataGridView1[1, linha_atual].Value.ToString();
            nome.Text = nome_selecionado;
            email.Text = email_selecionado;
            telefone.Text = telefone_selecionado;
            liberar = true;

        }
        private void button2_Click(object sender, EventArgs e)
        {
                calculo();
                if (liberar == true)
                {
                    int total_usado = Convert.ToInt32(r_usado) + 1;
                    // MessageBox.Show("INSERT INTO historico (cliente, data, vlr_diaria, desconto,id_cliente,diaria_normal ) VALUES ('" + nome.Text + "','" + entrada.Text + "', '" + vlr_diaria.Text + "', '" + r_desconto + "', '" + id_cliente_selecionado + "','" + r_valor + "') ");
                    string query = "UPDATE apartamento SET data1 = '"+empresa+"', status = 'Ocupado', cliente = '" + nome.Text + "', entrada = '" + entrada.Text + "', vlr2_diaria = '" + vlr_diaria.Text + "', usado = '" + total_usado + "', hora = '" + hora.Text + "', id_cliente = '" + id_cliente_selecionado + "', pessoas = '" + tb_pessoas.Text + "', id_frigobar = '" + id_frigobar + "' WHERE quarto='" + numero.Text + "'";
                    string query2 = "INSERT INTO historico (cliente, data, vlr_diaria, desconto,id_cliente,diaria_normal ) VALUES ('" + nome.Text + "','" + entrada.Text + "', '" + vlr_diaria.Text + "', '" + r_desconto + "', '" + id_cliente_selecionado + "','" + r_valor + "') ";

                    MySqlConnection con = new MySqlConnection("Persist Security Info=False;server=localhost;database=hotelban_central;uid=hotelban_fabarl;server=localhost;database=hotelban_central;uid=hotelban_fabarl;pwd=281200");
                    MySqlCommand command = new MySqlCommand(query, con);
                    MySqlCommand command2 = new MySqlCommand(query2, con);

                    con.Open();

                    command.ExecuteNonQuery();
                    command2.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Hospedagem Realizada com Sucesso", "Hospedagem");
                    Close();
                }
                else
                {
                    MessageBox.Show("Selecione o Hospede a ser Hospedado!", "Hospedagem",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

                }
                   
        }

        private void hospedar_Load(object sender, EventArgs e)
        {

        }

        private void tb_pessoas_TextChanged(object sender, EventArgs e)
        {
            if(tb_pessoas.Text == "" || tb_pessoas.Text == " ")
                tb_pessoas.Text = "1";
            if (Convert.ToDouble(tb_pessoas.Text) <= 0)
                tb_pessoas.Text = "1";
        }
    }
}
