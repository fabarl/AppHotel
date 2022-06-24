using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace HotelBandeirante
{
    public partial class Form1 : Form
    {
        //private System.Windows.Forms.DataGrid mDataGrid;
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private DataSet mDataSet;

        private MySqlConnection mConn2;
        private MySqlDataAdapter mAdapter2;
        private DataSet mDataSet2;

        private MySqlConnection mConn3;
        private MySqlDataAdapter mAdapter3;
        private DataSet mDataSet3;

        private MySqlConnection mConn4;
        private MySqlDataAdapter mAdapter4;
        private DataSet mDataSet4;

        private MySqlConnection mConn5;
        private MySqlDataAdapter mAdapter5;
        private DataSet mDataSet5;

        int linha_atual;
        string numero_quarto;
        string status;
        string id_frigobar;
        private string total_frigobar;
        private string m_frigobar;
        bool liberar = false;

        public void DatabaseBackup(string ExeLocation, string DBName)
        {
            try
            {
                string tmestr = "";
                tmestr = DBName + "-" + DateTime.Now.ToShortDateString() + ".sql";
                tmestr = tmestr.Replace("/", "-");
                tmestr = "d:/hotel bandeirante/bkp/" + tmestr;
                StreamWriter file = new StreamWriter(tmestr);
                ProcessStartInfo proc = new ProcessStartInfo();
                string cmd = string.Format(@"-u{0} -p{1} -h{2} {3}", "root", "root", "localhost", DBName);
                proc.FileName = ExeLocation;
                proc.RedirectStandardInput = false;
                proc.RedirectStandardOutput = true;
                proc.Arguments = cmd;
                proc.UseShellExecute = false;
                Process p = Process.Start(proc);
                string res;
                res = p.StandardOutput.ReadToEnd();
                file.WriteLine(res);
                p.WaitForExit();
                file.Close();
                MessageBox.Show("Backup Completed");
            }

            catch (IOException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public void Upload(string ftpHost, string remoteFilePath, string localFilePath)
        {
            // O ftpHost deve ser montado da seguinte maneira:
            // ftp://username:password@ipFtpHost:port

            Uri uri = new Uri(ftpHost + "/" + remoteFilePath);

            // Cria o FtpWebRequest com o Uri que montamos
            FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(uri);

            // Por padrão a conexão é mantida depois do comando ser executado, aqui alteramos para a conexão ser fechada.
            request.KeepAlive = false;

            // Especifica o comando para ser executado.
            request.Method = WebRequestMethods.Ftp.UploadFile;

            // Utiliza conexão no modo passivo
            request.UsePassive = true;

            // Especifica o tipo de transferência de dados.
            request.UseBinary = true;

            try
            {
                FileStream fileStream = File.OpenRead(localFilePath);
                Stream stream = request.GetRequestStream();

                // Divide e envia o arquivo por partes.
                int Length = 2048;
                byte[] buffer = new byte[Length];
                int bytesToSend = fileStream.Read(buffer, 0, Length);
                while (bytesToSend > 0)
                {
                    // Envia uma parte do arquivo para o servidor
                    stream.Write(buffer, 0, bytesToSend);
                    // Lê o arquivo e preenche o buffer
                    bytesToSend = fileStream.Read(buffer, 0, Length);
                }
                stream.Close();
                fileStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro Ao Realizar o BKP!");
            }
        }

        //DIARIA
        void calculo()
        {
            MySqlConnection cin = new MySqlConnection("Persist Security Info=False;server=localhost;database=hotelban_central;uid=hotelban_fabarl;server=localhost;database=hotelban_central;uid=hotelban_fabarl;pwd=281200");
            MySqlCommand tt_livre = new MySqlCommand("select * from apartamento where status = 'Livre'", cin);
            MySqlCommand tt_ocupado = new MySqlCommand("select * from apartamento where status = 'Ocupado'", cin);
            MySqlCommand tt_limpeza = new MySqlCommand("select * from apartamento where status = 'Limpando'", cin);

            cin.Open();

            MySqlDataReader tuntun;
            tuntun = tt_livre.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            int tt_hospede = 0;
            int tt_livre_n = 0;
            while (tuntun.Read())
            {
                tt_livre_n = tt_livre_n + 1;
            }
            cin.Close();


            MySqlDataReader du;
            MySqlCommand bum = cin.CreateCommand();
            bum.CommandText = "select * from apartamento where status = 'Ocupado'";

            cin.Open();
            du = bum.ExecuteReader();
            while(du.Read()){

            tt_hospede = tt_hospede + Convert.ToInt32(du["pessoas"].ToString());

                    }

            cin.Close();
            cin.Open();
            MySqlDataReader tonton;
            tonton = tt_ocupado.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
             
            int tt_ocupado_n = 0;
            int tt_limpeza_n = 0;
            while (tonton.Read())
            {

                tt_ocupado_n = tt_ocupado_n + 1;
            }
            cin.Close();
            cin.Open();
            MySqlDataReader tantan;
 
            tantan = tt_limpeza.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            
            while (tantan.Read())
            {
                tt_limpeza_n = tt_limpeza_n + 1;
            }
            cin.Close();
            lb_livre.Text = "Ap. Livres: "+Convert.ToString(tt_livre_n);
            lb_ocupado.Text = "Ap. Ocupado: " + Convert.ToString(tt_ocupado_n);
            lb_limpeza.Text = "Ap. p/ Limpeza: " + Convert.ToString(tt_limpeza_n);
            lb_hospedes.Text = "Hospedes: " + Convert.ToString(tt_hospede);

        }
        //FIM DIARIA

             void atualiza_reserva()
        {
            if (liberar == true)
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
                    button1.Enabled = true;
                    button7.Enabled = false;
                    liberar = false;
                }

                //verificva se a conexão esta aberta
                if (mConn.State == ConnectionState.Open)
                {
                    //cria um adapter usando a instrução SQL para acessar a tabela Clientes
                    mAdapter = new MySqlDataAdapter("SELECT * FROM reserva WHERE status = 'Aguardando Hotel' order By id DESC LIMIT 4", mConn);
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
                    dataGridView1.Columns.Add("id", "id");
                    dataGridView1.Columns.Add("n_id", "id");
                    dataGridView1.Columns[0].DataPropertyName = "nome";
                    dataGridView1.Columns[1].DataPropertyName = "email";
                    dataGridView1.Columns[2].DataPropertyName = "telefone";
                    dataGridView1.Columns[3].DataPropertyName = "entrada";
                    dataGridView1.Columns[4].DataPropertyName = "saida";
                    dataGridView1.Columns[5].DataPropertyName = "id";
                    dataGridView1.Columns[6].DataPropertyName = "n_id";



                    dataGridView1.Columns[0].Width = 200;
                    dataGridView1.Columns[1].Width = 200;
                    dataGridView1.Columns[2].Width = 75;
                    dataGridView1.Columns[3].Width = 75;
                    dataGridView1.Columns[4].Width = 75;
                    dataGridView1.Columns[5].Width = 0;
                    dataGridView1.Columns[6].Width = 0;
                }
            }
        }

        //QUARTOS
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
                     MessageBox.Show("Houve um Erro Ao Tentar Receber a Lista de Quartos", "[ ERRO QUARTOS ]", MessageBoxButtons.OK, MessageBoxIcon.Question);
                 }

                 //verificva se a conexão esta aberta
                 if (mConn2.State == ConnectionState.Open)
                 {
                     //cria um adapter usando a instrução SQL para acessar a tabela Clientes
                     mAdapter2 = new MySqlDataAdapter("SELECT * FROM apartamento WHERE status = 'Livre'", mConn2);
                     //preenche o dataset via adapter
                     mAdapter2.Fill(mDataSet2, "abrirquarto");
                     //atribui a resultado a propriedade DataSource do DataGrid
                     dataGridView2.DataSource = mDataSet2;
                     dataGridView2.DataMember = "abrirquarto";
                     dataGridView2.AutoGenerateColumns = false;
                     dataGridView2.Columns.Clear();

                     dataGridView2.Columns.Add("quarto", "Apartamento");
                     dataGridView2.Columns.Add("descricao", "Descricao");
                     dataGridView2.Columns.Add("valordiaria", "Valor Diaria");
                     dataGridView2.Columns.Add("Sem_Valor", "Selecionar");
                     dataGridView2.Columns.Add("status", "Status");
                     dataGridView2.Columns[0].DataPropertyName = "quarto";
                     dataGridView2.Columns[1].DataPropertyName = "descricao";
                     dataGridView2.Columns[2].DataPropertyName = "valordiaria";
                     dataGridView2.Columns[3].DataPropertyName = "Sem_valor";
                     dataGridView2.Columns[4].DataPropertyName = "status";



                     dataGridView2.Columns[0].Width = 70;
                     dataGridView2.Columns[1].Width = 320;
                     dataGridView2.Columns[2].Width = 75;
                     dataGridView2.Columns[3].Width = 75;
                     dataGridView2.Columns[4].Width = 1;

                     this.dataGridView2.DefaultCellStyle.ForeColor = Color.MidnightBlue;
                     this.dataGridView2.DefaultCellStyle.BackColor = Color.LightBlue;
                     this.dataGridView2.DefaultCellStyle.Font = new Font("Tahoma", 10);
                    // this.dataGridView2.DefaultCellStyle.ForeColor = Color.Blue;
                    // this.dataGridView2.DefaultCellStyle.BackColor = Color.Beige;
                    // this.dataGridView2.DefaultCellStyle.SelectionForeColor = Color.Yellow;
                    // this.dataGridView2.DefaultCellStyle.SelectionBackColor = Color.Black;

                 }
             }

        // FIM QUARTOS
        // QUARTOS OCUPADOS

             void quartos_ocupados()
             {
                 mDataSet3 = new DataSet();

                 //define string de conexao e cria a conexao
                 mConn3 = new MySqlConnection("Persist Security Info=False;server=localhost;database=hotelban_central;uid=hotelban_fabarl;server=localhost;database=hotelban_central;uid=hotelban_fabarl;pwd=281200");

                 try
                 {
                     //abre a conexao
                     mConn3.Open();
                 }
                 catch (System.Exception)
                 {
                     MessageBox.Show("Houve um Erro Ao Tentar Receber a Lista de Quartos", "[ ERRO QUARTOS ]", MessageBoxButtons.OK, MessageBoxIcon.Question);
                 }

                 //verificva se a conexão esta aberta
                 if (mConn3.State == ConnectionState.Open)
                 {
                     //cria um adapter usando a instrução SQL para acessar a tabela Clientes
                     mAdapter3 = new MySqlDataAdapter("SELECT * FROM apartamento WHERE status = 'Ocupado'", mConn3);
                     //preenche o dataset via adapter
                     mAdapter3.Fill(mDataSet3, "qp");
                     //atribui a resultado a propriedade DataSource do DataGrid
                     dataGridView3.DataSource = mDataSet3;
                     dataGridView3.DataMember = "qp";
                     dataGridView3.AutoGenerateColumns = false;
                     dataGridView3.Columns.Clear();

                     dataGridView3.Columns.Add("quarto", "AP:");
                     dataGridView3.Columns.Add("cliente", "Hospede");
                     dataGridView3.Columns.Add("entrada", "Data Ent.");
                     dataGridView3.Columns.Add("vlr2_diaria", "Valor");
                     dataGridView3.Columns.Add("pessoas", "Pes");
                     dataGridView3.Columns.Add("status", "Status");

                     dataGridView3.Columns[0].DataPropertyName = "quarto";
                     dataGridView3.Columns[1].DataPropertyName = "Cliente";
                     dataGridView3.Columns[2].DataPropertyName = "entrada";
                     dataGridView3.Columns[3].DataPropertyName = "vlr2_diaria";
                     dataGridView3.Columns[4].DataPropertyName = "pessoas";
                     dataGridView3.Columns[5].DataPropertyName = "status";

                     dataGridView3.Columns[0].Width = 25;
                     dataGridView3.Columns[1].Width = 140;
                     dataGridView3.Columns[2].Width = 90;
                     dataGridView3.Columns[3].Width = 50;
                     dataGridView3.Columns[4].Width = 40;
                     dataGridView3.Columns[5].Width = 1;

                     this.dataGridView3.DefaultCellStyle.ForeColor = Color.MidnightBlue;
                     this.dataGridView3.DefaultCellStyle.BackColor = Color.LightBlue;
                     this.dataGridView3.DefaultCellStyle.Font = new Font("Tahoma", 8);
                     // this.dataGridView2.DefaultCellStyle.ForeColor = Color.Blue;
                     // this.dataGridView2.DefaultCellStyle.BackColor = Color.Beige;
                     // this.dataGridView2.DefaultCellStyle.SelectionForeColor = Color.Yellow;
                     // this.dataGridView2.DefaultCellStyle.SelectionBackColor = Color.Black;

                 }
             }

        // FIM QUARTOS OCUPADOS
        // QUARTOS LIMPEZA
             void quartos_limpeza()
             {
                 mDataSet4 = new DataSet();

                 //define string de conexao e cria a conexao
                 mConn4 = new MySqlConnection("Persist Security Info=False;server=localhost;database=hotelban_central;uid=hotelban_fabarl;server=localhost;database=hotelban_central;uid=hotelban_fabarl;pwd=281200");

                 try
                 {
                     //abre a conexao
                     mConn4.Open();
                 }
                 catch (System.Exception)
                 {
                     MessageBox.Show("Houve um Erro Ao Tentar Receber a Lista de Quartos", "[ ERRO QUARTOS ]", MessageBoxButtons.OK, MessageBoxIcon.Question);
                 }

                 //verificva se a conexão esta aberta
                 if (mConn4.State == ConnectionState.Open)
                 {
                     //cria um adapter usando a instrução SQL para acessar a tabela Clientes
                     mAdapter4 = new MySqlDataAdapter("SELECT * FROM apartamento WHERE status = 'Limpando'", mConn4);
                     //preenche o dataset via adapter
                     mAdapter4.Fill(mDataSet4, "qp");
                     //atribui a resultado a propriedade DataSource do DataGrid
                     dataGridView4.DataSource = mDataSet4;
                     dataGridView4.DataMember = "qp";
                     dataGridView4.AutoGenerateColumns = false;
                     dataGridView4.Columns.Clear();

                     dataGridView4.Columns.Add("quarto", "AP:");
                     dataGridView4.Columns.Add("descricao", "Descricao");
                     dataGridView4.Columns.Add("saida", "Saida");

                     dataGridView4.Columns[0].DataPropertyName = "quarto";
                     dataGridView4.Columns[1].DataPropertyName = "descricao";
                     dataGridView4.Columns[2].DataPropertyName = "saida";

                     dataGridView4.Columns[0].Width = 40;
                     dataGridView4.Columns[1].Width = 220;
                     dataGridView4.Columns[2].Width = 90;

                     this.dataGridView4.DefaultCellStyle.ForeColor = Color.MidnightBlue;
                     this.dataGridView4.DefaultCellStyle.BackColor = Color.LightBlue;
                     this.dataGridView4.DefaultCellStyle.Font = new Font("Tahoma", 8);
                     // this.dataGridView2.DefaultCellStyle.ForeColor = Color.Blue;
                     // this.dataGridView2.DefaultCellStyle.BackColor = Color.Beige;
                     // this.dataGridView2.DefaultCellStyle.SelectionForeColor = Color.Yellow;
                     // this.dataGridView2.DefaultCellStyle.SelectionBackColor = Color.Black;

                 }
             }
        // FIM QUARTO LIMPEZAS
             // QUARTOS FRIGOBAR
             void frigobar()
             {
                 mDataSet5 = new DataSet();

                 //define string de conexao e cria a conexao
                 mConn5 = new MySqlConnection("Persist Security Info=False;server=localhost;database=hotelban_central;uid=hotelban_fabarl;server=localhost;database=hotelban_central;uid=hotelban_fabarl;pwd=281200");

                 try
                 {
                     //abre a conexao
                     mConn5.Open();
                 }
                 catch (System.Exception)
                 {
                     MessageBox.Show("Houve um Erro Ao Tentar Receber a Lista de Quartos", "[ ERRO QUARTOS ]", MessageBoxButtons.OK, MessageBoxIcon.Question);
                 }

                 //verificva se a conexão esta aberta
                 if (mConn5.State == ConnectionState.Open)
                 {
                     //cria um adapter usando a instrução SQL para acessar a tabela Clientes
                     mAdapter5 = new MySqlDataAdapter("SELECT * FROM frigobar WHERE apartamento = '"+fri_apartamento.Text+"'", mConn5);
                     //preenche o dataset via adapter
                     mAdapter5.Fill(mDataSet5, "fri");
                     //atribui a resultado a propriedade DataSource do DataGrid
                     dataGridView5.DataSource = mDataSet5;
                     dataGridView5.DataMember = "fri";
                     dataGridView5.AutoGenerateColumns = false;
                     dataGridView5.Columns.Clear();

                     dataGridView5.Columns.Add("apartamento", "AP:");
                     dataGridView5.Columns.Add("produto", "Produto");
                     dataGridView5.Columns.Add("quantidade", "Quantidade");
                     dataGridView5.Columns.Add("valor", "Valor");
                     dataGridView5.Columns.Add("md5", "Total");
                     dataGridView5.Columns.Add("id", "id");
                     dataGridView5.Columns.Add("id_frigobar", "id");

                     dataGridView5.Columns[0].DataPropertyName = "apartamento";
                     dataGridView5.Columns[1].DataPropertyName = "produto";
                     dataGridView5.Columns[2].DataPropertyName = "quantidade";
                     dataGridView5.Columns[3].DataPropertyName = "valor";
                     dataGridView5.Columns[4].DataPropertyName = "md5";
                     dataGridView5.Columns[5].DataPropertyName = "id";
                     dataGridView5.Columns[6].DataPropertyName = "id_frigobar";


                     dataGridView5.Columns[0].Width = 40;
                     dataGridView5.Columns[1].Width = 145;
                     dataGridView5.Columns[2].Width = 65;
                     dataGridView5.Columns[3].Width = 50;
                     dataGridView5.Columns[4].Width = 50;
                     dataGridView5.Columns[5].Width = 0;
                     dataGridView5.Columns[6].Width = 0;

                     this.dataGridView5.DefaultCellStyle.ForeColor = Color.MidnightBlue;
                     this.dataGridView5.DefaultCellStyle.BackColor = Color.LightBlue;
                     this.dataGridView5.DefaultCellStyle.Font = new Font("Tahoma", 8);
                     // this.dataGridView2.DefaultCellStyle.ForeColor = Color.Blue;
                     // this.dataGridView2.DefaultCellStyle.BackColor = Color.Beige;
                     // this.dataGridView2.DefaultCellStyle.SelectionForeColor = Color.Yellow;
                     // this.dataGridView2.DefaultCellStyle.SelectionBackColor = Color.Black;

                 }
             }
             // FIM FRIGOBAR
             
        public Form1()
        {
            InitializeComponent();
            if (MessageBox.Show("Iniciar Com Verificação de Reservas Online?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                liberar = true;
                button1.Enabled = false;
                button7.Enabled = true;
                atualiza_reserva();
              
               
            }
            else
            {
                liberar = false;
                button1.Enabled = true;
                button7.Enabled = false;
                
            }
            
            atualiza_reserva();
            atualiza_quartos();
            quartos_ocupados();
            quartos_limpeza();
            frigobar();
            calculo();

        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            Form exit = new fechar();
            exit.ShowDialog();

                atualiza_reserva();

           atualiza_quartos();
           quartos_ocupados();
           quartos_limpeza();
           frigobar();
           calculo();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {

            liberar = true;
            button1.Enabled = false;
            button7.Enabled = true;
            atualiza_reserva();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
          
        }

        private void hospedarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void frigobarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Quarto_1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cadastrarHospedesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cad_clientes = new cad_cliente();

           cad_clientes.ShowDialog();

               atualiza_reserva();
    
           atualiza_quartos();
           quartos_ocupados();
           quartos_limpeza();
           frigobar();
           calculo();

        }

        private void cadastrarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cad_produto = new produto();

            cad_produto.ShowDialog();

                atualiza_reserva();

            atualiza_quartos();
            quartos_ocupados();
            quartos_limpeza();
            frigobar();
            calculo();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            linha_atual = int.Parse(e.RowIndex.ToString());
            numero_quarto = dataGridView2[0, linha_atual].Value.ToString();
            status = dataGridView2[4, linha_atual].Value.ToString();
            if (status == "Livre")
            {
                Form hosp = new hospedar(numero_quarto);

                hosp.ShowDialog();

                    atualiza_reserva();

                atualiza_quartos();
                quartos_ocupados();
                calculo();
            }
            else
            {
                MessageBox.Show("Este Apartamento Já Está em Uso", "[ERRO]", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
             
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            linha_atual = int.Parse(e.RowIndex.ToString());
           string num_quarto = dataGridView3[0, linha_atual].Value.ToString();
           fri_apartamento.Text = num_quarto;
            frigobar();
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            linha_atual = int.Parse(e.RowIndex.ToString());
           string num = dataGridView4[0, linha_atual].Value.ToString();
                string query = "UPDATE apartamento SET status = 'Livre' WHERE quarto='" + num + "'";
                MySqlConnection con = new MySqlConnection("Persist Security Info=False;server=localhost;database=hotelban_central;uid=hotelban_fabarl;server=localhost;database=hotelban_central;uid=hotelban_fabarl;pwd=281200");
                MySqlCommand command = new MySqlCommand(query, con);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                quartos_limpeza();
                atualiza_quartos();
                calculo();
         }

        private void button5_Click_2(object sender, EventArgs e)
        {
            if (fri_apartamento.Text == "")
            {
                MessageBox.Show("Informe Um apartamento para Visualizar seu Frigobar", "[ERRO]", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           
            }
            else
            {
                string btquery = "SELECT * FROM apartamento WHERE quarto='" + fri_apartamento.Text + "'";
                MySqlConnection cont = new MySqlConnection("Persist Security Info=False;server=localhost;database=hotelban_central;uid=hotelban_fabarl;server=localhost;database=hotelban_central;uid=hotelban_fabarl;pwd=281200");
                MySqlDataReader drt;
                MySqlCommand commandt = cont.CreateCommand();
                commandt.CommandText = btquery;

                cont.Open();
                drt = commandt.ExecuteReader();
                drt.Read();

               string rt_status = drt["status"].ToString();
  
         
                if (rt_status == "Ocupado")
                {
                    frigobar();
                }else
                {
                    MessageBox.Show("Opção Indisponivel para Apartamentos Livre ou em Limpesa!", "[ERRO]", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           
                }
                calculo();
            }
        }
       
        private void excluirProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = (dataGridView5.CurrentCell.RowIndex);

            this.dataGridView5.Rows[rowIndex].Selected = true;

            string Col1 = dataGridView5[5, dataGridView5.CurrentCellAddress.Y].Value.ToString();
            string total_a_retirar = dataGridView5[4, dataGridView5.CurrentCellAddress.Y].Value.ToString();
            string t_frigobar = dataGridView5[6, dataGridView5.CurrentCellAddress.Y].Value.ToString();
            double resultado;

            string que = "SELECT * FROM apartamento WHERE quarto='" + fri_apartamento.Text + "'";
            MySqlConnection conect = new MySqlConnection("Persist Security Info=False;server=localhost;database=hotelban_central;uid=hotelban_fabarl;server=localhost;database=hotelban_central;uid=hotelban_fabarl;pwd=281200");
            MySqlDataReader dr;
            MySqlCommand comman = conect.CreateCommand();
            comman.CommandText = que;

            conect.Open();
            dr = comman.ExecuteReader();
            dr.Read();

            total_frigobar = dr["frigobar"].ToString();
            m_frigobar =dr["id_frigobar"].ToString();
            conect.Close();
            resultado = Convert.ToDouble(total_frigobar) - Convert.ToDouble(total_a_retirar);
            if (resultado < 0)
                resultado = resultado * (-1);

            string query = "DELETE FROM frigobar WHERE id = '" + Col1 + "'";
            string control = "UPDATE historico_frigobar SET status = 'Excluido' WHERE id = '" + t_frigobar + "'";
            string ult = "UPDATE apartamento SET frigobar = '"+resultado+"' WHERE quarto = '" + fri_apartamento.Text + "'";
            MySqlConnection con = new MySqlConnection("Persist Security Info=False;server=localhost;database=hotelban_central;uid=hotelban_fabarl;server=localhost;database=hotelban_central;uid=hotelban_fabarl;pwd=281200");
            MySqlCommand command = new MySqlCommand(query, con);
            MySqlCommand sun = new MySqlCommand(ult, con);
            MySqlCommand controle = new MySqlCommand(control, con);
            con.Open();
            // TESTANDO CALCULO FRIGOBAR MessageBox.Show("Total Frigobar (" + total_frigobar + ")- Total a Retirar (" + total_a_retirar + ") = Resultado (" + resultado + ")");
            command.ExecuteNonQuery();
            sun.ExecuteNonQuery();
            controle.ExecuteNonQuery();
            con.Close();
            frigobar();
            calculo();
       }

        private void excluirTodosOsProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string que = "SELECT * FROM apartamento WHERE quarto='" + fri_apartamento.Text + "'";
            MySqlConnection conect = new MySqlConnection("Persist Security Info=False;server=localhost;database=hotelban_central;uid=hotelban_fabarl;server=localhost;database=hotelban_central;uid=hotelban_fabarl;pwd=281200");
            MySqlDataReader dr;
            MySqlCommand comman = conect.CreateCommand();
            comman.CommandText = que;

            conect.Open();
            dr = comman.ExecuteReader();
            dr.Read();
           string x_frigobar = dr["id_frigobar"].ToString();
            conect.Close();
            string query = "DELETE FROM frigobar WHERE apartamento = '" + fri_apartamento.Text + "'";
            string avis = "UPDATE historico_frigobar SET status = 'Excluido' WHERE id_frigobar = '" + x_frigobar + "'";
            string ult = "UPDATE apartamento SET frigobar = '0' WHERE quarto = '" + fri_apartamento.Text + "'";
            MySqlConnection con = new MySqlConnection("Persist Security Info=False;server=localhost;database=hotelban_central;uid=hotelban_fabarl;server=localhost;database=hotelban_central;uid=hotelban_fabarl;pwd=281200");
            MySqlCommand command = new MySqlCommand(query, con);
            MySqlCommand cmd = new MySqlCommand(ult, con);
            con.Open();
            command.ExecuteNonQuery();
            cmd.ExecuteNonQuery();
            con.Close();
            frigobar();
            calculo();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sunsun = "SELECT * FROM apartamento WHERE quarto='" + fri_apartamento.Text + "'";
            MySqlConnection conm = new MySqlConnection("Persist Security Info=False;server=localhost;database=hotelban_central;uid=hotelban_fabarl;server=localhost;database=hotelban_central;uid=hotelban_fabarl;pwd=281200");
            MySqlDataReader du;
            MySqlCommand clin = conm.CreateCommand();
            clin.CommandText = sunsun;

            conm.Open();
            du = clin.ExecuteReader();
            du.Read();

            string ru_status = du["status"].ToString();
            string ru_fri = du["id_frigobar"].ToString();


            if (ru_status == "Ocupado")
            {
                Form frig = new frigobar(fri_apartamento.Text);

                frig.ShowDialog();
                frigobar();
            }
            else
            {
                MessageBox.Show("Opção Indisponivel para Apartamentos Livre ou em Limpesa!", "[ERRO]", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            calculo();

        }

        private void verClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form exbt = new up_ap();
            exbt.ShowDialog();
            atualiza_quartos();
            calculo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form open = new procurar_cliente();
            open.ShowDialog();
            calculo();
        }

        private void transferirHospedeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = (dataGridView3.CurrentCell.RowIndex);

            this.dataGridView3.Rows[rowIndex].Selected = true;

            string qto = dataGridView3[0, dataGridView3.CurrentCellAddress.Y].Value.ToString();

            int bumIndex = (dataGridView2.CurrentCell.RowIndex);

            this.dataGridView2.Rows[bumIndex].Selected = true;

            string qto2 = dataGridView2[0, dataGridView2.CurrentCellAddress.Y].Value.ToString();
            if (MessageBox.Show("Você está Transferindo do Quarto [" + qto + "] Para o Quarto [" + qto2 + "] ! Continuar?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                if (qto != "")
                {
                    //string total_a_retirar = dataGridView3[4, dataGridView5.CurrentCellAddress.Y].Value.ToString();
                    string sunsun = "SELECT * FROM apartamento WHERE quarto='" + qto + "'";
                    MySqlConnection conm = new MySqlConnection("Persist Security Info=False;server=localhost;database=hotelban_central;uid=hotelban_fabarl;server=localhost;database=hotelban_central;uid=hotelban_fabarl;pwd=281200");
                    MySqlDataReader du;
                    MySqlCommand clin = conm.CreateCommand();
                    clin.CommandText = sunsun;

                    conm.Open();
                    du = clin.ExecuteReader();
                    du.Read();

                    string u_cliente = du["cliente"].ToString();
                    string u_frigobar = du["frigobar"].ToString();
                    string u_entrada = du["entrada"].ToString();
                    string u_desconto = du["desconto"].ToString();
                    string u_hora = du["hora"].ToString();
                    string u_vlr2_diaria = du["vlr2_diaria"].ToString();
                    string u_id_cliente = du["id_cliente"].ToString();
                    string u_pessoas = du["pessoas"].ToString();
                    id_frigobar = du["id_frigobar"].ToString();
                    conm.Close();
                    string query = "UPDATE apartamento SET pessoas = '"+u_pessoas+"', id_frigobar = '"+id_frigobar+"', status = 'Ocupado',cliente = '" + u_cliente + "',frigobar = '" + u_frigobar + "',entrada = '" + u_entrada + "',desconto = '" + u_desconto + "',hora = '" + u_hora + "',vlr2_diaria = '" + u_vlr2_diaria + "',id_cliente = '" + u_id_cliente + "' WHERE quarto='" + qto2 + "'";
                    string query2 = "UPDATE apartamento SET pessoas = '0', id_frigobar = '0', status = 'Limpando',cliente = '0',frigobar = '0',entrada = '0',desconto = '0',hora = '00:00',vlr2_diaria = '0',id_cliente = '0' WHERE quarto='" + qto + "'";
                    string query32 = "UPDATE frigobar SET apartamento = '" + qto2 + "' WHERE apartamento='" + qto + "'";

                    MySqlConnection con = new MySqlConnection("Persist Security Info=False;server=localhost;database=hotelban_central;uid=hotelban_fabarl;server=localhost;database=hotelban_central;uid=hotelban_fabarl;pwd=281200");
                    MySqlCommand command = new MySqlCommand(query, con);
                    MySqlCommand subb = new MySqlCommand(query2, con);
                    MySqlCommand fri = new MySqlCommand(query32, con);
                    con.Open();
                    command.ExecuteNonQuery();
                    subb.ExecuteNonQuery();
                    fri.ExecuteNonQuery();
                    con.Close();

                        atualiza_reserva();
 
                    atualiza_quartos();
                    quartos_ocupados();
                    quartos_limpeza();
                    MessageBox.Show("Hospede transferido com sucesso!");
                }
                else
                {
                    MessageBox.Show("Impossivel Transferir, Selecione o Apartamento Ocupado Antes!");
                }
            }
            calculo();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void hospedarNesteApartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
/*

            int rowIndex = (dataGridView2.CurrentCell.RowIndex);

            this.dataGridView2.Rows[rowIndex].Selected = true;

            int linha_atual = Convert.ToInt32(dataGridView2[0, dataGridView2.CurrentCellAddress.Y].Value.ToString());
            string num_quarto = Convert.ToString(linha_atual);
            string estatus = dataGridView2[4, dataGridView2.CurrentCellAddress.Y].Value.ToString();

            if (estatus == "Livre")
            {
                Form hosp = new hospedar(num_quarto);

                hosp.ShowDialog();
                if (autoverificar.Enabled == false)
                {
                    atualiza_reserva();
                }
                atualiza_quartos();
                quartos_ocupados();
                calculo();
            }
            else
            {
                MessageBox.Show("Este Apartamento Já Está em Uso - Linha Atual"+linha_atual, "[ERRO]", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //string total_a_retirar = dataGridView5[4, dataGridView5.CurrentCellAddress.Y].Value.ToString();
 * */
        }

        private void historicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form controle = new historico_diaria();

            controle.ShowDialog();
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            liberar = false;
            button1.Enabled = true;
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form reservas = new reservas();

            reservas.ShowDialog();

            atualiza_reserva();

            atualiza_quartos();
            quartos_ocupados();
            quartos_limpeza();
            frigobar();
            calculo();
        }
      
     }
   
}
