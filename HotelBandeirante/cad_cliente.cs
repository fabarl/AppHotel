using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Data;
using MySql.Data.MySqlClient;

namespace HotelBandeirante
{
    public partial class cad_cliente : Form
    {
        private MySqlConnection mConn;
        private MySqlConnection mConn2;
       // private MySqlDataAdapter bdAdapter;
        private DataSet bdDataSet; //MySQL
        public cad_cliente()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bdDataSet = new DataSet();
            //define string de conexao e cria a conexao
            mConn = new MySqlConnection("Persist Security Info=False;server=localhost;database=hotelban_central;uid=hotelban_fabarl;server=localhost;database=hotelban_central;uid=hotelban_fabarl;pwd=281200");
            mConn2 = new MySqlConnection("Persist Security Info=False;server=108.168.144.37;database=hotelban_central;uid=hotelban_fabarl;server=108.168.144.37;database=hotelban_central;uid=hotelban_fabarl;pwd=281200");

            try
            {
                mConn.Open();
            }
            catch
            {
                MessageBox.Show("Banco de Dados Local Incorreto");
            }
            try
            {
                mConn2.Open();
            }
            catch
            {
                MessageBox.Show("Banco de Dados On-Line Não Está Acessivel, Atualiza os Cadastros Posteriormente");
            }

            //Verifica se a conexão está aberta
            if (mConn.State == ConnectionState.Open)
            {
                string date = DateTime.Now.ToString();
                //Se estiver aberta insere os dados na BD
                MySqlCommand commS = new MySqlCommand("INSERT INTO clientes (nome,endereco,cpf,rg,email,telefone,telefone2,cidade,estado,data,empresa,cargo,cnpj)VALUES('" + nome.Text + "','" + endereco.Text + "','" + cpf.Text + "','" + rg.Text + ssp.Text + "','" + email.Text + "','" + telefone.Text + "','" + telefone2.Text + "','" + cidade.Text + "','" + estado.Text + "','" + date + "','" + tb_empresa.Text + "','" + tb_cargo.Text + "','" + tb_cnpj.Text + "')", mConn);
                commS.BeginExecuteNonQuery();
                MessageBox.Show("Cadastrado no Software com Sucesso!");
            }
            if (mConn2.State == ConnectionState.Open)
            {
                string date = DateTime.Now.ToString();
                //Se estiver aberta insere os dados na BD
                MySqlCommand commS = new MySqlCommand("INSERT INTO clientes (nome,endereco,cpf,rg,email,telefone,telefone2,cidade,estado,data,empresa,cargo,cnpj)VALUES('" + nome.Text + "','" + endereco.Text + "','" + cpf.Text + "','" + rg.Text + ssp.Text + "','" + email.Text + "','" + telefone.Text + "','" + telefone2.Text + "','" + cidade.Text + "','" + estado.Text + "','" + date + "','" + tb_empresa.Text + "','" + tb_cargo.Text + "','" + tb_cnpj.Text + "')", mConn2);
                commS.BeginExecuteNonQuery();
                MessageBox.Show("Cadastrado no site com Sucesso!");
            }
            Close();
        }

        private void cad_cliente_Load(object sender, EventArgs e)
        {

        }
    }
}
