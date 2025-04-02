namespace CadastroAlunos
{
    partial class cadastroAlunos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbInfos = new GroupBox();
            mskdTelefone = new MaskedTextBox();
            mskdDataNascimento = new MaskedTextBox();
            txtCurso = new TextBox();
            txtNome = new TextBox();
            lblTelefone = new Label();
            lblCurso = new Label();
            lblDataNascimento = new Label();
            lblNome = new Label();
            gbBotoes = new GroupBox();
            GrindView = new DataGridView();
            btnLimpar = new Button();
            btnExcluir = new Button();
            btnEditar = new Button();
            btnListar = new Button();
            btnCadastrar = new Button();
            gbInfos.SuspendLayout();
            gbBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GrindView).BeginInit();
            SuspendLayout();
            // 
            // gbInfos
            // 
            gbInfos.Controls.Add(mskdTelefone);
            gbInfos.Controls.Add(mskdDataNascimento);
            gbInfos.Controls.Add(txtCurso);
            gbInfos.Controls.Add(txtNome);
            gbInfos.Controls.Add(lblTelefone);
            gbInfos.Controls.Add(lblCurso);
            gbInfos.Controls.Add(lblDataNascimento);
            gbInfos.Controls.Add(lblNome);
            gbInfos.Location = new Point(54, 34);
            gbInfos.Name = "gbInfos";
            gbInfos.Size = new Size(701, 303);
            gbInfos.TabIndex = 0;
            gbInfos.TabStop = false;
            gbInfos.Text = "Informações Pessoais";
            // 
            // mskdTelefone
            // 
            mskdTelefone.Location = new Point(421, 197);
            mskdTelefone.Mask = "(00) 00000-0000";
            mskdTelefone.Name = "mskdTelefone";
            mskdTelefone.Size = new Size(143, 35);
            mskdTelefone.TabIndex = 6;
            mskdTelefone.MaskInputRejected += mskdTelefone_MaskInputRejected;
            // 
            // mskdDataNascimento
            // 
            mskdDataNascimento.Location = new Point(421, 93);
            mskdDataNascimento.Mask = "00/00/0000";
            mskdDataNascimento.Name = "mskdDataNascimento";
            mskdDataNascimento.Size = new Size(143, 35);
            mskdDataNascimento.TabIndex = 5;
            mskdDataNascimento.MaskInputRejected += mskdDataNascimento_MaskInputRejected;
            // 
            // txtCurso
            // 
            txtCurso.Location = new Point(22, 197);
            txtCurso.Name = "txtCurso";
            txtCurso.Size = new Size(312, 35);
            txtCurso.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(22, 93);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(312, 35);
            txtNome.TabIndex = 1;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(421, 162);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(90, 29);
            lblTelefone.TabIndex = 3;
            lblTelefone.Text = "Telefone";
            // 
            // lblCurso
            // 
            lblCurso.AutoSize = true;
            lblCurso.Location = new Point(22, 165);
            lblCurso.Name = "lblCurso";
            lblCurso.Size = new Size(66, 29);
            lblCurso.TabIndex = 2;
            lblCurso.Text = "Curso";
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.Location = new Point(415, 60);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(189, 29);
            lblDataNascimento.TabIndex = 1;
            lblDataNascimento.Text = "Data de Nascimento";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(25, 60);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(65, 29);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // gbBotoes
            // 
            gbBotoes.Controls.Add(GrindView);
            gbBotoes.Controls.Add(btnLimpar);
            gbBotoes.Controls.Add(btnExcluir);
            gbBotoes.Controls.Add(btnEditar);
            gbBotoes.Controls.Add(btnListar);
            gbBotoes.Controls.Add(btnCadastrar);
            gbBotoes.Location = new Point(54, 339);
            gbBotoes.Name = "gbBotoes";
            gbBotoes.Size = new Size(701, 325);
            gbBotoes.TabIndex = 0;
            gbBotoes.TabStop = false;
            gbBotoes.Enter += groupBox2_Enter;
            // 
            // GrindView
            // 
            GrindView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrindView.Location = new Point(7, 79);
            GrindView.Name = "GrindView";
            GrindView.RowHeadersWidth = 62;
            GrindView.Size = new Size(688, 239);
            GrindView.TabIndex = 10;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(571, 22);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(123, 39);
            btnLimpar.TabIndex = 9;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(441, 22);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(123, 39);
            btnExcluir.TabIndex = 8;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(287, 22);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(123, 39);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(136, 22);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(123, 39);
            btnListar.TabIndex = 6;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(7, 22);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(123, 39);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // cadastroAlunos
            // 
            AutoScaleDimensions = new SizeF(11F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 688);
            Controls.Add(gbBotoes);
            Controls.Add(gbInfos);
            Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "cadastroAlunos";
            Text = "Cadastro de Alunos";
            gbInfos.ResumeLayout(false);
            gbInfos.PerformLayout();
            gbBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GrindView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbInfos;
        private TextBox txtCurso;
        private TextBox txtNome;
        private Label lblTelefone;
        private Label lblCurso;
        private Label lblDataNascimento;
        private Label lblNome;
        private GroupBox gbBotoes;
        private Button btnLimpar;
        private Button btnExcluir;
        private Button btnEditar;
        private Button btnListar;
        private Button btnCadastrar;
        private DataGridView GrindView;
        private MaskedTextBox mskdDataNascimento;
        private MaskedTextBox mskdTelefone;
    }
}
