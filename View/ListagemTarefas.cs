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
    public partial class ListagemTarefas : Form
    {
        #region Campos
        private TarefaManager _tarefaManager;
        private List<Tarefa> _listaTarefas;
        #endregion
        public ListagemTarefas(TarefaManager tarefaManager)
        {
            InitializeComponent();
            _tarefaManager = tarefaManager;
        }

        private void ListagemTarefas_Load(object sender, EventArgs e)
        {
            _listaTarefas = _tarefaManager.GetListaTarefas();

            foreach (var tarefa in _listaTarefas)
            {
                dgvTarefas.Rows.Add(tarefa.Id, tarefa.Nome, tarefa.Descricao, tarefa.DataVencimento, tarefa.Prioridade, tarefa.Categoria, tarefa.Concluida, tarefa.CreatedAt);
            }
        }

        private void dgvTarefas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTarefas.Columns[e.ColumnIndex].Name == "Editar")
            {
                var id = dgvTarefas.Rows[e.RowIndex].Cells[0].Value;
                EditarTarefaSelecionada editarTarefa = new(_tarefaManager, id.ToString());
                editarTarefa.ShowDialog();
            }
            else if (dgvTarefas.Columns[e.ColumnIndex].Name == "Excluir")
            {
                var id = dgvTarefas.Rows[e.RowIndex].Cells[0].Value.ToString();
                _tarefaManager.DeletarTarefa(Guid.Parse(id));
                MessageBox.Show("Tarefa excluida com sucesso!", "Tarefa excluida!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
