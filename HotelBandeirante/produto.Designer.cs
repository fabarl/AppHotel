namespace HotelBandeirante
{
    partial class produto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.prod = new System.Windows.Forms.TextBox();
            this.qtd = new System.Windows.Forms.TextBox();
            this.mim = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.vlr = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.up_qtd = new System.Windows.Forms.TextBox();
            this.up_vlr = new System.Windows.Forms.TextBox();
            this.up_min = new System.Windows.Forms.TextBox();
            this.select_produto = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor Unidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Minimo de Estoque:";
            // 
            // prod
            // 
            this.prod.Location = new System.Drawing.Point(71, 22);
            this.prod.Name = "prod";
            this.prod.Size = new System.Drawing.Size(160, 20);
            this.prod.TabIndex = 4;
            // 
            // qtd
            // 
            this.qtd.Location = new System.Drawing.Point(71, 48);
            this.qtd.Name = "qtd";
            this.qtd.Size = new System.Drawing.Size(75, 20);
            this.qtd.TabIndex = 5;
            // 
            // mim
            // 
            this.mim.Location = new System.Drawing.Point(320, 52);
            this.mim.Name = "mim";
            this.mim.Size = new System.Drawing.Size(75, 20);
            this.mim.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 53);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vlr
            // 
            this.vlr.Location = new System.Drawing.Point(320, 22);
            this.vlr.Name = "vlr";
            this.vlr.Size = new System.Drawing.Size(75, 20);
            this.vlr.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.vlr);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mim);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.qtd);
            this.groupBox1.Controls.Add(this.prod);
            this.groupBox1.Location = new System.Drawing.Point(2, 333);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 85);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Novo Produto";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(560, 204);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Quantidade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Valor Unitário:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(383, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Minimi Estoque:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(147, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Produto:";
            // 
            // up_qtd
            // 
            this.up_qtd.Location = new System.Drawing.Point(94, 240);
            this.up_qtd.Name = "up_qtd";
            this.up_qtd.Size = new System.Drawing.Size(100, 20);
            this.up_qtd.TabIndex = 13;
            // 
            // up_vlr
            // 
            this.up_vlr.Location = new System.Drawing.Point(290, 240);
            this.up_vlr.Name = "up_vlr";
            this.up_vlr.Size = new System.Drawing.Size(87, 20);
            this.up_vlr.TabIndex = 13;
            // 
            // up_min
            // 
            this.up_min.Location = new System.Drawing.Point(470, 240);
            this.up_min.Name = "up_min";
            this.up_min.Size = new System.Drawing.Size(73, 20);
            this.up_min.TabIndex = 13;
            // 
            // select_produto
            // 
            this.select_produto.AutoSize = true;
            this.select_produto.Location = new System.Drawing.Point(195, 216);
            this.select_produto.Name = "select_produto";
            this.select_produto.Size = new System.Drawing.Size(191, 13);
            this.select_produto.TabIndex = 12;
            this.select_produto.Text = "NENHUM PRODUTO SELECIONADO";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 49);
            this.button2.TabIndex = 14;
            this.button2.Text = "Atualizar Estoque";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(373, 266);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 49);
            this.button3.TabIndex = 15;
            this.button3.Text = "Excluir Produto";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 430);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.up_min);
            this.Controls.Add(this.up_vlr);
            this.Controls.Add(this.up_qtd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.select_produto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastrar Produtos";
            this.Load += new System.EventHandler(this.produto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox prod;
        private System.Windows.Forms.TextBox qtd;
        private System.Windows.Forms.TextBox mim;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox vlr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox up_qtd;
        private System.Windows.Forms.TextBox up_vlr;
        private System.Windows.Forms.TextBox up_min;
        private System.Windows.Forms.Label select_produto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}