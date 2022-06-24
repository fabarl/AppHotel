using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;
using System.IO; 

namespace HotelBandeirante
{
    public partial class imprimir : Form
    {
        private MySqlConnection fConn;
        private string nome;
        private string endereco;
        private string telefone;
        private string empresa;
        private string n_quarto;
        private string d_entrada;
        private string d_entrada_hora;
        private string d_saida;
        private string d_saida_hora;
        private string q_dias;
        private string v_dia;
        private string v_frigobar;
        private string m_desconto;
        private string v_desconto;
        private string v_total;
        private string cli_id;
        private string debito;
       // private int total_frigobar;

        void conectar()
        {
             string que = "SELECT * FROM apartamento WHERE quarto='" + n_quarto + "'";
            MySqlConnection conect = new MySqlConnection("Persist Security Info=False;server=localhost;database=hotelban_central;uid=hotelban_fabarl;server=localhost;database=hotelban_central;uid=hotelban_fabarl;pwd=281200");
            MySqlDataReader dru;
            MySqlCommand comman = conect.CreateCommand();
            comman.CommandText = que;

            conect.Open();
            dru = comman.ExecuteReader();
            dru.Read();
            string m_frigobar = dru["id_frigobar"].ToString();
            conect.Close();
            fConn = new MySqlConnection("Persist Security Info=False;server=localhost;database=hotelban_central;uid=hotelban_fabarl;server=localhost;database=hotelban_central;uid=hotelban_fabarl;pwd=281200");
            string query = "SELECT * FROM clientes WHERE id='" + cli_id + "'";
            
            fConn.Open();
            MySqlDataReader dr;
            MySqlCommand command = fConn.CreateCommand();
            command.CommandText = query;
            dr = command.ExecuteReader();
            dr.Read();

            nome = dr["nome"].ToString();
            telefone = dr["telefone"].ToString();
            endereco = dr["endereco"].ToString();
            empresa = dr["empresa"].ToString();
            fConn.Close();
            fConn.Open();

            MySqlCommand upd = new MySqlCommand("UPDATE historico SET debito  = '" + debito + "', vlr_frigobar = '" + v_frigobar + "', hora_saida  = '" + d_saida_hora + "', hora_entrada = '" + d_entrada_hora + "', apartamento = '" + n_quarto + "', cliente ='" + nome + "', data = '" + d_entrada + "', vlr_diaria='" + v_dia + "', diarias = '" + q_dias + "', valor_total = '" + v_total + "', saida = '" + d_saida + "', desconto = '" + v_desconto + m_desconto + "', id_cliente = '" + cli_id + "', saida_calc = '" + System.DateTime.Parse(d_saida).ToString("yyyy-MM-dd") + "' WHERE id = '" + m_frigobar + "'", fConn);
            //MessageBox.Show("UPDATE historico SET entrada = '"+d_entrada+"', debito  = '" + debito + "', vlr_frigobar = '" + v_frigobar + "', hora_saida  = '" + d_saida_hora + "', hora_entrada = '" + d_entrada_hora + "', apartamento = '" + n_quarto + "', cliente ='" + nome + "', data = '" + d_entrada + "', vlr_diaria='" + v_dia + "', diarias = '" + q_dias + "', valor_total = '" + v_total + "', saida = '" + d_saida + "', desconto = '" + v_desconto + m_desconto + "', id_cliente = '" + cli_id + "' WHERE id = '" + m_frigobar);
            upd.ExecuteNonQuery();


            fConn.Close();

           



            //string avis = "UPDATE historico_frigobar SET status = 'Excluido' WHERE id_frigobar = '" + m_frigobar + "'";
            string cool = "DELETE FROM frigobar WHERE apartamento = '" + n_quarto + "'";
            string ult = "UPDATE apartamento SET status = 'Limpando', frigobar = '0', cliente = '0', entrada = '0', saida = '" + d_saida + "', vlr2_diaria = '0', usado = '0', totaldia='0', desconto = '0', obs = '0', hora = '0', id_cliente = '0', dddia='0', md5 = '0', hora2 = 'nenhuma', id_frigobar = '0' WHERE quarto='" + n_quarto + "'";
                
            MySqlConnection con = new MySqlConnection("Persist Security Info=False;server=localhost;database=hotelban_central;uid=hotelban_fabarl;server=localhost;database=hotelban_central;uid=hotelban_fabarl;pwd=281200");
            MySqlCommand cod = new MySqlCommand(cool, con);
            MySqlCommand cmd = new MySqlCommand(ult, con);
            //MySqlCommand umr = new MySqlCommand(avis, con);
            con.Open();
            cod.ExecuteNonQuery();
           // umr.ExecuteNonQuery();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        void salva_txt()
        {
            File.Delete("nota.txt");
            string nome_arquivo = "nota.txt";
            if (!System.IO.File.Exists(nome_arquivo))
                System.IO.File.Create(nome_arquivo).Close();
            System.IO.TextWriter arquivo = System.IO.File.AppendText(nome_arquivo);
            arquivo.WriteLine(" ============================================================");
            arquivo.WriteLine("                                             HOTEL BANDEIRANTE ");
            arquivo.WriteLine("           _________________________________________");
            arquivo.WriteLine("                  Av. 9 de Maio Centro de Juina - MT CEP 78320-00");
            arquivo.WriteLine("           Fone: (66)3566-1851 E-mail: reserva@hotelbandeirante.com.br");
            arquivo.WriteLine("                                  www.hotelbandeirante.com.br ");
            arquivo.WriteLine("");
            arquivo.WriteLine("       [Dados do Cliente]");
            arquivo.WriteLine("");
            arquivo.WriteLine("        Nome: " + nome);
            arquivo.WriteLine("        End.: " + endereco);
            arquivo.WriteLine("        Telefone: " + telefone);
            arquivo.WriteLine("        Empresa: " + empresa);
            arquivo.WriteLine("");
            arquivo.WriteLine("       ___________________________________________________");
            arquivo.WriteLine("        [Dados da Hospedagem]");
            arquivo.WriteLine("");
            arquivo.WriteLine("        Apartamento: " + n_quarto);
            arquivo.WriteLine("        Check-IN: " + d_entrada + " " + d_entrada_hora);
            arquivo.WriteLine("        Check-OUT: " + d_saida + " " + d_saida_hora);
            arquivo.WriteLine("");
            arquivo.WriteLine("        Valor da Diaria: " + v_dia + " R$       Diarias: " + q_dias);
            arquivo.WriteLine("");
            arquivo.WriteLine("        Valor Total de Diarias: " + (Convert.ToDouble(v_dia) * Convert.ToDouble(q_dias)) + " R$");
            arquivo.WriteLine("");
            arquivo.WriteLine("        Valor Frigobar: " + v_frigobar+" R$");
            arquivo.WriteLine("");
            arquivo.WriteLine("        Desconto: " + v_desconto + "" + m_desconto);
            arquivo.WriteLine("");
            arquivo.WriteLine("");
            arquivo.WriteLine("                          TOTAL: " + v_total + " R$");
            arquivo.WriteLine("");
            arquivo.WriteLine("                                                                                                                         ");
            arquivo.WriteLine("                                                                                                                        ");
            arquivo.WriteLine("                      Hotel Bandeirantes em Juina - MT ao Seu Dispor!                     ");
            arquivo.WriteLine("                                                                                                                         ");
            arquivo.WriteLine("                                                                                                                         ");

            arquivo.Close();



        }
        public imprimir(string quarto, string entrada,string hora,string saida,string hora_saida,string qtd_dia,string valor_dia,string frigobar,string desconto,string valor_desconto,string valor_total, string id_cli, string vl_debito)
        {
            InitializeComponent();
       n_quarto = quarto;
        d_entrada = entrada;
        d_entrada_hora = hora;
        d_saida = saida;
        d_saida_hora = hora_saida;
        q_dias = qtd_dia;
        v_dia =valor_dia;
        v_frigobar = frigobar;
        v_desconto = valor_desconto;
        v_total = valor_total;
        cli_id = id_cli;
        debito = vl_debito;
        if (debito != "0")
        {
            string ult = "UPDATE clientes SET vlr_debito = '" + debito + "' WHERE id='" + cli_id + "'";

            MySqlConnection con = new MySqlConnection("Persist Security Info=False;server=localhost;database=hotelban_central;uid=hotelban_fabarl;server=localhost;database=hotelban_central;uid=hotelban_fabarl;pwd=281200");
            MySqlCommand cmd = new MySqlCommand(ult, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }
        if (desconto == "Porcentagem")
        {
            m_desconto = "%";
        }
        if (desconto == "Dinheiro")
        {
            m_desconto = "R$";
        }
        conectar();

        salva_txt();
        editor.LoadFile("nota.txt", RichTextBoxStreamType.PlainText);
        }
        
        private void imprimir_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            string texto = this.editor.Text;
           leitor = new StringReader(texto);

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //variaveis usadas para definir as configurações da impressão
            float linhasPorPagina = 0;
            float yPosicao = 0;
            int contador = 0;
            float margemEsquerda = e.MarginBounds.Left;
            float margemSuperior = e.MarginBounds.Top;
            string linha = null;
            Font fonteImpressao = this.editor.Font;
            SolidBrush mCaneta = new SolidBrush(Color.Black);

            // Define o numero de linhas por pagina, usando MarginBounds.
            linhasPorPagina = e.MarginBounds.Height / fonteImpressao.GetHeight(e.Graphics);

            // Itera sobre a string usando StringReader, imprimindo cada linha
            while (contador < linhasPorPagina && ((linha = leitor.ReadLine()) != null))
            {
                // calcula a posicao da proxima linha baseada
                // na altura da fonte de acordo com o dispositivo de impressão
                yPosicao = margemSuperior + (contador * fonteImpressao.GetHeight(e.Graphics));

                // desenha a proxima linha no controle RichTextBox
                e.Graphics.DrawString(linha, fonteImpressao, mCaneta, margemEsquerda, yPosicao, new StringFormat());
                contador++;
            }
            // Verifica se existe mais linhas para imprimir
            if (linha != null)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;

            //libera recursos		
            mCaneta.Dispose();
        }

        public StringReader leitor { get; set; }
    }
}
