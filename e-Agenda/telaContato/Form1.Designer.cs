namespace telaContato
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.pegaNome = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pegaDepartamento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pegaEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pegaCargo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pegaTelefone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvContatos = new System.Windows.Forms.DataGridView();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAlteracao = new System.Windows.Forms.Button();
            this.Contatos = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatos)).BeginInit();
            this.Contatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pegaNome
            // 
            this.pegaNome.Location = new System.Drawing.Point(31, 57);
            this.pegaNome.Name = "pegaNome";
            this.pegaNome.Size = new System.Drawing.Size(504, 26);
            this.pegaNome.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAlteracao);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.pegaDepartamento);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.pegaEmail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pegaCargo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pegaTelefone);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pegaNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 484);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inserir";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(403, 411);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(132, 32);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // pegaDepartamento
            // 
            this.pegaDepartamento.Location = new System.Drawing.Point(31, 354);
            this.pegaDepartamento.Name = "pegaDepartamento";
            this.pegaDepartamento.Size = new System.Drawing.Size(504, 26);
            this.pegaDepartamento.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Departamento";
            // 
            // pegaEmail
            // 
            this.pegaEmail.Location = new System.Drawing.Point(31, 284);
            this.pegaEmail.Name = "pegaEmail";
            this.pegaEmail.Size = new System.Drawing.Size(504, 26);
            this.pegaEmail.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email";
            // 
            // pegaCargo
            // 
            this.pegaCargo.Location = new System.Drawing.Point(31, 217);
            this.pegaCargo.Name = "pegaCargo";
            this.pegaCargo.Size = new System.Drawing.Size(504, 26);
            this.pegaCargo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cargo";
            // 
            // pegaTelefone
            // 
            this.pegaTelefone.Location = new System.Drawing.Point(31, 139);
            this.pegaTelefone.Name = "pegaTelefone";
            this.pegaTelefone.Size = new System.Drawing.Size(504, 26);
            this.pegaTelefone.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Telefone";
            // 
            // dgvContatos
            // 
            this.dgvContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContatos.Location = new System.Drawing.Point(43, 57);
            this.dgvContatos.Name = "dgvContatos";
            this.dgvContatos.RowTemplate.Height = 28;
            this.dgvContatos.Size = new System.Drawing.Size(778, 323);
            this.dgvContatos.TabIndex = 4;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(689, 411);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(132, 32);
            this.btnDeletar.TabIndex = 12;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(538, 411);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(132, 32);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Alterar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAlteracao
            // 
            this.btnAlteracao.Location = new System.Drawing.Point(313, 411);
            this.btnAlteracao.Name = "btnAlteracao";
            this.btnAlteracao.Size = new System.Drawing.Size(222, 32);
            this.btnAlteracao.TabIndex = 12;
            this.btnAlteracao.Text = "Salvar Alteracao";
            this.btnAlteracao.UseVisualStyleBackColor = true;
            this.btnAlteracao.Visible = false;
            this.btnAlteracao.Click += new System.EventHandler(this.btnAlteracao_Click);
            // 
            // Contatos
            // 
            this.Contatos.Controls.Add(this.dgvContatos);
            this.Contatos.Controls.Add(this.btnEditar);
            this.Contatos.Controls.Add(this.btnDeletar);
            this.Contatos.Location = new System.Drawing.Point(661, 35);
            this.Contatos.Name = "Contatos";
            this.Contatos.Size = new System.Drawing.Size(860, 484);
            this.Contatos.TabIndex = 14;
            this.Contatos.TabStop = false;
            this.Contatos.Text = "Contatos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1546, 684);
            this.Controls.Add(this.Contatos);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatos)).EndInit();
            this.Contatos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox pegaNome;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox pegaTelefone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pegaCargo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pegaEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pegaDepartamento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dgvContatos;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAlteracao;
        private System.Windows.Forms.GroupBox Contatos;
    }
}

