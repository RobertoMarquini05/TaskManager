using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManager.BLL;

namespace TaskManager.View
{
    public partial class Principal : Form
    {
        #region Campos
        private TarefaManager _tarefaManager;
        #endregion
        public Principal()
        {
            InitializeComponent();
            _tarefaManager = new TarefaManager();
        }

        private void btnCriarTarefa_Click(object sender, EventArgs e)
        {
            CriacaoTarefas criacaoTarefas = new(_tarefaManager);
            criacaoTarefas.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListagemTarefas listagemTarefas = new ListagemTarefas(_tarefaManager);
            listagemTarefas.ShowDialog();
        }
    }
}
