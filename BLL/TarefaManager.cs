using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Data;
using TaskManager.Models;

namespace TaskManager.BLL
{
    public class TarefaManager
    {
        #region Campos
        private List<Tarefa> _listaTarefas;
        private TarefaService _tarefaService;
        #endregion
        #region Construtor
        public TarefaManager() 
        {
            _tarefaService = new TarefaService();
            _listaTarefas = new List<Tarefa>();
        }
        #endregion
        #region Metodos
        public void AddTarefa(Tarefa tarefa)
        {
            _tarefaService.CreateTarefa(tarefa);
        }
        public Tarefa GetTarefaById(Guid id)
        {
            return _tarefaService.GetTarefaById(id);
        }
        public List<Tarefa> GetListaTarefas()
        {
            _listaTarefas = _tarefaService.GetTarefas();
            return _listaTarefas;
        }
        public void AtualizarTarefa(Tarefa tarefa)
        {
            _tarefaService.AtualizarTarefa(tarefa);
        }
        public void DeletarTarefa(Guid id) 
        {
            _tarefaService.DeleteTarefa(id);
        }
        #endregion
    }
}
