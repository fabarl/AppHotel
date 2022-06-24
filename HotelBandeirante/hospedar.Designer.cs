namespace HotelBandeirante
{
    partial class hospedar
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hora = new System.Windows.Forms.MaskedTextBox();
            this.entrada = new System.Windows.Forms.MaskedTextBox();
            this.desconto = new System.Windows.Forms.MaskedTextBox();
            this.descricao = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_pessoas = new System.Windows.Forms.TextBox();
            this.vlr_diaria = new System.Windows.Forms.TextBox();
            this.numero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.telefone = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cb_campo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.tb_procurar = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cadastrar Cliente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.email);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.telefone);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.nome);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 258);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados do Cliente";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.hora);
            this.groupBox1.Controls.Add(this.entrada);
            this.groupBox1.Controls.Add(this.desconto);
            this.groupBox1.Controls.Add(this.descricao);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.tb_pessoas);
            this.groupBox1.Controls.Add(this.vlr_diaria);
            this.groupBox1.Controls.Add(this.numero);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(0, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 139);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Apartamento";
            // 
            // hora
            // 
            this.hora.Location = new System.Drawing.Point(208, 88);
            this.hora.Mask = "00:00";
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(78, 20);
            this.hora.TabIndex = 9;
            this.hora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hora.ValidatingType = typeof(System.DateTime);
            // 
            // entrada
            // 
            this.entrada.Location = new System.Drawing.Point(208, 62);
            this.entrada.Mask = "00/00/0000";
            this.entrada.Name = "entrada";
            this.entrada.Size = new System.Drawing.Size(78, 20);
            this.entrada.TabIndex = 9;
            this.entrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.entrada.ValidatingType = typeof(System.DateTime);
            // 
            // desconto
            // 
            this.desconto.Location = new System.Drawing.Point(72, 85);
            this.desconto.Mask = "99%";
            this.desconto.Name = "desconto";
            this.desconto.Size = new System.Drawing.Size(49, 20);
            this.desconto.TabIndex = 9;
            this.desconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // descricao
            // 
            this.descricao.Enabled = false;
            this.descricao.Location = new System.Drawing.Point(186, 13);
            this.descricao.Multiline = true;
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(100, 46);
            this.descricao.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 178);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Desconto:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 142);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Valor Diaria:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(127, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Descrição:";
            // 
            // tb_pessoas
            // 
            this.tb_pessoas.Location = new System.Drawing.Point(72, 111);
            this.tb_pessoas.Name = "tb_pessoas";
            this.tb_pessoas.Size = new System.Drawing.Size(49, 20);
            this.tb_pessoas.TabIndex = 7;
            this.tb_pessoas.Text = "1";
            this.tb_pessoas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_pessoas.TextChanged += new System.EventHandler(this.tb_pessoas_TextChanged);
            // 
            // vlr_diaria
            // 
            this.vlr_diaria.Location = new System.Drawing.Point(72, 56);
            this.vlr_diaria.Name = "vlr_diaria";
            this.vlr_diaria.Size = new System.Drawing.Size(49, 20);
            this.vlr_diaria.TabIndex = 7;
            this.vlr_diaria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numero
            // 
            this.numero.Enabled = false;
            this.numero.Location = new System.Drawing.Point(72, 23);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(49, 20);
            this.numero.TabIndex = 7;
            this.numero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(129, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Hora Entrada:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Data Entrada:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Pessoas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Desconto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Valor Diaria:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Número:";
            // 
            // email
            // 
            this.email.Enabled = false;
            this.email.Location = new System.Drawing.Point(66, 55);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(220, 20);
            this.email.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // telefone
            // 
            this.telefone.Enabled = false;
            this.telefone.Location = new System.Drawing.Point(66, 87);
            this.telefone.Mask = "(99) 0000-0000";
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(100, 20);
            this.telefone.TabIndex = 3;
            this.telefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "E-Mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Telefone:";
            // 
            // nome
            // 
            this.nome.Enabled = false;
            this.nome.Location = new System.Drawing.Point(66, 23);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(220, 20);
            this.nome.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(21, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "OBS: As Diarias Terminan ao Meio Dia!";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(313, 216);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 58);
            this.button4.TabIndex = 11;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(13, 335);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(448, 150);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cb_campo
            // 
            this.cb_campo.FormattingEnabled = true;
            this.cb_campo.Items.AddRange(new object[] {
            "Nome",
            "Email",
            "Telefone",
            "Empresa",
            "CPF",
            "RG"});
            this.cb_campo.Location = new System.Drawing.Point(78, 306);
            this.cb_campo.Name = "cb_campo";
            this.cb_campo.Size = new System.Drawing.Size(74, 21);
            this.cb_campo.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(10, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Procurar por:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(372, 305);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "Procurar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(130, 488);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(225, 39);
            this.button7.TabIndex = 15;
            this.button7.Text = "Escolher Cliente Selecionado";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // tb_procurar
            // 
            this.tb_procurar.Location = new System.Drawing.Point(165, 307);
            this.tb_procurar.Name = "tb_procurar";
            this.tb_procurar.Size = new System.Drawing.Size(201, 20);
            this.tb_procurar.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(313, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 109);
            this.button2.TabIndex = 19;
            this.button2.Text = "Hospedar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // hospedar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.BackgroundImage = global::HotelBandeirante.Properties.Resources.hospedar;
            this.ClientSize = new System.Drawing.Size(475, 535);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cb_campo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.tb_procurar);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "hospedar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "hospedar";
            this.TransparencyKey = System.Drawing.Color.Yellow;
            this.Load += new System.EventHandler(this.hospedar_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox desconto;
        private System.Windows.Forms.TextBox descricao;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox vlr_diaria;
        private System.Windows.Forms.TextBox numero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox telefone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.MaskedTextBox hora;
        private System.Windows.Forms.MaskedTextBox entrada;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cb_campo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox tb_procurar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tb_pessoas;
        private System.Windows.Forms.Label label10;
    }
}