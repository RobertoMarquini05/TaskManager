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
    public partial class EditarTarefaSelecionada : Form
    {
        #region Campos
        private Conversor _conversor;
        private Validador _validador;
        private TarefaManager _tarefaManager;
        private string _idTarefaASerEditada;
        private Tarefa _tarefaASerEditada;
        #endregion
        #region Constutor
        public EditarTarefaSelecionada(TarefaManager tarefaManager, string idTarefaASerEditada)
        {
            InitializeComponent();
            _tarefaManager = tarefaManager;
            _conversor = new Conversor();
            _validador = new Validador();
            _idTarefaASerEditada = idTarefaASerEditada;
        }
        #endregion
        #region Metodos
        private void btnEditarTarefa_Click(object sender, EventArgs e)
        {
            if (_validador.ValidaEntradaDados(inputTituloTarefa.Text, _conversor.ConverteDateTime(inputDataVencimento.Text)))
            {
                Tarefa tarefa = new Tarefa(_idTarefaASerEditada, inputTituloTarefa.Text, inputDescricaoTarefa.Text, _conversor.ConverteDateTime(inputDataVencimento.Text), _conversor.ConvertePrioridade(cbPrioridade.Text), inputCategoria.Text);
                MessageBox.Show("Tarefa editada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _tarefaManager.AtualizarTarefa(tarefa);

                this.Close();
            }
        }
        private void EditarTarefaSelecionada_Load(object sender, EventArgs e)
        {
            // Pegando no arquivo JSON os valores da tarefa a ser editada
            _tarefaASerEditada = _tarefaManager.GetTarefaById(Guid.Parse(_idTarefaASerEditada));

            // Colocando os valores na tela
            inputTituloTarefa.Text = _tarefaASerEditada.Nome;
            inputDescricaoTarefa.Text = _tarefaASerEditada.Descricao;
            inputDataVencimento.Text = _tarefaASerEditada.DataVencimento.Date.ToString();
            cbPrioridade.Text = _tarefaASerEditada.Prioridade.ToString();
            inputCategoria.Text = _tarefaASerEditada.Categoria;
        }
        #endregion
    }
}
