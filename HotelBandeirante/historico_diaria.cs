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
    public partial class historico_diaria : Form

    {
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private DataSet mDataSet;

        private int linha_atual;

       private string apartamento;
       private string cliente;
       private string saida;
       private string diaria_normal;
       private string vlr_diaria;
       private string desconto;
       private string vlr_frigobar;
       private string valor_total;
       private string debito;
       private string hora_entrada;
       private string hora_saida;
       private string entrada;
       private string id_cliente;
       private string id_frigobar;
       private string diarias;
       private string id;

       void atualiza_frigobar(string id_fri)
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
             
               mAdapter = new MySqlDataAdapter("SELECT * FROM historico_frigobar WHERE id_frigobar = '"+id_fri+"'", mConn);
               //preenche o dataset via adapter
               mAdapter.Fill(mDataSet, "pro");
               //atribui a resultado a propriedade DataSource do DataGrid
               dataGridView.DataSource = mDataSet;
               dataGridView.DataMember = "pro";
               dataGridView.AutoGenerateColumns = false;
               dataGridView.Columns.Clear();

               dataGridView.Columns.Add("id", "ID");
               dataGridView.Columns.Add("produto", "Produto");
               dataGridView.Columns.Add("quantidade", "Qtd.");
               dataGridView.Columns.Add("valor", "Valor");
               dataGridView.Columns.Add("status", "Status");
               dataGridView.Columns[0].DataPropertyName = "id";
               dataGridView.Columns[1].DataPropertyName = "produto";
               dataGridView.Columns[2].DataPropertyName = "quantidade";
               dataGridView.Columns[3].DataPropertyName = "valor";
               dataGridView.Columns[4].DataPropertyName = "Status";


               dataGridView.Columns[0].Width = 0;
               dataGridView.Columns[1].Width = 100;
               dataGridView.Columns[2].Width = 30;
               dataGridView.Columns[3].Width = 50;
               dataGridView.Columns[4].Width = 75;

               this.dataGridView.DefaultCellStyle.ForeColor = Color.MidnightBlue;
               this.dataGridView.DefaultCellStyle.BackColor = Color.White;
               this.dataGridView.DefaultCellStyle.Font = new Font("Tahoma", 8);
               // this.dataGridView2.DefaultCellStyle.ForeColor = Color.Blue;
               // this.dataGridView2.DefaultCellStyle.BackColor = Color.Beige;
               // this.dataGridView2.DefaultCellStyle.SelectionForeColor = Color.Yellow;
               // this.dataGridView2.DefaultCellStyle.SelectionBackColor = Color.Black;

           }
           mConn.Close();
       }
        void procurar(string campo, string valor,string data2)
        {
              //define string de conexao e cria a conexao
            mConn = new MySqlConnection("Persist Security Info=False;server=localhost;database=hotelban_central;uid=hotelban_fabarl;server=localhost;database=hotelban_central;uid=hotelban_fabarl;pwd=281200");

            try
            {
                //abre a conexao
                mConn.Open();
            }
            catch (System.Exception)
            {
                MessageBox.Show("Houve um Erro Ao Tentar Conectar ao Banco de Dados", "[ ERRO Caixa ]", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

            //verificva se a conexão esta aberta
            if (mConn.State == ConnectionState.Open)
            {
                //cria um adapter usando a instrução SQL para acessar a tabela Clientes
               // mAdapter = new MySqlDataAdapter("SELECT * FROM historico WHERE " + ver_camp + " LIKE '%" + valor + "%'", mConn);
                //preenche o dataset via adapter
                mDataSet = new DataSet();
                
                switch (campo)
                {
                    case "Nome":
                        mAdapter = new MySqlDataAdapter("SELECT * FROM historico WHERE cliente LIKE '%" + valor + "%' ORDER by id DESC", mConn);
                        break;
                    case "Entre Datas":
                        mAdapter = new MySqlDataAdapter("SELECT * FROM historico WHERE saida_calc BETWEEN '" + System.DateTime.Parse(valor).ToString("yyyy-MM-dd") + "' AND '" + System.DateTime.Parse(data2).ToString("yyyy-MM-dd") + "' ORDER by id DESC", mConn);
                        string data_ini = valor, data_fim = data2;
                        
                        double valor_total = 0, valor_frigobar = 0, valor_debito = 0, valor_diarias = 0, valor_dia = 0;
                        DateTime d = DateTime.Parse(data_fim);
                                d = d.AddDays(1);
                                data_fim = String.Format("{0:d}", d);
 
                            MySqlConnection conm = new MySqlConnection("Persist Security Info=False;server=localhost;database=hotelban_central;uid=hotelban_fabarl;server=localhost;database=hotelban_central;uid=hotelban_fabarl;pwd=281200");
                            MySqlDataReader du;
                            MySqlCommand clin = conm.CreateCommand();
                            int cont = 0;
                           
                            do
                            {
                                conm.Open();
                                string sunsun = "SELECT * FROM historico WHERE saida = '" + data_ini + "'";
                                clin.CommandText = sunsun;
                                du = clin.ExecuteReader();
                                while (du.Read())
                                {
                                    
                                    double vu_status = Convert.ToDouble(du["valor_total"].ToString());
                                    double vu_diarias = Convert.ToDouble(du["vlr_diaria"].ToString());
                                    double vu_frig = Convert.ToDouble(du["vlr_frigobar"].ToString());
                                    double vu_deb = Convert.ToDouble(du["debito"].ToString());
                                    double cal = Convert.ToDouble(du["diarias"].ToString());
                                    double todin = cal * vu_diarias;
                                    valor_dia = valor_dia + cal;
                                    valor_diarias = valor_diarias + todin;
                                    valor_frigobar = valor_frigobar + vu_frig;
                                    valor_debito = valor_debito + vu_deb;
                                    valor_total = valor_total + vu_status;
                                    cont++;
                                }
                                DateTime y = DateTime.Parse(data_ini);
                                y = y.AddDays(1);
                                data_ini = String.Format("{0:d}", y);
                                conm.Close();
                                   } while (data_ini != data_fim);
                            t_res.Text = Convert.ToString(cont);
                            t_total.Text = Convert.ToString(valor_total);
                            t_frig.Text = Convert.ToString(valor_frigobar);
                            t_dias.Text = Convert.ToString(valor_diarias);
                            t_deb.Text = Convert.ToString(valor_debito);
                            t_diarias.Text = Convert.ToString(valor_dia);
            break;
                    case "Data":
                        mAdapter = new MySqlDataAdapter("SELECT * FROM historico WHERE saida LIKE '%" + valor + "%' ORDER by id DESC", mConn);
                        break;
                    default:
                        mAdapter = new MySqlDataAdapter("SELECT * FROM historico WHERE saida LIKE '%" + valor + "%' ORDER by id DESC ", mConn);
                        break;
                }
                mAdapter.Fill(mDataSet, "apartamentos");
                //atribui a resultado a propriedade DataSource do DataGrid
                dataGridView1.DataSource = mDataSet;
                dataGridView1.DataMember = "apartamentos";
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("apartamento", "N° Ap.");
                dataGridView1.Columns.Add("cliente", "cliente");
                dataGridView1.Columns.Add("saida", "Fechou Conta");
                dataGridView1.Columns.Add("diaria_normal", "Preço Diaria");
                dataGridView1.Columns.Add("vlr_diaria", "Preço Feito");
                dataGridView1.Columns.Add("desconto", "Desconto");
                dataGridView1.Columns.Add("vlr_frigobar", "Valor Frigobar");
                dataGridView1.Columns.Add("valor_total", "Valor Total");
                dataGridView1.Columns.Add("debito", "Debito");
                dataGridView1.Columns.Add("hora_entrada", "Hora Entrada");
                dataGridView1.Columns.Add("hora_saida", "Hora Saida");
                dataGridView1.Columns.Add("data", "Entrada");
                dataGridView1.Columns.Add("id_cliente", "idCliente");
                dataGridView1.Columns.Add("id_frigobar", "idFrigobar");
                dataGridView1.Columns.Add("diarias", "Diarias");
                dataGridView1.Columns.Add("id", "id");


                 dataGridView1.Columns[0].DataPropertyName = "apartamento";
                 dataGridView1.Columns[1].DataPropertyName = "cliente";
                 dataGridView1.Columns[2].DataPropertyName = "saida";
                 dataGridView1.Columns[3].DataPropertyName = "diaria_normal";
                 dataGridView1.Columns[4].DataPropertyName = "vlr_diaria";
                 dataGridView1.Columns[5].DataPropertyName = "desconto";
                 dataGridView1.Columns[6].DataPropertyName = "vlr_frigobar";
                 dataGridView1.Columns[7].DataPropertyName = "valor_total";
                 dataGridView1.Columns[8].DataPropertyName = "debito";
                 dataGridView1.Columns[9].DataPropertyName = "hora_entrada";
                 dataGridView1.Columns[10].DataPropertyName = "hora_saida";
                 dataGridView1.Columns[11].DataPropertyName = "data";
                 dataGridView1.Columns[12].DataPropertyName = "id_cliente";
                 dataGridView1.Columns[13].DataPropertyName = "id_frigobar";
                 dataGridView1.Columns[14].DataPropertyName = "diarias";
                 dataGridView1.Columns[15].DataPropertyName = "id";



                 dataGridView1.Columns[0].Width = 30;
                 dataGridView1.Columns[1].Width = 300;
                 dataGridView1.Columns[2].Width = 200;
                 dataGridView1.Columns[3].Width = 0;
                 dataGridView1.Columns[4].Width = 30;
                 dataGridView1.Columns[5].Width = 0;
                 dataGridView1.Columns[6].Width = 0;
                 dataGridView1.Columns[7].Width = 0;
                 dataGridView1.Columns[8].Width = 0;
                 dataGridView1.Columns[9].Width = 0;
                 dataGridView1.Columns[10].Width = 0;
                 dataGridView1.Columns[11].Width = 0;
                 dataGridView1.Columns[12].Width = 0;
                 dataGridView1.Columns[13].Width = 0;
                 dataGridView1.Columns[14].Width = 0;
                 dataGridView1.Columns[15].Width = 0;


                 this.dataGridView1.DefaultCellStyle.ForeColor = Color.MidnightBlue;
                 this.dataGridView1.DefaultCellStyle.BackColor = Color.LightBlue;
                 this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 10);

            }
        }
        public historico_diaria()
        {
            InitializeComponent();
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            mtb_data.Visible = true;
            tb_nome.Visible = false;
            lb_fim.Visible = false;
            mtb_fim.Visible = false;
            lb_pri.Text = "Data:";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_opcoes.Text == "Data")
            {
                lb_pri.Text = "Data:";
                mtb_data.Visible = true;
                tb_nome.Visible = false;
                lb_fim.Visible = false;
                mtb_fim.Visible = false;


            }
             if (cb_opcoes.Text == "Entre Datas")
            {
                lb_pri.Text = "Inicio:";
                mtb_data.Visible = true;
                tb_nome.Visible = false;
                lb_fim.Visible = true;
                mtb_fim.Visible = true;

            }
           

            if (cb_opcoes.Text == "Nome")
            {
                lb_pri.Text = "Nome:";
                mtb_data.Visible = false;
                tb_nome.Visible = true;
                lb_fim.Visible = false;
                mtb_fim.Visible = false;

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            linha_atual = int.Parse(e.RowIndex.ToString());

            apartamento = dataGridView1[0, linha_atual].Value.ToString();
            cliente = dataGridView1[1, linha_atual].Value.ToString();
            saida = dataGridView1[2, linha_atual].Value.ToString();
            diaria_normal = dataGridView1[3, linha_atual].Value.ToString();
            vlr_diaria = dataGridView1[4, linha_atual].Value.ToString();
            desconto = dataGridView1[5, linha_atual].Value.ToString();
            vlr_frigobar = dataGridView1[6, linha_atual].Value.ToString();
            valor_total = dataGridView1[7, linha_atual].Value.ToString();
            debito = dataGridView1[8, linha_atual].Value.ToString();
            hora_entrada = dataGridView1[9, linha_atual].Value.ToString();
            hora_saida = dataGridView1[10, linha_atual].Value.ToString();
            entrada = dataGridView1[11, linha_atual].Value.ToString();
            id_cliente = dataGridView1[12, linha_atual].Value.ToString();
            id_frigobar = dataGridView1[13, linha_atual].Value.ToString();
            diarias = dataGridView1[14, linha_atual].Value.ToString();
            id = dataGridView1[15, linha_atual].Value.ToString(); 
            r_ap.Text = apartamento;
            r_debito.Text = debito;
           // MessageBox.Show("Débito recebe " + debito);
            //r_debito.Mask = converter(r_debito.Text);
            //MessageBox.Show("Débito Mascara recebe " + converter(r_debito.Text));
            r_desc.Text = desconto;
            r_diarias.Text = diarias;
            r_entrada.Text = entrada;
            r_frigobar.Text = vlr_frigobar;
            //r_frigobar.Mask = converter(r_frigobar.Text);
           // MessageBox.Show("Frigobar Mascara recebe " + converter(r_frigobar.Text));
            r_nome.Text = cliente;
            r_saida.Text = saida;
            r_vlr_cobrado.Text = vlr_diaria;
            //r_vlr_cobrado.Mask = converter(r_vlr_cobrado.Text);
            //MessageBox.Show("Vlr Diaria Mascara recebe " + converter(r_vlr_cobrado.Text));
            r_vlr_diaria.Text = diaria_normal;
           // r_vlr_diaria.Mask = converter(r_vlr_diaria.Text);
           // MessageBox.Show("Diaria normal Mascara recebe " + converter(r_vlr_diaria.Text));
            r_total.Text = valor_total;
            //r_total.Mask = converter(r_total.Text);
            //MessageBox.Show("Total Mascara recebe " + converter(r_total.Text));
            atualiza_frigobar(id);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string opcao2 = "nada", opcao3 = "nada";
            switch (cb_opcoes.Text)
            {
                case "Entre Datas":
                    opcao2 = mtb_data.Text;
                    opcao3 = mtb_fim.Text;
                    groupBox1.Visible = false;
                    groupBox2.Visible = true;
                    break;
                case "Nome":
                    opcao2 = tb_nome.Text;
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    break;
                case "Data":
                    opcao2 = mtb_data.Text;
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    break;
                default:
                    opcao2 = mtb_data.Text;
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    break;
            }
            procurar(cb_opcoes.Text, opcao2,opcao3);
        }

        private void r_total_TextChanged(object sender, EventArgs e)
        {


        }

        private void historico_diaria_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
