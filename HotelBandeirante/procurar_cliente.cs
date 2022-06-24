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
    public partial class procurar_cliente : Form
    {
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private DataSet mDataSet;
        private MySqlConnection fConn;
        private int linha_atual;
         private string nome;
         private string email;
         private string telefone;
         private string endereco;
         private string cpf;
         private string rg;
         private string empresa;
         private string observacao;
         private string vlr_debito;
         private string dat_nasc;
         private string id;
         private string cidade;
         private string estado;
         private string cargo;
        private string telefone2;


        public procurar_cliente()
        {
            InitializeComponent();
        }

public    procurar_cliente(hospedar hospedar)
    {
        // TODO: Complete member initialization
this.hospedar = hospedar;
    }
        string ver_camp;
private   hospedar hospedar;

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
                default :
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
                dataGridView1.Columns.Add("email", "E-Mail");
                dataGridView1.Columns.Add("telefone", "Telefone");
                dataGridView1.Columns.Add("id", "ID");

                dataGridView1.Columns[0].DataPropertyName = "nome";
                dataGridView1.Columns[1].DataPropertyName = "email";
                dataGridView1.Columns[2].DataPropertyName = "telefone";
                dataGridView1.Columns[3].DataPropertyName = "id";



                dataGridView1.Columns[0].Width = 250;
                dataGridView1.Columns[1].Width = 200;
                dataGridView1.Columns[2].Width = 150;
                dataGridView1.Columns[3].Width = 0;

         }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            procurar(cb_campo.Text, tb_procurar.Text);
            
        }

        private void procurar_cliente_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            linha_atual = int.Parse(e.RowIndex.ToString());
            id = dataGridView1[3, linha_atual].Value.ToString();
            fConn = new MySqlConnection("Persist Security Info=False;server=localhost;database=hotelban_central;uid=hotelban_fabarl;server=localhost;database=hotelban_central;uid=hotelban_fabarl;pwd=281200");
            string query = "SELECT * FROM clientes WHERE id='" +id + "'";
            fConn.Open();
            MySqlDataReader dr;
            MySqlCommand command = fConn.CreateCommand();
            command.CommandText = query;
            dr = command.ExecuteReader();
            dr.Read();

            nome = dr["nome"].ToString();
            email = dr["email"].ToString();
            telefone = dr["telefone"].ToString();
            endereco = dr["endereco"].ToString();
            cpf = dr["cpf"].ToString();
            rg = dr["rg"].ToString();
            empresa = dr["empresa"].ToString();
            observacao = dr["observacao"].ToString();
            vlr_debito = dr["vlr_debito"].ToString();
            dat_nasc = dr["dat_nasc"].ToString();
            cidade = dr["cidade"].ToString();
            estado = dr["estado"].ToString();
            cargo = dr["cargo"].ToString();
            telefone2 = dr["telefone2"].ToString();
            if (vlr_debito == "0")
            {
                lb_debito.ForeColor = Color.SeaGreen;
                lb_debito.Text = "Cliente sem Débitos!";
            }
            else
            {
                lb_debito.ForeColor = Color.Red;
                lb_debito.Text = "Cliente em Débitos!";

            }
            tb_nome.Text = nome;
            tb_email.Text = email;
            tb_telefone.Text = telefone;
            tb_endereco.Text = endereco;
            tb_cpf.Text = cpf;
            tb_rg.Text = rg;
            tb_empresa.Text = empresa;
            tb_obs.Text = observacao;
            tb_valor_debito.Text = vlr_debito;
            tb_nasc.Text = dat_nasc;
            tb_cidade.Text = cidade;
            tb_estado.Text = estado;
            tb_cargo.Text = cargo;
            tb_telefone2.Text = telefone2;
            fConn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fConn = new MySqlConnection("Persist Security Info=False;server=localhost;database=hotelban_central;uid=hotelban_fabarl;server=localhost;database=hotelban_central;uid=hotelban_fabarl;pwd=281200");
            
            fConn.Open();
            if (fConn.State == ConnectionState.Open)
            {
                
                // MessageBox.Show("Quantidade[" + qtd_selecionado + "]  +  Update_quantidade[" + up_qtd.Text + "] resultad= [ " + valor_total + " ]");
                //Se estiver aberta insere os dados na BD

                /*double valor_total = Convert.ToDouble(qtd_selecionado) + Convert.ToDouble(up_qtd.Text);*/
                MySqlCommand commS = new MySqlCommand("UPDATE clientes SET nome='" + tb_nome.Text + "', email='" + tb_email.Text + "', telefone='" + tb_telefone.Text + "', endereco = '" + tb_endereco.Text + "', cpf='" + tb_cpf.Text + "', rg='" + tb_rg.Text + "',empresa = '" + tb_empresa.Text + "', observacao = '" + tb_obs.Text + "',vlr_debito='" + tb_valor_debito.Text + "', dat_nasc='" + tb_nasc.Text + "', cidade='" + tb_cidade.Text + "', estado='" + tb_estado.Text + "', cargo='" + tb_cargo.Text + "', telefone2='" + tb_telefone2.Text + "' WHERE id ='"+id+"' ", fConn);
               commS.BeginExecuteNonQuery();
               procurar(cb_campo.Text, tb_procurar.Text);
                MessageBox.Show("Dados Atualizado com Sucesso!");

            }
        }
    }
}
