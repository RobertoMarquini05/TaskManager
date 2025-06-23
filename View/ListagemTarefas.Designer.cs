namespace TaskManager.View
{
    partial class ListagemTarefas
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
            dgvTarefas = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            DataVencimento = new DataGridViewTextBoxColumn();
            Prioridade = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Concluida = new DataGridViewTextBoxColumn();
            CreatedAt = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewButtonColumn();
            Excluir = new DataGridViewButtonColumn();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTarefas).BeginInit();
            SuspendLayout();
            // 
            // dgvTarefas
            // 
            dgvTarefas.AllowUserToAddRows = false;
            dgvTarefas.AllowUserToDeleteRows = false;
            dgvTarefas.AllowUserToOrderColumns = true;
            dgvTarefas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTarefas.Columns.AddRange(new DataGridViewColumn[] { id, Nome, Descricao, DataVencimento, Prioridade, Categoria, Concluida, CreatedAt, Editar, Excluir });
            dgvTarefas.Location = new Point(12, 12);
            dgvTarefas.Name = "dgvTarefas";
            dgvTarefas.Size = new Size(1199, 349);
            dgvTarefas.TabIndex = 0;
            dgvTarefas.CellContentClick += dgvTarefas_CellContentClick;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.Name = "id";
            id.Visible = false;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 150;
            // 
            // Descricao
            // 
            Descricao.HeaderText = "Descricao";
            Descricao.Name = "Descricao";
            Descricao.ReadOnly = true;
            Descricao.Width = 200;
            // 
            // DataVencimento
            // 
            DataVencimento.HeaderText = "Data de Vencimento";
            DataVencimento.Name = "DataVencimento";
            DataVencimento.ReadOnly = true;
            DataVencimento.Width = 150;
            // 
            // Prioridade
            // 
            Prioridade.HeaderText = "Prioridade";
            Prioridade.Name = "Prioridade";
            Prioridade.ReadOnly = true;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            // 
            // Concluida
            // 
            Concluida.HeaderText = "Concluida";
            Concluida.Name = "Concluida";
            Concluida.ReadOnly = true;
            // 
            // CreatedAt
            // 
            CreatedAt.HeaderText = "Criado Em";
            CreatedAt.Name = "CreatedAt";
            CreatedAt.ReadOnly = true;
            CreatedAt.Width = 150;
            // 
            // Editar
            // 
            Editar.HeaderText = "Editar";
            Editar.Name = "Editar";
            // 
            // Excluir
            // 
            Excluir.HeaderText = "Excluir";
            Excluir.Name = "Excluir";
            // 
            // button1
            // 
            button1.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            button1.Location = new Point(452, 376);
            button1.Name = "button1";
            button1.Size = new Size(323, 39);
            button1.TabIndex = 1;
            button1.Text = "Fechar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ListagemTarefas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1220, 427);
            Controls.Add(button1);
            Controls.Add(dgvTarefas);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ListagemTarefas";
            Text = "ListagemTarefas";
            Load += ListagemTarefas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTarefas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvTarefas;
        private Button button1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewTextBoxColumn DataVencimento;
        private DataGridViewTextBoxColumn Prioridade;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Concluida;
        private DataGridViewTextBoxColumn CreatedAt;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Excluir;
    }
}