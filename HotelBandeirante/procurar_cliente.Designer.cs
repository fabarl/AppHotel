namespace HotelBandeirante
{
    partial class procurar_cliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_procurar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_campo = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_endereco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_nasc = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_cidade = new System.Windows.Forms.TextBox();
            this.tb_estado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_cpf = new System.Windows.Forms.TextBox();
            this.tb_rg = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_telefone = new System.Windows.Forms.TextBox();
            this.tb_telefone2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_empresa = new System.Windows.Forms.TextBox();
            this.tb_cargo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_cnpj = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_obs = new System.Windows.Forms.TextBox();
            this.lb_debito = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lb_debito2 = new System.Windows.Forms.Label();
            this.tb_valor_debito = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(7, 41);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(589, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Procurar por:";
            // 
            // tb_procurar
            // 
            this.tb_procurar.Location = new System.Drawing.Point(159, 13);
            this.tb_procurar.Name = "tb_procurar";
            this.tb_procurar.Size = new System.Drawing.Size(336, 20);
            this.tb_procurar.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(501, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Procurar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.cb_campo.Location = new System.Drawing.Point(72, 12);
            this.cb_campo.Name = "cb_campo";
            this.cb_campo.Size = new System.Drawing.Size(74, 21);
            this.cb_campo.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(7, 470);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 39);
            this.button3.TabIndex = 3;
            this.button3.Text = "Sair";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(4, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome:";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(48, 208);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(336, 20);
            this.tb_nome.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(390, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data Nascimento:";
            // 
            // tb_endereco
            // 
            this.tb_endereco.Location = new System.Drawing.Point(62, 236);
            this.tb_endereco.Name = "tb_endereco";
            this.tb_endereco.Size = new System.Drawing.Size(322, 20);
            this.tb_endereco.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(4, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Endereço:";
            // 
            // tb_nasc
            // 
            this.tb_nasc.Location = new System.Drawing.Point(488, 208);
            this.tb_nasc.Mask = "00/00/0000";
            this.tb_nasc.Name = "tb_nasc";
            this.tb_nasc.Size = new System.Drawing.Size(70, 20);
            this.tb_nasc.TabIndex = 6;
            this.tb_nasc.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(439, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cidade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(439, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Estado:";
            // 
            // tb_cidade
            // 
            this.tb_cidade.Location = new System.Drawing.Point(488, 234);
            this.tb_cidade.Name = "tb_cidade";
            this.tb_cidade.Size = new System.Drawing.Size(100, 20);
            this.tb_cidade.TabIndex = 7;
            // 
            // tb_estado
            // 
            this.tb_estado.Location = new System.Drawing.Point(488, 260);
            this.tb_estado.Name = "tb_estado";
            this.tb_estado.Size = new System.Drawing.Size(100, 20);
            this.tb_estado.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(26, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "CPF:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(218, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "RG:";
            // 
            // tb_cpf
            // 
            this.tb_cpf.Location = new System.Drawing.Point(62, 260);
            this.tb_cpf.Name = "tb_cpf";
            this.tb_cpf.Size = new System.Drawing.Size(150, 20);
            this.tb_cpf.TabIndex = 7;
            // 
            // tb_rg
            // 
            this.tb_rg.Location = new System.Drawing.Point(250, 260);
            this.tb_rg.Name = "tb_rg";
            this.tb_rg.Size = new System.Drawing.Size(134, 20);
            this.tb_rg.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(4, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Telefone:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(183, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Telefone 2:";
            // 
            // tb_telefone
            // 
            this.tb_telefone.Location = new System.Drawing.Point(62, 286);
            this.tb_telefone.Name = "tb_telefone";
            this.tb_telefone.Size = new System.Drawing.Size(120, 20);
            this.tb_telefone.TabIndex = 7;
            // 
            // tb_telefone2
            // 
            this.tb_telefone2.Location = new System.Drawing.Point(250, 287);
            this.tb_telefone2.Name = "tb_telefone2";
            this.tb_telefone2.Size = new System.Drawing.Size(134, 20);
            this.tb_telefone2.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(4, 312);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Empresa:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(206, 313);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Cargo:";
            // 
            // tb_empresa
            // 
            this.tb_empresa.Location = new System.Drawing.Point(62, 309);
            this.tb_empresa.Name = "tb_empresa";
            this.tb_empresa.Size = new System.Drawing.Size(120, 20);
            this.tb_empresa.TabIndex = 7;
            // 
            // tb_cargo
            // 
            this.tb_cargo.Location = new System.Drawing.Point(250, 310);
            this.tb_cargo.Name = "tb_cargo";
            this.tb_cargo.Size = new System.Drawing.Size(134, 20);
            this.tb_cargo.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(390, 292);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "E-Mail:";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(428, 287);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(160, 20);
            this.tb_email.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(390, 315);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "CNPJ:";
            // 
            // tb_cnpj
            // 
            this.tb_cnpj.Location = new System.Drawing.Point(428, 310);
            this.tb_cnpj.Name = "tb_cnpj";
            this.tb_cnpj.Size = new System.Drawing.Size(160, 20);
            this.tb_cnpj.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(4, 364);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Observação:";
            // 
            // tb_obs
            // 
            this.tb_obs.Location = new System.Drawing.Point(72, 341);
            this.tb_obs.Multiline = true;
            this.tb_obs.Name = "tb_obs";
            this.tb_obs.Size = new System.Drawing.Size(516, 62);
            this.tb_obs.TabIndex = 7;
            // 
            // lb_debito
            // 
            this.lb_debito.AutoSize = true;
            this.lb_debito.BackColor = System.Drawing.Color.Transparent;
            this.lb_debito.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_debito.ForeColor = System.Drawing.Color.SeaGreen;
            this.lb_debito.Location = new System.Drawing.Point(152, 417);
            this.lb_debito.Name = "lb_debito";
            this.lb_debito.Size = new System.Drawing.Size(26, 39);
            this.lb_debito.TabIndex = 5;
            this.lb_debito.Text = " ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(428, 470);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 46);
            this.button2.TabIndex = 8;
            this.button2.Text = "Atualizar Dados";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lb_debito2
            // 
            this.lb_debito2.AutoSize = true;
            this.lb_debito2.BackColor = System.Drawing.Color.Transparent;
            this.lb_debito2.Location = new System.Drawing.Point(206, 483);
            this.lb_debito2.Name = "lb_debito2";
            this.lb_debito2.Size = new System.Drawing.Size(83, 13);
            this.lb_debito2.TabIndex = 5;
            this.lb_debito2.Text = "Valor do Débito:";
            // 
            // tb_valor_debito
            // 
            this.tb_valor_debito.Location = new System.Drawing.Point(289, 479);
            this.tb_valor_debito.Name = "tb_valor_debito";
            this.tb_valor_debito.Size = new System.Drawing.Size(81, 20);
            this.tb_valor_debito.TabIndex = 7;
            // 
            // procurar_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.BackgroundImage = global::HotelBandeirante.Properties.Resources.procurar2;
            this.ClientSize = new System.Drawing.Size(607, 521);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tb_cargo);
            this.Controls.Add(this.tb_telefone2);
            this.Controls.Add(this.tb_rg);
            this.Controls.Add(this.tb_cnpj);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_estado);
            this.Controls.Add(this.tb_obs);
            this.Controls.Add(this.tb_valor_debito);
            this.Controls.Add(this.tb_empresa);
            this.Controls.Add(this.tb_telefone);
            this.Controls.Add(this.tb_cpf);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tb_cidade);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_nasc);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lb_debito2);
            this.Controls.Add(this.lb_debito);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cb_campo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_endereco);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.tb_procurar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "procurar_cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Procurar CLiente";
            this.TransparencyKey = System.Drawing.Color.Yellow;
            this.Load += new System.EventHandler(this.procurar_cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_procurar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cb_campo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_endereco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox tb_nasc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_estado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_cpf;
        private System.Windows.Forms.TextBox tb_rg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_telefone;
        private System.Windows.Forms.TextBox tb_telefone2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_empresa;
        private System.Windows.Forms.TextBox tb_cargo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_cnpj;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_obs;
        private System.Windows.Forms.Label lb_debito;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lb_debito2;
        private System.Windows.Forms.TextBox tb_valor_debito;
        private System.Windows.Forms.TextBox tb_cidade;
    }
}