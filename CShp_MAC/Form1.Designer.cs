namespace CShp_MAC
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.btnLocalizarDados = new System.Windows.Forms.Button();
            this.btnExcluirDados = new System.Windows.Forms.Button();
            this.btnAtualizarDados = new System.Windows.Forms.Button();
            this.btnIncluirDados = new System.Windows.Forms.Button();
            this.btnExibirDados = new System.Windows.Forms.Button();
            this.btnCriarTabela = new System.Windows.Forms.Button();
            this.btnCriarBancoDados = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvDados);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 362);
            this.panel1.TabIndex = 0;
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.GridColor = System.Drawing.Color.White;
            this.dgvDados.Location = new System.Drawing.Point(184, 22);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(298, 177);
            this.dgvDados.TabIndex = 6;
            this.dgvDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellContentClick);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(122, 320);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(512, 20);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(122, 227);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(252, 20);
            this.txtID.TabIndex = 4;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(122, 274);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(512, 20);
            this.txtNome.TabIndex = 3;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(29, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(30, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(31, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEncerrar);
            this.panel2.Controls.Add(this.btnLocalizarDados);
            this.panel2.Controls.Add(this.btnExcluirDados);
            this.panel2.Controls.Add(this.btnAtualizarDados);
            this.panel2.Controls.Add(this.btnIncluirDados);
            this.panel2.Controls.Add(this.btnExibirDados);
            this.panel2.Controls.Add(this.btnCriarTabela);
            this.panel2.Controls.Add(this.btnCriarBancoDados);
            this.panel2.Location = new System.Drawing.Point(0, 360);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(666, 158);
            this.panel2.TabIndex = 1;
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.BackColor = System.Drawing.Color.Indigo;
            this.btnEncerrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncerrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEncerrar.Location = new System.Drawing.Point(488, 84);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(146, 43);
            this.btnEncerrar.TabIndex = 7;
            this.btnEncerrar.Text = "Encerrar";
            this.btnEncerrar.UseVisualStyleBackColor = false;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // btnLocalizarDados
            // 
            this.btnLocalizarDados.BackColor = System.Drawing.Color.Indigo;
            this.btnLocalizarDados.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLocalizarDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizarDados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLocalizarDados.Location = new System.Drawing.Point(336, 84);
            this.btnLocalizarDados.Name = "btnLocalizarDados";
            this.btnLocalizarDados.Size = new System.Drawing.Size(146, 43);
            this.btnLocalizarDados.TabIndex = 6;
            this.btnLocalizarDados.Text = "Localizar Dados";
            this.btnLocalizarDados.UseVisualStyleBackColor = false;
            this.btnLocalizarDados.Click += new System.EventHandler(this.btnLocalizarDados_Click);
            // 
            // btnExcluirDados
            // 
            this.btnExcluirDados.BackColor = System.Drawing.Color.Indigo;
            this.btnExcluirDados.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnExcluirDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirDados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExcluirDados.Location = new System.Drawing.Point(184, 84);
            this.btnExcluirDados.Name = "btnExcluirDados";
            this.btnExcluirDados.Size = new System.Drawing.Size(146, 43);
            this.btnExcluirDados.TabIndex = 5;
            this.btnExcluirDados.Text = "Excluir Dados";
            this.btnExcluirDados.UseVisualStyleBackColor = false;
            this.btnExcluirDados.Click += new System.EventHandler(this.btnExcluirDados_Click);
            // 
            // btnAtualizarDados
            // 
            this.btnAtualizarDados.BackColor = System.Drawing.Color.Indigo;
            this.btnAtualizarDados.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAtualizarDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarDados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAtualizarDados.Location = new System.Drawing.Point(32, 84);
            this.btnAtualizarDados.Name = "btnAtualizarDados";
            this.btnAtualizarDados.Size = new System.Drawing.Size(146, 43);
            this.btnAtualizarDados.TabIndex = 4;
            this.btnAtualizarDados.Text = "Atualizar Dados";
            this.btnAtualizarDados.UseVisualStyleBackColor = false;
            this.btnAtualizarDados.Click += new System.EventHandler(this.btnAtualizarDados_Click);
            // 
            // btnIncluirDados
            // 
            this.btnIncluirDados.BackColor = System.Drawing.Color.Indigo;
            this.btnIncluirDados.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnIncluirDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirDados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIncluirDados.Location = new System.Drawing.Point(488, 23);
            this.btnIncluirDados.Name = "btnIncluirDados";
            this.btnIncluirDados.Size = new System.Drawing.Size(146, 43);
            this.btnIncluirDados.TabIndex = 3;
            this.btnIncluirDados.Text = "Incluir Dados";
            this.btnIncluirDados.UseVisualStyleBackColor = false;
            this.btnIncluirDados.Click += new System.EventHandler(this.btnIncluirDados_Click);
            // 
            // btnExibirDados
            // 
            this.btnExibirDados.BackColor = System.Drawing.Color.Indigo;
            this.btnExibirDados.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnExibirDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirDados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExibirDados.Location = new System.Drawing.Point(336, 23);
            this.btnExibirDados.Name = "btnExibirDados";
            this.btnExibirDados.Size = new System.Drawing.Size(146, 43);
            this.btnExibirDados.TabIndex = 2;
            this.btnExibirDados.Text = "Exibir Dados";
            this.btnExibirDados.UseVisualStyleBackColor = false;
            this.btnExibirDados.Click += new System.EventHandler(this.btnExibirDados_Click);
            // 
            // btnCriarTabela
            // 
            this.btnCriarTabela.BackColor = System.Drawing.Color.Indigo;
            this.btnCriarTabela.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCriarTabela.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnCriarTabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarTabela.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCriarTabela.Location = new System.Drawing.Point(184, 23);
            this.btnCriarTabela.Name = "btnCriarTabela";
            this.btnCriarTabela.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCriarTabela.Size = new System.Drawing.Size(146, 43);
            this.btnCriarTabela.TabIndex = 1;
            this.btnCriarTabela.Text = "Criar Tabela";
            this.btnCriarTabela.UseVisualStyleBackColor = false;
            this.btnCriarTabela.Click += new System.EventHandler(this.btnCriarTabela_Click);
            // 
            // btnCriarBancoDados
            // 
            this.btnCriarBancoDados.BackColor = System.Drawing.Color.Indigo;
            this.btnCriarBancoDados.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCriarBancoDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarBancoDados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCriarBancoDados.Location = new System.Drawing.Point(32, 23);
            this.btnCriarBancoDados.Name = "btnCriarBancoDados";
            this.btnCriarBancoDados.Size = new System.Drawing.Size(146, 43);
            this.btnCriarBancoDados.TabIndex = 0;
            this.btnCriarBancoDados.Text = "Criar Banco de Dados";
            this.btnCriarBancoDados.UseVisualStyleBackColor = false;
            this.btnCriarBancoDados.Click += new System.EventHandler(this.btnCriarBancoDados_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(667, 518);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.Button btnLocalizarDados;
        private System.Windows.Forms.Button btnExcluirDados;
        private System.Windows.Forms.Button btnAtualizarDados;
        private System.Windows.Forms.Button btnIncluirDados;
        private System.Windows.Forms.Button btnExibirDados;
        private System.Windows.Forms.Button btnCriarTabela;
        private System.Windows.Forms.Button btnCriarBancoDados;
        private System.Windows.Forms.DataGridView dgvDados;
    }
}

