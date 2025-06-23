namespace TaskManager.View
{
    partial class CriacaoTarefas
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
            inputTituloTarefa = new MaskedTextBox();
            inputDescricaoTarefa = new MaskedTextBox();
            inputDataVencimento = new MaskedTextBox();
            inputCategoria = new MaskedTextBox();
            cbPrioridade = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // inputTituloTarefa
            // 
            inputTituloTarefa.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            inputTituloTarefa.Location = new Point(325, 6);
            inputTituloTarefa.Name = "inputTituloTarefa";
            inputTituloTarefa.Size = new Size(417, 37);
            inputTituloTarefa.TabIndex = 0;
            // 
            // inputDescricaoTarefa
            // 
            inputDescricaoTarefa.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            inputDescricaoTarefa.Location = new Point(325, 46);
            inputDescricaoTarefa.Name = "inputDescricaoTarefa";
            inputDescricaoTarefa.Size = new Size(417, 37);
            inputDescricaoTarefa.TabIndex = 1;
            // 
            // inputDataVencimento
            // 
            inputDataVencimento.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            inputDataVencimento.Location = new Point(325, 89);
            inputDataVencimento.Mask = "00/00/0000";
            inputDataVencimento.Name = "inputDataVencimento";
            inputDataVencimento.Size = new Size(417, 37);
            inputDataVencimento.TabIndex = 2;
            inputDataVencimento.TextAlign = HorizontalAlignment.Center;
            inputDataVencimento.ValidatingType = typeof(DateTime);
            // 
            // inputCategoria
            // 
            inputCategoria.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            inputCategoria.Location = new Point(325, 176);
            inputCategoria.Name = "inputCategoria";
            inputCategoria.Size = new Size(417, 37);
            inputCategoria.TabIndex = 4;
            // 
            // cbPrioridade
            // 
            cbPrioridade.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            cbPrioridade.FormattingEnabled = true;
            cbPrioridade.Items.AddRange(new object[] { "Alta", "Media", "Baixa" });
            cbPrioridade.Location = new Point(325, 132);
            cbPrioridade.Name = "cbPrioridade";
            cbPrioridade.Size = new Size(417, 38);
            cbPrioridade.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(265, 30);
            label1.TabIndex = 6;
            label1.Text = "Digite o titulo da tarefa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(307, 30);
            label2.TabIndex = 7;
            label2.Text = "Digite a descrição da tarefa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 96);
            label3.Name = "label3";
            label3.Size = new Size(301, 30);
            label3.TabIndex = 8;
            label3.Text = "Digite a data de vencimento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 140);
            label4.Name = "label4";
            label4.Size = new Size(241, 30);
            label4.TabIndex = 9;
            label4.Text = "Selecione a prioridade";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 183);
            label5.Name = "label5";
            label5.Size = new Size(198, 30);
            label5.TabIndex = 10;
            label5.Text = "Digite a categoria";
            // 
            // button1
            // 
            button1.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            button1.Location = new Point(228, 236);
            button1.Name = "button1";
            button1.Size = new Size(349, 37);
            button1.TabIndex = 11;
            button1.Text = "Criar Tarefa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CriacaoTarefas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 283);
            Controls.Add(button1);
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
            Name = "CriacaoTarefas";
            Text = "CriacaoTarefas";
            Load += CriacaoTarefas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox inputTituloTarefa;
        private MaskedTextBox inputDescricaoTarefa;
        private MaskedTextBox inputDataVencimento;
        private MaskedTextBox inputCategoria;
        private ComboBox cbPrioridade;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
    }
}