namespace TaskManager.View
{
    partial class EditarTarefaSelecionada
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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cbPrioridade = new ComboBox();
            inputCategoria = new MaskedTextBox();
            inputDataVencimento = new MaskedTextBox();
            inputDescricaoTarefa = new MaskedTextBox();
            inputTituloTarefa = new MaskedTextBox();
            btnEditarTarefa = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 189);
            label5.Name = "label5";
            label5.Size = new Size(198, 30);
            label5.TabIndex = 20;
            label5.Text = "Digite a categoria";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 146);
            label4.Name = "label4";
            label4.Size = new Size(241, 30);
            label4.TabIndex = 19;
            label4.Text = "Selecione a prioridade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 102);
            label3.Name = "label3";
            label3.Size = new Size(301, 30);
            label3.TabIndex = 18;
            label3.Text = "Digite a data de vencimento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(307, 30);
            label2.TabIndex = 17;
            label2.Text = "Digite a descrição da tarefa";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(265, 30);
            label1.TabIndex = 16;
            label1.Text = "Digite o titulo da tarefa";
            // 
            // cbPrioridade
            // 
            cbPrioridade.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            cbPrioridade.FormattingEnabled = true;
            cbPrioridade.Items.AddRange(new object[] { "Alta", "Media", "Baixa" });
            cbPrioridade.Location = new Point(325, 138);
            cbPrioridade.Name = "cbPrioridade";
            cbPrioridade.Size = new Size(417, 38);
            cbPrioridade.TabIndex = 15;
            // 
            // inputCategoria
            // 
            inputCategoria.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            inputCategoria.Location = new Point(325, 182);
            inputCategoria.Name = "inputCategoria";
            inputCategoria.Size = new Size(417, 37);
            inputCategoria.TabIndex = 14;
            // 
            // inputDataVencimento
            // 
            inputDataVencimento.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            inputDataVencimento.Location = new Point(325, 95);
            inputDataVencimento.Mask = "00/00/0000";
            inputDataVencimento.Name = "inputDataVencimento";
            inputDataVencimento.Size = new Size(417, 37);
            inputDataVencimento.TabIndex = 13;
            inputDataVencimento.TextAlign = HorizontalAlignment.Center;
            inputDataVencimento.ValidatingType = typeof(DateTime);
            // 
            // inputDescricaoTarefa
            // 
            inputDescricaoTarefa.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            inputDescricaoTarefa.Location = new Point(325, 52);
            inputDescricaoTarefa.Name = "inputDescricaoTarefa";
            inputDescricaoTarefa.Size = new Size(417, 37);
            inputDescricaoTarefa.TabIndex = 12;
            // 
            // inputTituloTarefa
            // 
            inputTituloTarefa.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            inputTituloTarefa.Location = new Point(325, 12);
            inputTituloTarefa.Name = "inputTituloTarefa";
            inputTituloTarefa.Size = new Size(417, 37);
            inputTituloTarefa.TabIndex = 11;
            // 
            // btnEditarTarefa
            // 
            btnEditarTarefa.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            btnEditarTarefa.Location = new Point(229, 240);
            btnEditarTarefa.Name = "btnEditarTarefa";
            btnEditarTarefa.Size = new Size(349, 37);
            btnEditarTarefa.TabIndex = 21;
            btnEditarTarefa.Text = "Editar Tarefa";
            btnEditarTarefa.UseVisualStyleBackColor = true;
            btnEditarTarefa.Click += btnEditarTarefa_Click;
            // 
            // EditarTarefaSelecionada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 280);
            Controls.Add(btnEditarTarefa);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbPrioridade);
            Controls.Add(inputCategoria);
            Controls.Add(inputDataVencimento);
            Controls.Add(inputDescricaoTarefa);
            Controls.Add(inputTituloTarefa);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditarTarefaSelecionada";
            Text = "EditarTarefaSelecionada";
            Load += EditarTarefaSelecionada_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cbPrioridade;
        private MaskedTextBox inputCategoria;
        private MaskedTextBox inputDataVencimento;
        private MaskedTextBox inputDescricaoTarefa;
        private MaskedTextBox inputTituloTarefa;
        private Button btnEditarTarefa;
    }
}