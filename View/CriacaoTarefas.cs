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
using TaskManager.Models;

namespace TaskManager.View
{
    public partial class CriacaoTarefas : Form
    {
        #region Campos
        private Conversor _conversor;
        private Validador _validador;
        private TarefaManager _tarefaManager;
        #endregion
        #region Constutor
        public CriacaoTarefas(TarefaManager tarefaManager)
        {
            InitializeComponent();
            _tarefaManager = tarefaManager;
            _conversor = new Conversor();
            _validador = new Validador();
        }
        #endregion
        #region Metodos
        private void CriacaoTarefas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_validador.ValidaEntradaDados(inputTituloTarefa.Text, _conversor.ConverteDateTime(inputDataVencimento.Text))){
                Tarefa tarefa = new Tarefa(inputTituloTarefa.Text, inputDescricaoTarefa.Text ,_conversor.ConverteDateTime(inputDataVencimento.Text), _conversor.ConvertePrioridade(cbPrioridade.Text),inputCategoria.Text);
                MessageBox.Show("Tarefa criada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _tarefaManager.AddTarefa(tarefa);
                this.Close();
            }
        }
        #endregion
    }
}
