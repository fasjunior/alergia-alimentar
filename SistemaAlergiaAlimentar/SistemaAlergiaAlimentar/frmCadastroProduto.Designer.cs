namespace SistemaAlergiaAlimentar
{
    partial class frmCadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroProduto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btVoltar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCodigo = new System.Windows.Forms.MaskedTextBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.cbFabricante = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btSalvar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTrigo = new System.Windows.Forms.CheckBox();
            this.cbSoja = new System.Windows.Forms.CheckBox();
            this.cbSementes = new System.Windows.Forms.CheckBox();
            this.cbPeixe = new System.Windows.Forms.CheckBox();
            this.cbOvo = new System.Windows.Forms.CheckBox();
            this.cbNozes = new System.Windows.Forms.CheckBox();
            this.cbLactose = new System.Windows.Forms.CheckBox();
            this.cbGluten = new System.Windows.Forms.CheckBox();
            this.cbGergelim = new System.Windows.Forms.CheckBox();
            this.cbFrutosDoMar = new System.Windows.Forms.CheckBox();
            this.cbFrutasCitricas = new System.Windows.Forms.CheckBox();
            this.cbCorantes = new System.Windows.Forms.CheckBox();
            this.cbChocolate = new System.Windows.Forms.CheckBox();
            this.cbCastanha = new System.Windows.Forms.CheckBox();
            this.cbAmendoim = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btVoltar);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.btSalvar);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 339);
            this.panel1.TabIndex = 1;
            // 
            // btVoltar
            // 
            this.btVoltar.Location = new System.Drawing.Point(193, 299);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(88, 24);
            this.btVoltar.TabIndex = 5;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCodigo);
            this.groupBox2.Controls.Add(this.cbCategoria);
            this.groupBox2.Controls.Add(this.cbFabricante);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 131);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(103, 45);
            this.txtCodigo.Mask = "000-000-000-0000-0";
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(248, 20);
            this.txtCodigo.TabIndex = 11;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(103, 98);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(248, 21);
            this.cbCategoria.TabIndex = 10;
            // 
            // cbFabricante
            // 
            this.cbFabricante.FormattingEnabled = true;
            this.cbFabricante.Location = new System.Drawing.Point(103, 71);
            this.cbFabricante.Name = "cbFabricante";
            this.cbFabricante.Size = new System.Drawing.Size(248, 21);
            this.cbFabricante.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Categoria:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fabricante:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Código de Barras:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(103, 18);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(248, 20);
            this.txtNome.TabIndex = 2;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(99, 299);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(88, 24);
            this.btSalvar.TabIndex = 4;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTrigo);
            this.groupBox1.Controls.Add(this.cbSoja);
            this.groupBox1.Controls.Add(this.cbSementes);
            this.groupBox1.Controls.Add(this.cbPeixe);
            this.groupBox1.Controls.Add(this.cbOvo);
            this.groupBox1.Controls.Add(this.cbNozes);
            this.groupBox1.Controls.Add(this.cbLactose);
            this.groupBox1.Controls.Add(this.cbGluten);
            this.groupBox1.Controls.Add(this.cbGergelim);
            this.groupBox1.Controls.Add(this.cbFrutosDoMar);
            this.groupBox1.Controls.Add(this.cbFrutasCitricas);
            this.groupBox1.Controls.Add(this.cbCorantes);
            this.groupBox1.Controls.Add(this.cbChocolate);
            this.groupBox1.Controls.Add(this.cbCastanha);
            this.groupBox1.Controls.Add(this.cbAmendoim);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 143);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Substâncias Alérgicas:";
            // 
            // cbTrigo
            // 
            this.cbTrigo.AutoSize = true;
            this.cbTrigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTrigo.Location = new System.Drawing.Point(264, 112);
            this.cbTrigo.Name = "cbTrigo";
            this.cbTrigo.Size = new System.Drawing.Size(50, 17);
            this.cbTrigo.TabIndex = 14;
            this.cbTrigo.Text = "Trigo";
            this.cbTrigo.UseVisualStyleBackColor = true;
            // 
            // cbSoja
            // 
            this.cbSoja.AutoSize = true;
            this.cbSoja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSoja.Location = new System.Drawing.Point(264, 89);
            this.cbSoja.Name = "cbSoja";
            this.cbSoja.Size = new System.Drawing.Size(47, 17);
            this.cbSoja.TabIndex = 13;
            this.cbSoja.Text = "Soja";
            this.cbSoja.UseVisualStyleBackColor = true;
            // 
            // cbSementes
            // 
            this.cbSementes.AutoSize = true;
            this.cbSementes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSementes.Location = new System.Drawing.Point(264, 66);
            this.cbSementes.Name = "cbSementes";
            this.cbSementes.Size = new System.Drawing.Size(73, 17);
            this.cbSementes.TabIndex = 12;
            this.cbSementes.Text = "Sementes";
            this.cbSementes.UseVisualStyleBackColor = true;
            // 
            // cbPeixe
            // 
            this.cbPeixe.AutoSize = true;
            this.cbPeixe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPeixe.Location = new System.Drawing.Point(264, 43);
            this.cbPeixe.Name = "cbPeixe";
            this.cbPeixe.Size = new System.Drawing.Size(52, 17);
            this.cbPeixe.TabIndex = 11;
            this.cbPeixe.Text = "Peixe";
            this.cbPeixe.UseVisualStyleBackColor = true;
            // 
            // cbOvo
            // 
            this.cbOvo.AutoSize = true;
            this.cbOvo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOvo.Location = new System.Drawing.Point(264, 20);
            this.cbOvo.Name = "cbOvo";
            this.cbOvo.Size = new System.Drawing.Size(46, 17);
            this.cbOvo.TabIndex = 10;
            this.cbOvo.Text = "Ovo";
            this.cbOvo.UseVisualStyleBackColor = true;
            // 
            // cbNozes
            // 
            this.cbNozes.AutoSize = true;
            this.cbNozes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNozes.Location = new System.Drawing.Point(144, 112);
            this.cbNozes.Name = "cbNozes";
            this.cbNozes.Size = new System.Drawing.Size(56, 17);
            this.cbNozes.TabIndex = 9;
            this.cbNozes.Text = "Nozes";
            this.cbNozes.UseVisualStyleBackColor = true;
            // 
            // cbLactose
            // 
            this.cbLactose.AutoSize = true;
            this.cbLactose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLactose.Location = new System.Drawing.Point(144, 89);
            this.cbLactose.Name = "cbLactose";
            this.cbLactose.Size = new System.Drawing.Size(64, 17);
            this.cbLactose.TabIndex = 8;
            this.cbLactose.Text = "Lactose";
            this.cbLactose.UseVisualStyleBackColor = true;
            // 
            // cbGluten
            // 
            this.cbGluten.AutoSize = true;
            this.cbGluten.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGluten.Location = new System.Drawing.Point(144, 66);
            this.cbGluten.Name = "cbGluten";
            this.cbGluten.Size = new System.Drawing.Size(57, 17);
            this.cbGluten.TabIndex = 7;
            this.cbGluten.Text = "Glúten";
            this.cbGluten.UseVisualStyleBackColor = true;
            // 
            // cbGergelim
            // 
            this.cbGergelim.AutoSize = true;
            this.cbGergelim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGergelim.Location = new System.Drawing.Point(144, 43);
            this.cbGergelim.Name = "cbGergelim";
            this.cbGergelim.Size = new System.Drawing.Size(67, 17);
            this.cbGergelim.TabIndex = 6;
            this.cbGergelim.Text = "Gergelim";
            this.cbGergelim.UseVisualStyleBackColor = true;
            // 
            // cbFrutosDoMar
            // 
            this.cbFrutosDoMar.AutoSize = true;
            this.cbFrutosDoMar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFrutosDoMar.Location = new System.Drawing.Point(144, 20);
            this.cbFrutosDoMar.Name = "cbFrutosDoMar";
            this.cbFrutosDoMar.Size = new System.Drawing.Size(91, 17);
            this.cbFrutosDoMar.TabIndex = 5;
            this.cbFrutosDoMar.Text = "Frutos do Mar";
            this.cbFrutosDoMar.UseVisualStyleBackColor = true;
            // 
            // cbFrutasCitricas
            // 
            this.cbFrutasCitricas.AutoSize = true;
            this.cbFrutasCitricas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFrutasCitricas.Location = new System.Drawing.Point(23, 114);
            this.cbFrutasCitricas.Name = "cbFrutasCitricas";
            this.cbFrutasCitricas.Size = new System.Drawing.Size(94, 17);
            this.cbFrutasCitricas.TabIndex = 4;
            this.cbFrutasCitricas.Text = "Frutas Cítricas";
            this.cbFrutasCitricas.UseVisualStyleBackColor = true;
            // 
            // cbCorantes
            // 
            this.cbCorantes.AutoSize = true;
            this.cbCorantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCorantes.Location = new System.Drawing.Point(23, 91);
            this.cbCorantes.Name = "cbCorantes";
            this.cbCorantes.Size = new System.Drawing.Size(68, 17);
            this.cbCorantes.TabIndex = 3;
            this.cbCorantes.Text = "Corantes";
            this.cbCorantes.UseVisualStyleBackColor = true;
            // 
            // cbChocolate
            // 
            this.cbChocolate.AutoSize = true;
            this.cbChocolate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChocolate.Location = new System.Drawing.Point(23, 68);
            this.cbChocolate.Name = "cbChocolate";
            this.cbChocolate.Size = new System.Drawing.Size(74, 17);
            this.cbChocolate.TabIndex = 2;
            this.cbChocolate.Text = "Chocolate";
            this.cbChocolate.UseVisualStyleBackColor = true;
            // 
            // cbCastanha
            // 
            this.cbCastanha.AutoSize = true;
            this.cbCastanha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCastanha.Location = new System.Drawing.Point(23, 45);
            this.cbCastanha.Name = "cbCastanha";
            this.cbCastanha.Size = new System.Drawing.Size(71, 17);
            this.cbCastanha.TabIndex = 1;
            this.cbCastanha.Text = "Castanha";
            this.cbCastanha.UseVisualStyleBackColor = true;
            // 
            // cbAmendoim
            // 
            this.cbAmendoim.AutoSize = true;
            this.cbAmendoim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAmendoim.Location = new System.Drawing.Point(23, 22);
            this.cbAmendoim.Name = "cbAmendoim";
            this.cbAmendoim.Size = new System.Drawing.Size(75, 17);
            this.cbAmendoim.TabIndex = 0;
            this.cbAmendoim.Text = "Amendoim";
            this.cbAmendoim.UseVisualStyleBackColor = true;
            // 
            // frmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 352);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Produto";
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbTrigo;
        private System.Windows.Forms.CheckBox cbSoja;
        private System.Windows.Forms.CheckBox cbSementes;
        private System.Windows.Forms.CheckBox cbPeixe;
        private System.Windows.Forms.CheckBox cbOvo;
        private System.Windows.Forms.CheckBox cbNozes;
        private System.Windows.Forms.CheckBox cbLactose;
        private System.Windows.Forms.CheckBox cbGluten;
        private System.Windows.Forms.CheckBox cbGergelim;
        private System.Windows.Forms.CheckBox cbFrutosDoMar;
        private System.Windows.Forms.CheckBox cbFrutasCitricas;
        private System.Windows.Forms.CheckBox cbCorantes;
        private System.Windows.Forms.CheckBox cbChocolate;
        private System.Windows.Forms.CheckBox cbCastanha;
        private System.Windows.Forms.CheckBox cbAmendoim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.ComboBox cbFabricante;
        private System.Windows.Forms.MaskedTextBox txtCodigo;
    }
}