namespace HotelBandeirante
{
    partial class reservas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.conf_reserva = new System.Windows.Forms.Button();
            this.can_reserva = new System.Windows.Forms.Button();
            this.exc_reserva = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pessoas = new System.Windows.Forms.ComboBox();
            this.nome = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saida = new System.Windows.Forms.MaskedTextBox();
            this.entrada = new System.Windows.Forms.MaskedTextBox();
            this.telefone = new System.Windows.Forms.MaskedTextBox();
            this.cadastrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_filtro = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(747, 363);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // conf_reserva
            // 
            this.conf_reserva.Location = new System.Drawing.Point(4, 373);
            this.conf_reserva.Name = "conf_reserva";
            this.conf_reserva.Size = new System.Drawing.Size(109, 42);
            this.conf_reserva.TabIndex = 1;
            this.conf_reserva.Text = "Confirmar Reserva";
            this.conf_reserva.UseVisualStyleBackColor = true;
            this.conf_reserva.Click += new System.EventHandler(this.conf_reserva_Click);
            // 
            // can_reserva
            // 
            this.can_reserva.Location = new System.Drawing.Point(119, 372);
            this.can_reserva.Name = "can_reserva";
            this.can_reserva.Size = new System.Drawing.Size(109, 42);
            this.can_reserva.TabIndex = 2;
            this.can_reserva.Text = "Cancelar Reserva";
            this.can_reserva.UseVisualStyleBackColor = true;
            this.can_reserva.Click += new System.EventHandler(this.can_reserva_Click);
            // 
            // exc_reserva
            // 
            this.exc_reserva.Location = new System.Drawing.Point(234, 372);
            this.exc_reserva.Name = "exc_reserva";
            this.exc_reserva.Size = new System.Drawing.Size(109, 42);
            this.exc_reserva.TabIndex = 3;
            this.exc_reserva.Text = "Excluir Reserva";
            this.exc_reserva.UseVisualStyleBackColor = true;
            this.exc_reserva.Click += new System.EventHandler(this.exc_reserva_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Entrada:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Saida:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(417, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Pessoas:";
            // 
            // pessoas
            // 
            this.pessoas.FormattingEnabled = true;
            this.pessoas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.pessoas.Location = new System.Drawing.Point(473, 18);
            this.pessoas.Name = "pessoas";
            this.pessoas.Size = new System.Drawing.Size(36, 21);
            this.pessoas.TabIndex = 8;
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(52, 19);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(200, 20);
            this.nome.TabIndex = 4;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(52, 48);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(200, 20);
            this.email.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saida);
            this.groupBox1.Controls.Add(this.entrada);
            this.groupBox1.Controls.Add(this.telefone);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.cadastrar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nome);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pessoas);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(4, 421);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 91);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar Reserva";
            // 
            // saida
            // 
            this.saida.Location = new System.Drawing.Point(302, 48);
            this.saida.Mask = "00/00/0000";
            this.saida.Name = "saida";
            this.saida.Size = new System.Drawing.Size(98, 20);
            this.saida.TabIndex = 7;
            this.saida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.saida.ValidatingType = typeof(System.DateTime);
            // 
            // entrada
            // 
            this.entrada.Location = new System.Drawing.Point(302, 18);
            this.entrada.Mask = "00/00/0000";
            this.entrada.Name = "entrada";
            this.entrada.Size = new System.Drawing.Size(98, 20);
            this.entrada.TabIndex = 6;
            this.entrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.entrada.ValidatingType = typeof(System.DateTime);
            // 
            // telefone
            // 
            this.telefone.Location = new System.Drawing.Point(473, 49);
            this.telefone.Mask = "(99) 0000-0000";
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(98, 20);
            this.telefone.TabIndex = 9;
            this.telefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cadastrar
            // 
            this.cadastrar.Location = new System.Drawing.Point(577, 15);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(156, 65);
            this.cadastrar.TabIndex = 10;
            this.cadastrar.Text = "CADASTRAR";
            this.cadastrar.UseVisualStyleBackColor = true;
            this.cadastrar.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(417, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Telefone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(421, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Filtrar Reservas Por:";
            // 
            // cb_filtro
            // 
            this.cb_filtro.FormattingEnabled = true;
            this.cb_filtro.Items.AddRange(new object[] {
            "Em Aberta",
            "Confirmada",
            "Cancelada"});
            this.cb_filtro.Location = new System.Drawing.Point(529, 385);
            this.cb_filtro.Name = "cb_filtro";
            this.cb_filtro.Size = new System.Drawing.Size(121, 21);
            this.cb_filtro.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(656, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "Atualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 518);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_filtro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exc_reserva);
            this.Controls.Add(this.can_reserva);
            this.Controls.Add(this.conf_reserva);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "reservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reservas On-Line";
            this.Load += new System.EventHandler(this.reservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button conf_reserva;
        private System.Windows.Forms.Button can_reserva;
        private System.Windows.Forms.Button exc_reserva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox pessoas;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.MaskedTextBox telefone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox saida;
        private System.Windows.Forms.MaskedTextBox entrada;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_filtro;
        private System.Windows.Forms.Button button1;
    }
}