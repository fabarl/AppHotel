namespace HotelBandeirante
{
    partial class historico_diaria
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
            this.mtb_data = new System.Windows.Forms.MaskedTextBox();
            this.cb_opcoes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_pri = new System.Windows.Forms.Label();
            this.mtb_fim = new System.Windows.Forms.MaskedTextBox();
            this.lb_fim = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.r_nome = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.r_vlr_diaria = new System.Windows.Forms.MaskedTextBox();
            this.r_vlr_cobrado = new System.Windows.Forms.MaskedTextBox();
            this.r_frigobar = new System.Windows.Forms.MaskedTextBox();
            this.r_debito = new System.Windows.Forms.MaskedTextBox();
            this.r_total = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.r_saida = new System.Windows.Forms.MaskedTextBox();
            this.r_entrada = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.r_diarias = new System.Windows.Forms.TextBox();
            this.r_desc = new System.Windows.Forms.TextBox();
            this.r_ap = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.t_deb = new System.Windows.Forms.TextBox();
            this.t_total = new System.Windows.Forms.TextBox();
            this.t_dias = new System.Windows.Forms.TextBox();
            this.t_diarias = new System.Windows.Forms.TextBox();
            this.t_frig = new System.Windows.Forms.TextBox();
            this.t_res = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView1.Location = new System.Drawing.Point(2, 30);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(487, 372);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // mtb_data
            // 
            this.mtb_data.Location = new System.Drawing.Point(186, 4);
            this.mtb_data.Mask = "00/00/0000";
            this.mtb_data.Name = "mtb_data";
            this.mtb_data.Size = new System.Drawing.Size(67, 20);
            this.mtb_data.TabIndex = 2;
            // 
            // cb_opcoes
            // 
            this.cb_opcoes.FormattingEnabled = true;
            this.cb_opcoes.Items.AddRange(new object[] {
            "Data",
            "Nome",
            "Entre Datas"});
            this.cb_opcoes.Location = new System.Drawing.Point(73, 3);
            this.cb_opcoes.Name = "cb_opcoes";
            this.cb_opcoes.Size = new System.Drawing.Size(72, 21);
            this.cb_opcoes.TabIndex = 3;
            this.cb_opcoes.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Procurar Por:";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(186, 4);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(230, 20);
            this.tb_nome.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(422, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Procurar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_pri
            // 
            this.lb_pri.AutoSize = true;
            this.lb_pri.Location = new System.Drawing.Point(147, 7);
            this.lb_pri.Name = "lb_pri";
            this.lb_pri.Size = new System.Drawing.Size(33, 13);
            this.lb_pri.TabIndex = 4;
            this.lb_pri.Text = "Data:";
            // 
            // mtb_fim
            // 
            this.mtb_fim.Location = new System.Drawing.Point(321, 5);
            this.mtb_fim.Mask = "00/00/0000";
            this.mtb_fim.Name = "mtb_fim";
            this.mtb_fim.Size = new System.Drawing.Size(67, 20);
            this.mtb_fim.TabIndex = 2;
            // 
            // lb_fim
            // 
            this.lb_fim.AutoSize = true;
            this.lb_fim.Location = new System.Drawing.Point(294, 9);
            this.lb_fim.Name = "lb_fim";
            this.lb_fim.Size = new System.Drawing.Size(26, 13);
            this.lb_fim.TabIndex = 4;
            this.lb_fim.Text = "Fim:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome:";
            // 
            // r_nome
            // 
            this.r_nome.Enabled = false;
            this.r_nome.Location = new System.Drawing.Point(39, 18);
            this.r_nome.Name = "r_nome";
            this.r_nome.Size = new System.Drawing.Size(207, 20);
            this.r_nome.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.r_vlr_diaria);
            this.groupBox1.Controls.Add(this.r_vlr_cobrado);
            this.groupBox1.Controls.Add(this.r_frigobar);
            this.groupBox1.Controls.Add(this.r_debito);
            this.groupBox1.Controls.Add(this.r_total);
            this.groupBox1.Controls.Add(this.dataGridView);
            this.groupBox1.Controls.Add(this.r_saida);
            this.groupBox1.Controls.Add(this.r_entrada);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.r_diarias);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.r_desc);
            this.groupBox1.Controls.Add(this.r_ap);
            this.groupBox1.Controls.Add(this.r_nome);
            this.groupBox1.Location = new System.Drawing.Point(495, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 399);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultado da Pesquisa";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // r_vlr_diaria
            // 
            this.r_vlr_diaria.Enabled = false;
            this.r_vlr_diaria.Location = new System.Drawing.Point(73, 105);
            this.r_vlr_diaria.Name = "r_vlr_diaria";
            this.r_vlr_diaria.PromptChar = ' ';
            this.r_vlr_diaria.Size = new System.Drawing.Size(69, 20);
            this.r_vlr_diaria.TabIndex = 8;
            // 
            // r_vlr_cobrado
            // 
            this.r_vlr_cobrado.Enabled = false;
            this.r_vlr_cobrado.Location = new System.Drawing.Point(119, 128);
            this.r_vlr_cobrado.Name = "r_vlr_cobrado";
            this.r_vlr_cobrado.PromptChar = ' ';
            this.r_vlr_cobrado.Size = new System.Drawing.Size(69, 20);
            this.r_vlr_cobrado.TabIndex = 8;
            // 
            // r_frigobar
            // 
            this.r_frigobar.Enabled = false;
            this.r_frigobar.Location = new System.Drawing.Point(172, 154);
            this.r_frigobar.Name = "r_frigobar";
            this.r_frigobar.PromptChar = ' ';
            this.r_frigobar.Size = new System.Drawing.Size(69, 20);
            this.r_frigobar.TabIndex = 8;
            // 
            // r_debito
            // 
            this.r_debito.Enabled = false;
            this.r_debito.Location = new System.Drawing.Point(192, 184);
            this.r_debito.Name = "r_debito";
            this.r_debito.PromptChar = ' ';
            this.r_debito.Size = new System.Drawing.Size(49, 20);
            this.r_debito.TabIndex = 8;
            // 
            // r_total
            // 
            this.r_total.Enabled = false;
            this.r_total.Location = new System.Drawing.Point(72, 185);
            this.r_total.Name = "r_total";
            this.r_total.PromptChar = ' ';
            this.r_total.Size = new System.Drawing.Size(70, 20);
            this.r_total.TabIndex = 8;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.GridColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView.Location = new System.Drawing.Point(6, 214);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.ShowCellErrors = false;
            this.dataGridView.ShowCellToolTips = false;
            this.dataGridView.ShowEditingIcon = false;
            this.dataGridView.ShowRowErrors = false;
            this.dataGridView.Size = new System.Drawing.Size(240, 179);
            this.dataGridView.TabIndex = 7;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // r_saida
            // 
            this.r_saida.Enabled = false;
            this.r_saida.Location = new System.Drawing.Point(171, 78);
            this.r_saida.Name = "r_saida";
            this.r_saida.Size = new System.Drawing.Size(75, 20);
            this.r_saida.TabIndex = 6;
            // 
            // r_entrada
            // 
            this.r_entrada.Enabled = false;
            this.r_entrada.Location = new System.Drawing.Point(46, 77);
            this.r_entrada.Name = "r_entrada";
            this.r_entrada.Size = new System.Drawing.Size(86, 20);
            this.r_entrada.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Valor Diaria Cobrado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Saida:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "N° Ap.:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Valor Diaria:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(91, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Valor Frigobar:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(151, 188);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Débito:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Valor Total :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Diarias:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Entrada:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Desc.:";
            // 
            // r_diarias
            // 
            this.r_diarias.Enabled = false;
            this.r_diarias.Location = new System.Drawing.Point(45, 154);
            this.r_diarias.Name = "r_diarias";
            this.r_diarias.Size = new System.Drawing.Size(37, 20);
            this.r_diarias.TabIndex = 5;
            // 
            // r_desc
            // 
            this.r_desc.Enabled = false;
            this.r_desc.Location = new System.Drawing.Point(197, 42);
            this.r_desc.Name = "r_desc";
            this.r_desc.Size = new System.Drawing.Size(49, 20);
            this.r_desc.TabIndex = 5;
            // 
            // r_ap
            // 
            this.r_ap.Enabled = false;
            this.r_ap.Location = new System.Drawing.Point(56, 46);
            this.r_ap.Name = "r_ap";
            this.r_ap.Size = new System.Drawing.Size(57, 20);
            this.r_ap.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.t_deb);
            this.groupBox2.Controls.Add(this.t_total);
            this.groupBox2.Controls.Add(this.t_dias);
            this.groupBox2.Controls.Add(this.t_diarias);
            this.groupBox2.Controls.Add(this.t_frig);
            this.groupBox2.Controls.Add(this.t_res);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(495, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 210);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Gerais Entre Datas";
            // 
            // t_deb
            // 
            this.t_deb.Enabled = false;
            this.t_deb.Location = new System.Drawing.Point(136, 159);
            this.t_deb.Name = "t_deb";
            this.t_deb.Size = new System.Drawing.Size(100, 20);
            this.t_deb.TabIndex = 1;
            this.t_deb.Text = "0";
            // 
            // t_total
            // 
            this.t_total.Enabled = false;
            this.t_total.Location = new System.Drawing.Point(136, 133);
            this.t_total.Name = "t_total";
            this.t_total.Size = new System.Drawing.Size(100, 20);
            this.t_total.TabIndex = 1;
            this.t_total.Text = "0";
            // 
            // t_dias
            // 
            this.t_dias.Enabled = false;
            this.t_dias.Location = new System.Drawing.Point(136, 105);
            this.t_dias.Name = "t_dias";
            this.t_dias.Size = new System.Drawing.Size(100, 20);
            this.t_dias.TabIndex = 1;
            this.t_dias.Text = "0";
            // 
            // t_diarias
            // 
            this.t_diarias.Enabled = false;
            this.t_diarias.Location = new System.Drawing.Point(136, 81);
            this.t_diarias.Name = "t_diarias";
            this.t_diarias.Size = new System.Drawing.Size(100, 20);
            this.t_diarias.TabIndex = 1;
            this.t_diarias.Text = "0";
            // 
            // t_frig
            // 
            this.t_frig.Enabled = false;
            this.t_frig.Location = new System.Drawing.Point(136, 56);
            this.t_frig.Name = "t_frig";
            this.t_frig.Size = new System.Drawing.Size(100, 20);
            this.t_frig.TabIndex = 1;
            this.t_frig.Text = "0";
            // 
            // t_res
            // 
            this.t_res.Enabled = false;
            this.t_res.Location = new System.Drawing.Point(136, 24);
            this.t_res.Name = "t_res";
            this.t_res.Size = new System.Drawing.Size(100, 20);
            this.t_res.TabIndex = 1;
            this.t_res.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 108);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(111, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Valor Total de Diarias:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 84);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Diarias :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(117, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Valor Total do Frigobar:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 162);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(115, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Valor Total de Débitos:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 136);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Valor Total:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Total de Resultados:";
            // 
            // historico_diaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 403);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.lb_fim);
            this.Controls.Add(this.lb_pri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_opcoes);
            this.Controls.Add(this.mtb_fim);
            this.Controls.Add(this.mtb_data);
            this.Controls.Add(this.dataGridView1);
            this.Name = "historico_diaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Caixa Diarias";
            this.Load += new System.EventHandler(this.historico_diaria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox mtb_data;
        private System.Windows.Forms.ComboBox cb_opcoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_pri;
        private System.Windows.Forms.MaskedTextBox mtb_fim;
        private System.Windows.Forms.Label lb_fim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox r_nome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.MaskedTextBox r_saida;
        private System.Windows.Forms.MaskedTextBox r_entrada;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox r_diarias;
        private System.Windows.Forms.TextBox r_desc;
        private System.Windows.Forms.TextBox r_ap;
        private System.Windows.Forms.MaskedTextBox r_vlr_diaria;
        private System.Windows.Forms.MaskedTextBox r_vlr_cobrado;
        private System.Windows.Forms.MaskedTextBox r_frigobar;
        private System.Windows.Forms.MaskedTextBox r_debito;
        private System.Windows.Forms.MaskedTextBox r_total;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox t_deb;
        private System.Windows.Forms.TextBox t_total;
        private System.Windows.Forms.TextBox t_dias;
        private System.Windows.Forms.TextBox t_frig;
        private System.Windows.Forms.TextBox t_res;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox t_diarias;
        private System.Windows.Forms.Label label18;
    }
}