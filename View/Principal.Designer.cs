namespace TaskManager.View
{
    partial class Principal
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
            btnCriarTarefa = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCriarTarefa
            // 
            btnCriarTarefa.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            btnCriarTarefa.Location = new Point(65, 53);
            btnCriarTarefa.Name = "btnCriarTarefa";
            btnCriarTarefa.Size = new Size(205, 38);
            btnCriarTarefa.TabIndex = 0;
            btnCriarTarefa.Text = "Criar Tarefa";
            btnCriarTarefa.UseVisualStyleBackColor = true;
            btnCriarTarefa.Click += btnCriarTarefa_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            button1.Location = new Point(635, 53);
            button1.Name = "button1";
            button1.Size = new Size(205, 38);
            button1.TabIndex = 1;
            button1.Text = "Listar Tarefas";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.img;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(869, 554);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 578);
            Controls.Add(button1);
            Controls.Add(btnCriarTarefa);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            Name = "Principal";
            Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCriarTarefa;
        private Button button1;
        private PictureBox pictureBox1;
    }
}