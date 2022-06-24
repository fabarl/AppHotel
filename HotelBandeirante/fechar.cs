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
    public partial class fechar : Form
    {
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private DataSet mDataSet;

        private MySqlConnection mConn1;
        private MySqlDataAdapter mAdapter1;
        private DataSet mDataSet1;

        private MySqlConnection mConn0;
        private int linha_atual;
        private string quarto_selecionado;
        private string cliente_selecionado;
        private string entrada_selecionado;
        private string hora_selecionado;
        private string diaria_selecionado;
        private string frigobar_selecionado;
        private string desconto_selecionado;
        private string pessoas_selecionado;
        private string total_a_pagar;
        private int id_frigobar;
        private string empresa;
      
        string cliente_id;

        double por = 0;
        double fri = 0, val = 0, extra = 0;
        string debito;

        // MOSTRA CLIENTES

        void calculo()
        {
            MySqlConnection cin = new MySqlConnection("Persist Security Info=False;server=localhost;database=hotelban_central;uid=hotelban_fabarl;server=localhost;database=hotelban_central;uid=hotelban_fabarl;pwd=281200");
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
            cin.Close();
            // colocar a contagem do  historico

        }
        void contas()
        {
            double min = 0;
            double ttt = 0;
            extra = 0;
            frigobar(quarto_selecionado);
         
            
            fri = Convert.ToDouble(frigobar_selecionado);
            val = Convert.ToDouble(diaria_selecionado);
            total_a_pagar = Convert.ToString(fri + val);
            lb_valor_total.Text = "Total: "+total_a_pagar + " R$";
             string temp_hora = tb_hora.Text;

             string temp = tb_entrada.Text;
             string hora_temp1 = tb_hora.Text;
             string hora_temp2 = tb_saida_hora.Text;
             string temp2 = tb_saida.Text;
            double bon,ton;
            
                 bon = classe_diaria.Classe_Diaria.calculo(temp+" "+hora_temp1,temp+" 12:00", "Horas");
                 if (bon < 0)
                {
                    DateTime d = DateTime.Parse(temp);
                    d = d.AddDays(-1);
                    temp = String.Format("{0:d}", d);
                     }
                         
                 double HoraRetornado = classe_diaria.Classe_Diaria.calculo(temp2 + " "+hora_temp2, temp+" "+hora_temp1, "Horas");
                 double HoraRetornado2;
                 ton = classe_diaria.Classe_Diaria.calculo(tb_saida.Text+" 12:00", tb_saida.Text + " " + tb_saida_hora.Text, "Horas");
                        if (ton < 0)
                        {
                            DateTime d = DateTime.Parse(temp2);
                            d = d.AddDays(1);
                            temp2 = String.Format("{0:d}", d);
                            
                       }
                        HoraRetornado2 = classe_diaria.Classe_Diaria.calculo(temp2 + " 12:00", temp + " 12:00", "Dias");
                        double dias = HoraRetornado2;
                       double total = dias + extra;
                       double total_dia;
            if (tb_desconto.Text == "")
                tb_desconto.Text = "Porcentagem";
                tb_qtd.Text = Convert.ToString(dias + extra);
               total_dia = (total * Convert.ToDouble(tb_valor.Text));
           if (tb_desconto.Text == "Porcentagem")
                    {
                        double percentual = Convert.ToDouble(tb_desconto_valor.Text) / 100; // 15%
                        //double valor_final = valor + (percentual ^ valor);

                        por = (total_dia - (percentual * total_dia)) + Convert.ToDouble(tb_frigobar.Text);
                    }
                    if (tb_desconto.Text == "Dinheiro")
                    {

                        por = (total_dia - Convert.ToDouble(tb_desconto_valor.Text)) + Convert.ToDouble(tb_frigobar.Text);
                    }

                    tb_diarias.Text = Convert.ToString(Convert.ToInt32(total_dia));
                    if (tb_pagar.Text == "")
                        tb_pagar.Text = "0";
                    ttt = Convert.ToDouble(tb_pagar.Text);
                  
            lb_valor_total.Text = "Total: "+Convert.ToString(por) + " R$";
            
            if (por > ttt)
            {
                min = por - ttt;
                lb_valor_debito.Text ="Débito: "+ Convert.ToString(min) + " R$";
                lb_valor_troco.Text = "Troco: 00,00 R$";
                debito = Convert.ToString(min);
               
                
            }
            if (por <= ttt)
            {
                min =  ttt-por;
                lb_valor_debito.Text = "Débito: 00,00 R$";
                lb_valor_troco.Text = "Troco: " + Convert.ToString(min) + " R$";
                debito = "0";
            }
        }



        void fim_conta()
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
                MessageBox.Show("Houve um Erro Ao Tentar Receber a Lista de Clientes", "[ ERRO ]", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

            //verificva se a conexão esta aberta
            if (mConn.State == ConnectionState.Open)
            {
                //cria um adapter usando a instrução SQL para acessar a tabela Clientes
                mAdapter = new MySqlDataAdapter("SELECT * FROM apartamento WHERE status = 'Ocupado'", mConn);
               
                //preenche o dataset via adapter
                mAdapter.Fill(mDataSet, "pro");
                //atribui a resultado a propriedade DataSource do DataGrid
                dataGridView.DataSource = mDataSet;
                dataGridView.DataMember = "pro";
                dataGridView.AutoGenerateColumns = false;
                dataGridView.Columns.Clear();

                dataGridView.Columns.Add("quarto", "N°");
                dataGridView.Columns.Add("cliente", "Cliente");
                dataGridView.Columns.Add("entrada", "Entrada");
                dataGridView.Columns.Add("data1", "Empresa");
                dataGridView.Columns.Add("frigobar", "Frigobar");
                dataGridView.Columns.Add("vlr2_diaria", "Diaria");
                dataGridView.Columns.Add("desconto", "Desconto");
                dataGridView.Columns.Add("pessoas", "Pessoas");
                dataGridView.Columns.Add("id_cliente", "Cliente ID");
                dataGridView.Columns.Add("hora", "Hora");


                dataGridView.Columns[0].DataPropertyName = "quarto";
                dataGridView.Columns[1].DataPropertyName = "cliente";
                dataGridView.Columns[2].DataPropertyName = "entrada";
                dataGridView.Columns[3].DataPropertyName = "data1";
                dataGridView.Columns[4].DataPropertyName = "frigobar";
                dataGridView.Columns[5].DataPropertyName = "vlr2_diaria";
                dataGridView.Columns[6].DataPropertyName = "desconto";
                dataGridView.Columns[7].DataPropertyName = "pessoas";
                dataGridView.Columns[8].DataPropertyName = "id_cliente";
                dataGridView.Columns[9].DataPropertyName = "hora";



                dataGridView.Columns[0].Width = 30;
                dataGridView.Columns[1].Width = 355;
                dataGridView.Columns[2].Width = 120;
                dataGridView.Columns[3].Width = 100;
                dataGridView.Columns[4].Width = 75;
                dataGridView.Columns[5].Width = 75;
                dataGridView.Columns[6].Width = 75;
                dataGridView.Columns[7].Width = 50;
                dataGridView.Columns[8].Width = 10;
                dataGridView.Columns[9].Width = 0;

                this.dataGridView.DefaultCellStyle.ForeColor = Color.MidnightBlue;
                this.dataGridView.DefaultCellStyle.BackColor = Color.LightBlue;
                this.dataGridView.DefaultCellStyle.Font = new Font("Tahoma", 10);
                // this.dataGridView2.DefaultCellStyle.ForeColor = Color.Blue;
                // this.dataGridView2.DefaultCellStyle.BackColor = Color.Beige;
                // this.dataGridView2.DefaultCellStyle.SelectionForeColor = Color.Yellow;
                // this.dataGridView2.DefaultCellStyle.SelectionBackColor = Color.Black;

            }
        }
        // FIM MOSTRA CLIENTES
        // QUARTOS FRIGOBAR
        void frigobar(string ap)
        {
            mDataSet1 = new DataSet();

            //define string de conexao e cria a conexao
            mConn1 = new MySqlConnection("Persist Security Info=False;server=localhost;database=hotelban_central;uid=hotelban_fabarl;server=localhost;database=hotelban_central;uid=hotelban_fabarl;pwd=281200");


            try
            {
                //abre a conexao
                mConn1.Open();
            }
            catch (System.Exception)
            {
                MessageBox.Show("Houve um Erro Ao Tentar Receber a Lista de Quartos", "[ ERRO QUARTOS ]", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

            //verificva se a conexão esta aberta
            if (mConn1.State == ConnectionState.Open)
            {
                //cria um adapter usando a instrução SQL para acessar a tabela Clientes
                mAdapter1 = new MySqlDataAdapter("SELECT * FROM frigobar WHERE apartamento = '" + ap + "'", mConn1);
                //preenche o dataset via adapter
                mAdapter1.Fill(mDataSet1, "dados");
                //atribui a resultado a propriedade DataSource do DataGrid
                dataGridView1.DataSource = mDataSet1;
                dataGridView1.DataMember = "dados";
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.Columns.Clear();

                dataGridView1.Columns.Add("apartamento", "AP:");
                dataGridView1.Columns.Add("produto", "Produto");
                dataGridView1.Columns.Add("quantidade", "Qtd.");
                dataGridView1.Columns.Add("valor", "Valor");
                dataGridView1.Columns.Add("md5", "Total");
                dataGridView1.Columns.Add("id", "id");

                

                dataGridView1.Columns[0].DataPropertyName = "apartamento";
                dataGridView1.Columns[1].DataPropertyName = "produto";
                dataGridView1.Columns[2].DataPropertyName = "quantidade";
                dataGridView1.Columns[3].DataPropertyName = "valor";
                dataGridView1.Columns[4].DataPropertyName = "md5";
                dataGridView1.Columns[5].DataPropertyName = "id";




                dataGridView1.Columns[0].Width = 20;
                dataGridView1.Columns[1].Width = 100;
                dataGridView1.Columns[2].Width = 30;
                dataGridView1.Columns[3].Width = 50;
                dataGridView1.Columns[4].Width = 50;
                dataGridView1.Columns[5].Width = 0;


                this.dataGridView1.DefaultCellStyle.ForeColor = Color.MidnightBlue;
                this.dataGridView1.DefaultCellStyle.BackColor = Color.LightBlue;
                this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 8);
                // this.dataGridView2.DefaultCellStyle.ForeColor = Color.Blue;
                // this.dataGridView2.DefaultCellStyle.BackColor = Color.Beige;
                // this.dataGridView2.DefaultCellStyle.SelectionForeColor = Color.Yellow;
                // this.dataGridView2.DefaultCellStyle.SelectionBackColor = Color.Black;

            }
        }
        // FIM FRIGOBAR


        public fechar()
        {
            InitializeComponent();
            bt_fechar.Enabled = false;
            bt_up.Enabled = false;
            fim_conta();
        }

        private void fechar_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            linha_atual = int.Parse(e.RowIndex.ToString());
            quarto_selecionado = dataGridView[0, linha_atual].Value.ToString();
            cliente_selecionado = dataGridView[1, linha_atual].Value.ToString();
            entrada_selecionado = dataGridView[2, linha_atual].Value.ToString();
            empresa = dataGridView[3, linha_atual].Value.ToString();
            hora_selecionado = dataGridView[9, linha_atual].Value.ToString();
            diaria_selecionado = dataGridView[5, linha_atual].Value.ToString();
            frigobar_selecionado = dataGridView[4, linha_atual].Value.ToString();
            desconto_selecionado = dataGridView[6, linha_atual].Value.ToString();
            pessoas_selecionado = dataGridView[7, linha_atual].Value.ToString();
            cliente_id = dataGridView[8, linha_atual].Value.ToString();
            tb_quarto.Text = quarto_selecionado;
            tb_nome.Text = cliente_selecionado;
            tb_entrada.Text = entrada_selecionado;
            tb_desconto_valor.Text = desconto_selecionado;
            tb_frigobar.Text = frigobar_selecionado;
            tb_valor.Text = diaria_selecionado;
            tb_hora.Text = hora_selecionado;
            tb_pessoas.Text = pessoas_selecionado;
            DateTime Data = DateTime.Now;
            string DataFormato = Data.ToString("d");
            string HoraFormato = Data.ToString("t");
            tb_saida.Text = DataFormato;
            tb_saida_hora.Text = HoraFormato;
            bt_fechar.Enabled = true;
            bt_up.Enabled = true;

            contas();
           // MessageBox.Show("Hora Retornada " + HoraRetornado + "Dividido por 24 : " + (HoraRetornado / 24) + " + Extra " + ((HoraRetornado / 24) + extra) + "  Vezes " + Convert.ToDouble(tb_valor.Text) + " Igual a= " + (((HoraRetornado / 24)+ extra ) * Convert.ToDouble(tb_valor.Text)));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            contas();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lb_valor_debito.Text != "Débito: 00,00 R$")
            {
                if (MessageBox.Show("Tem certeza que deseja Fechar Está Conta em Débito?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Form fim = new imprimir(tb_quarto.Text, tb_entrada.Text, tb_hora.Text, tb_saida.Text, tb_saida_hora.Text, tb_qtd.Text, tb_valor.Text, tb_frigobar.Text, tb_desconto.Text, tb_desconto_valor.Text, Convert.ToString(por), cliente_id,debito);
                    fim.ShowDialog();
                    mConn0 = new MySqlConnection("Persist Security Info=False;server=localhost;database=hotelban_central;uid=hotelban_fabarl;server=localhost;database=hotelban_central;uid=hotelban_fabarl;pwd=281200");
                    fim_conta();
                    tb_desconto.Text = "Porcentagem";
                    tb_desconto_valor.Text = "0";
                    tb_diarias.Text = "0";
                    tb_frigobar.Text = "0";
                    tb_nome.Text = " ";
                    tb_pagar.Text = "0";
                    tb_saida.Text = "";
                    tb_saida_hora.Text = "";
                    tb_valor.Text = "";
                    tb_quarto.Text = "";
                    tb_qtd.Text = "0";
                    tb_entrada.Text = "";
                    lb_valor_debito.Text = "Débito 00,00 R$";
                    lb_valor_total.Text = "Total: 00,00 R$";
                    lb_valor_troco.Text = "Troco: 00,00 R$";
                    tb_hora.Text = "";
                    tb_pessoas.Text = "0";
                    frigobar("");
                    bt_fechar.Enabled = false;
                    bt_up.Enabled = false;

                }
            }
            else
            {
                // Form fim = new imprimir(tb_quarto.Text, tb_entrada.Text, tb_hora.Text, tb_saida.Text, tb_saida_hora.Text, tb_qtd.Text, tb_valor.Text, tb_frigobar.Text, tb_desconto.Text, tb_desconto_valor.Text, por);
                Form fim = new imprimir(tb_quarto.Text, tb_entrada.Text, tb_hora.Text, tb_saida.Text, tb_saida_hora.Text, tb_qtd.Text, tb_valor.Text, tb_frigobar.Text, tb_desconto.Text, tb_desconto_valor.Text, Convert.ToString(por), cliente_id,debito);
                fim.ShowDialog();
                fim_conta();
                tb_desconto.Text = "Porcentagem";
                tb_desconto_valor.Text = "0";
                tb_diarias.Text = "0";
                tb_frigobar.Text = "0";
                tb_nome.Text = " ";
                tb_pagar.Text = "0";
                tb_saida.Text = "";
                tb_saida_hora.Text = "";
                tb_valor.Text = "";
                tb_quarto.Text = "";
                tb_qtd.Text = "0";
                tb_entrada.Text = "";
                lb_valor_debito.Text = "Débito 00,00 R$";
                lb_valor_total.Text = "Total: 00,00 R$";
                lb_valor_troco.Text = "Troco: 00,00 R$";
                tb_hora.Text = "";
                tb_pessoas.Text = "0";
                frigobar("");
                bt_fechar.Enabled = false;
                bt_up.Enabled = false;
            }
        }
    }
}
