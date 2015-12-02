namespace SistemaAlergiaAlimentar
{
    partial class frmPesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMarca = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTrigo = new System.Windows.Forms.CheckBox();
            this.cbSoja = new System.Windows.Forms.CheckBox();
            this.cbSementes = new System.Windows.Forms.CheckBox();
            this.cbPeixe = new System.Windows.Forms.CheckBox();
            this.cbOvo = new System.Windows.Forms.CheckBox();
            this.cbNozes = new System.Windows.Forms.CheckBox();
            this.cbLeite = new System.Windows.Forms.CheckBox();
            this.cbGluten = new System.Windows.Forms.CheckBox();
            this.cbGergelim = new System.Windows.Forms.CheckBox();
            this.cbFrutosDoMar = new System.Windows.Forms.CheckBox();
            this.cbFrutasCitricas = new System.Windows.Forms.CheckBox();
            this.cbCorantes = new System.Windows.Forms.CheckBox();
            this.cbChocolate = new System.Windows.Forms.CheckBox();
            this.cbCastanha = new System.Windows.Forms.CheckBox();
            this.cbAmendoim = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusAlergia = new System.Windows.Forms.ToolStripStatusLabel();
            this.cbEstabelecimento = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btEndereco = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.MaskedTextBox();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.txtMarca.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btPesquisar);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.txtMarca);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 416);
            this.panel1.TabIndex = 1;
            // 
            // txtMarca
            // 
            this.txtMarca.Controls.Add(this.label4);
            this.txtMarca.Controls.Add(this.txtTipo);
            this.txtMarca.Controls.Add(this.label3);
            this.txtMarca.Controls.Add(this.textBox2);
            this.txtMarca.Controls.Add(this.label2);
            this.txtMarca.Controls.Add(this.txtProduto);
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(29, 92);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(333, 108);
            this.txtMarca.TabIndex = 9;
            this.txtMarca.TabStop = false;
            this.txtMarca.Text = "Informações:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tipo:";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(55, 81);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.ReadOnly = true;
            this.txtTipo.Size = new System.Drawing.Size(265, 20);
            this.txtTipo.TabIndex = 17;
            this.txtTipo.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Marca:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(55, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(265, 20);
            this.textBox2.TabIndex = 15;
            this.textBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Produto:";
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(55, 29);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.ReadOnly = true;
            this.txtProduto.Size = new System.Drawing.Size(265, 20);
            this.txtProduto.TabIndex = 13;
            this.txtProduto.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(116, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(161, 31);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "PESQUISA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTrigo);
            this.groupBox1.Controls.Add(this.cbSoja);
            this.groupBox1.Controls.Add(this.cbSementes);
            this.groupBox1.Controls.Add(this.cbPeixe);
            this.groupBox1.Controls.Add(this.cbOvo);
            this.groupBox1.Controls.Add(this.cbNozes);
            this.groupBox1.Controls.Add(this.cbLeite);
            this.groupBox1.Controls.Add(this.cbGluten);
            this.groupBox1.Controls.Add(this.cbGergelim);
            this.groupBox1.Controls.Add(this.cbFrutosDoMar);
            this.groupBox1.Controls.Add(this.cbFrutasCitricas);
            this.groupBox1.Controls.Add(this.cbCorantes);
            this.groupBox1.Controls.Add(this.cbChocolate);
            this.groupBox1.Controls.Add(this.cbCastanha);
            this.groupBox1.Controls.Add(this.cbAmendoim);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 143);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Substâncias Presentes:";
            // 
            // cbTrigo
            // 
            this.cbTrigo.AutoCheck = false;
            this.cbTrigo.AutoSize = true;
            this.cbTrigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTrigo.Location = new System.Drawing.Point(247, 112);
            this.cbTrigo.Name = "cbTrigo";
            this.cbTrigo.Size = new System.Drawing.Size(50, 17);
            this.cbTrigo.TabIndex = 14;
            this.cbTrigo.Text = "Trigo";
            this.cbTrigo.UseVisualStyleBackColor = true;
            // 
            // cbSoja
            // 
            this.cbSoja.AutoCheck = false;
            this.cbSoja.AutoSize = true;
            this.cbSoja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSoja.Location = new System.Drawing.Point(247, 89);
            this.cbSoja.Name = "cbSoja";
            this.cbSoja.Size = new System.Drawing.Size(47, 17);
            this.cbSoja.TabIndex = 13;
            this.cbSoja.Text = "Soja";
            this.cbSoja.UseVisualStyleBackColor = true;
            // 
            // cbSementes
            // 
            this.cbSementes.AutoCheck = false;
            this.cbSementes.AutoSize = true;
            this.cbSementes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSementes.Location = new System.Drawing.Point(247, 66);
            this.cbSementes.Name = "cbSementes";
            this.cbSementes.Size = new System.Drawing.Size(73, 17);
            this.cbSementes.TabIndex = 12;
            this.cbSementes.Text = "Sementes";
            this.cbSementes.UseVisualStyleBackColor = true;
            // 
            // cbPeixe
            // 
            this.cbPeixe.AutoCheck = false;
            this.cbPeixe.AutoSize = true;
            this.cbPeixe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPeixe.Location = new System.Drawing.Point(247, 43);
            this.cbPeixe.Name = "cbPeixe";
            this.cbPeixe.Size = new System.Drawing.Size(52, 17);
            this.cbPeixe.TabIndex = 11;
            this.cbPeixe.Text = "Peixe";
            this.cbPeixe.UseVisualStyleBackColor = true;
            // 
            // cbOvo
            // 
            this.cbOvo.AutoCheck = false;
            this.cbOvo.AutoSize = true;
            this.cbOvo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOvo.Location = new System.Drawing.Point(247, 20);
            this.cbOvo.Name = "cbOvo";
            this.cbOvo.Size = new System.Drawing.Size(46, 17);
            this.cbOvo.TabIndex = 10;
            this.cbOvo.Text = "Ovo";
            this.cbOvo.UseVisualStyleBackColor = true;
            // 
            // cbNozes
            // 
            this.cbNozes.AutoCheck = false;
            this.cbNozes.AutoSize = true;
            this.cbNozes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNozes.Location = new System.Drawing.Point(127, 112);
            this.cbNozes.Name = "cbNozes";
            this.cbNozes.Size = new System.Drawing.Size(56, 17);
            this.cbNozes.TabIndex = 9;
            this.cbNozes.Text = "Nozes";
            this.cbNozes.UseVisualStyleBackColor = true;
            // 
            // cbLeite
            // 
            this.cbLeite.AutoCheck = false;
            this.cbLeite.AutoSize = true;
            this.cbLeite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLeite.Location = new System.Drawing.Point(127, 89);
            this.cbLeite.Name = "cbLeite";
            this.cbLeite.Size = new System.Drawing.Size(49, 17);
            this.cbLeite.TabIndex = 8;
            this.cbLeite.Text = "Leite";
            this.cbLeite.UseVisualStyleBackColor = true;
            // 
            // cbGluten
            // 
            this.cbGluten.AutoCheck = false;
            this.cbGluten.AutoSize = true;
            this.cbGluten.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGluten.Location = new System.Drawing.Point(127, 66);
            this.cbGluten.Name = "cbGluten";
            this.cbGluten.Size = new System.Drawing.Size(57, 17);
            this.cbGluten.TabIndex = 7;
            this.cbGluten.Text = "Glúten";
            this.cbGluten.UseVisualStyleBackColor = true;
            // 
            // cbGergelim
            // 
            this.cbGergelim.AutoCheck = false;
            this.cbGergelim.AutoSize = true;
            this.cbGergelim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGergelim.Location = new System.Drawing.Point(127, 43);
            this.cbGergelim.Name = "cbGergelim";
            this.cbGergelim.Size = new System.Drawing.Size(67, 17);
            this.cbGergelim.TabIndex = 6;
            this.cbGergelim.Text = "Gergelim";
            this.cbGergelim.UseVisualStyleBackColor = true;
            // 
            // cbFrutosDoMar
            // 
            this.cbFrutosDoMar.AutoCheck = false;
            this.cbFrutosDoMar.AutoSize = true;
            this.cbFrutosDoMar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFrutosDoMar.Location = new System.Drawing.Point(127, 20);
            this.cbFrutosDoMar.Name = "cbFrutosDoMar";
            this.cbFrutosDoMar.Size = new System.Drawing.Size(91, 17);
            this.cbFrutosDoMar.TabIndex = 5;
            this.cbFrutosDoMar.Text = "Frutos do Mar";
            this.cbFrutosDoMar.UseVisualStyleBackColor = true;
            // 
            // cbFrutasCitricas
            // 
            this.cbFrutasCitricas.AutoCheck = false;
            this.cbFrutasCitricas.AutoSize = true;
            this.cbFrutasCitricas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFrutasCitricas.Location = new System.Drawing.Point(6, 114);
            this.cbFrutasCitricas.Name = "cbFrutasCitricas";
            this.cbFrutasCitricas.Size = new System.Drawing.Size(94, 17);
            this.cbFrutasCitricas.TabIndex = 4;
            this.cbFrutasCitricas.Text = "Frutas Cítricas";
            this.cbFrutasCitricas.UseVisualStyleBackColor = true;
            // 
            // cbCorantes
            // 
            this.cbCorantes.AutoCheck = false;
            this.cbCorantes.AutoSize = true;
            this.cbCorantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCorantes.Location = new System.Drawing.Point(6, 91);
            this.cbCorantes.Name = "cbCorantes";
            this.cbCorantes.Size = new System.Drawing.Size(68, 17);
            this.cbCorantes.TabIndex = 3;
            this.cbCorantes.Text = "Corantes";
            this.cbCorantes.UseVisualStyleBackColor = true;
            // 
            // cbChocolate
            // 
            this.cbChocolate.AutoCheck = false;
            this.cbChocolate.AutoSize = true;
            this.cbChocolate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChocolate.Location = new System.Drawing.Point(6, 68);
            this.cbChocolate.Name = "cbChocolate";
            this.cbChocolate.Size = new System.Drawing.Size(74, 17);
            this.cbChocolate.TabIndex = 2;
            this.cbChocolate.Text = "Chocolate";
            this.cbChocolate.UseVisualStyleBackColor = true;
            // 
            // cbCastanha
            // 
            this.cbCastanha.AutoCheck = false;
            this.cbCastanha.AutoSize = true;
            this.cbCastanha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCastanha.Location = new System.Drawing.Point(6, 45);
            this.cbCastanha.Name = "cbCastanha";
            this.cbCastanha.Size = new System.Drawing.Size(71, 17);
            this.cbCastanha.TabIndex = 1;
            this.cbCastanha.Text = "Castanha";
            this.cbCastanha.UseVisualStyleBackColor = true;
            // 
            // cbAmendoim
            // 
            this.cbAmendoim.AutoCheck = false;
            this.cbAmendoim.AutoSize = true;
            this.cbAmendoim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAmendoim.Location = new System.Drawing.Point(6, 22);
            this.cbAmendoim.Name = "cbAmendoim";
            this.cbAmendoim.Size = new System.Drawing.Size(75, 17);
            this.cbAmendoim.TabIndex = 0;
            this.cbAmendoim.Text = "Amendoim";
            this.cbAmendoim.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusAlergia});
            this.statusStrip1.Location = new System.Drawing.Point(0, 431);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(413, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusAlergia
            // 
            this.statusAlergia.AutoSize = false;
            this.statusAlergia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusAlergia.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.statusAlergia.Name = "statusAlergia";
            this.statusAlergia.Size = new System.Drawing.Size(398, 17);
            this.statusAlergia.Spring = true;
            this.statusAlergia.Text = "Status";
            this.statusAlergia.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // cbEstabelecimento
            // 
            this.cbEstabelecimento.FormattingEnabled = true;
            this.cbEstabelecimento.Location = new System.Drawing.Point(6, 20);
            this.cbEstabelecimento.Name = "cbEstabelecimento";
            this.cbEstabelecimento.Size = new System.Drawing.Size(274, 21);
            this.cbEstabelecimento.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbEstabelecimento);
            this.groupBox2.Controls.Add(this.btEndereco);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(29, 355);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 55);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Onde encontrar:";
            // 
            // btEndereco
            // 
            this.btEndereco.Image = global::SistemaAlergiaAlimentar.Properties.Resources.Lupa;
            this.btEndereco.Location = new System.Drawing.Point(290, 12);
            this.btEndereco.Name = "btEndereco";
            this.btEndereco.Size = new System.Drawing.Size(37, 37);
            this.btEndereco.TabIndex = 10;
            this.btEndereco.UseVisualStyleBackColor = true;
            this.btEndereco.Click += new System.EventHandler(this.btEndereco_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(116, 62);
            this.txtCodigo.Mask = "000-000-000-000-0";
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(109, 20);
            this.txtCodigo.TabIndex = 3;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btPesquisar
            // 
            this.btPesquisar.Location = new System.Drawing.Point(247, 61);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btPesquisar.TabIndex = 12;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            // 
            // frmPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 453);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.txtMarca.ResumeLayout(false);
            this.txtMarca.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbTrigo;
        private System.Windows.Forms.CheckBox cbSoja;
        private System.Windows.Forms.CheckBox cbSementes;
        private System.Windows.Forms.CheckBox cbPeixe;
        private System.Windows.Forms.CheckBox cbOvo;
        private System.Windows.Forms.CheckBox cbNozes;
        private System.Windows.Forms.CheckBox cbLeite;
        private System.Windows.Forms.CheckBox cbGluten;
        private System.Windows.Forms.CheckBox cbGergelim;
        private System.Windows.Forms.CheckBox cbFrutosDoMar;
        private System.Windows.Forms.CheckBox cbFrutasCitricas;
        private System.Windows.Forms.CheckBox cbCorantes;
        private System.Windows.Forms.CheckBox cbChocolate;
        private System.Windows.Forms.CheckBox cbCastanha;
        private System.Windows.Forms.CheckBox cbAmendoim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusAlergia;
        private System.Windows.Forms.GroupBox txtMarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Button btEndereco;
        private System.Windows.Forms.ComboBox cbEstabelecimento;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox txtCodigo;
        private System.Windows.Forms.Button btPesquisar;
    }
}