using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TaskManager.Models.Enums;

namespace TaskManager.Models
{
    public class Tarefa
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string? Descricao { get; set; }
        public DateTime DataVencimento { get; set; }
        public Prioridade Prioridade { get; set; }
        public string Categoria { get; set; }
        public bool Concluida { get; set; }
        public DateTime CreatedAt { get; set; }
        [JsonConstructor]
        public Tarefa(string nome, string? descricao, DateTime dataVencimento, Prioridade prioridade,
            string categoria)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Descricao = descricao;
            DataVencimento = dataVencimento;
            Prioridade = prioridade;
            Categoria = categoria;
            Concluida = false;
            CreatedAt = DateTime.Now.Date;
        }
        public Tarefa(string id, string nome, string? descricao, DateTime dataVencimento, Prioridade prioridade,
            string categoria)
        {
            Id = Guid.Parse(id);
            Nome = nome;
            Descricao = descricao;
            DataVencimento = dataVencimento;
            Prioridade = prioridade;
            Categoria = categoria;
            Concluida = false;
            CreatedAt = DateTime.Now.Date;
        }
    }
}
