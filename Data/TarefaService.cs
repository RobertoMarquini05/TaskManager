using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using TaskManager.Models;

namespace TaskManager.Data
{
    public class TarefaService
    {
        #region Campos
        private readonly string _caminhoArquivo;
        #endregion
        #region Constutor
        public TarefaService()
        {
            var rootPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
            _caminhoArquivo = Path.Combine(rootPath, "tarefas.json");
        }
        #endregion
        #region Metodos
        public void CreateTarefa(Tarefa tarefa)
        {
            List<Tarefa> tarefas = new();

            // Se o arquivo já existe, le o conteúdo existente
            if (File.Exists(_caminhoArquivo))
            {
                string jsonExistente = File.ReadAllText(_caminhoArquivo);
                if (!string.IsNullOrWhiteSpace(jsonExistente))
                {
                    tarefas = JsonConvert.DeserializeObject<List<Tarefa>>(jsonExistente) ?? new List<Tarefa>();
                }
            }

            // Adiciona a nova tarefa
            tarefas.Add(tarefa);

            // Serializa e sobrescreve o arquivo
            string novoJson = JsonConvert.SerializeObject(tarefas, Formatting.Indented);
            File.WriteAllText(_caminhoArquivo, novoJson);
        }
        public List<Tarefa> GetTarefas()
        {
            if (!File.Exists(_caminhoArquivo))
            {
                return new List<Tarefa>();
            }

            string json = File.ReadAllText(_caminhoArquivo);

            if (string.IsNullOrWhiteSpace(json))
            {
                return new List<Tarefa>();
            }

            return JsonConvert.DeserializeObject<List<Tarefa>>(json) ?? new List<Tarefa>();
        }
        public Tarefa? GetTarefaById(Guid id)
        {
            var tarefas = GetTarefas();
            return tarefas.FirstOrDefault(t => t.Id == id);
        }
        public bool DeleteTarefa(Guid id)
        {
            var tarefas = GetTarefas();

            // Procura a tarefa pelo ID
            var tarefaParaRemover = tarefas.FirstOrDefault(t => t.Id == id);

            // Se não encontrar, retorna false
            if (tarefaParaRemover == null)
                return false;

            // Remove e salva novamente
            tarefas.Remove(tarefaParaRemover);

            string novoJson = JsonConvert.SerializeObject(tarefas, Formatting.Indented);
            File.WriteAllText(_caminhoArquivo, novoJson);

            return true;
        }
        public void AtualizarTarefa(Tarefa tarefa)
        {
            DeleteTarefa(tarefa.Id);
            CreateTarefa(tarefa);
        }
        #endregion
    }
}
