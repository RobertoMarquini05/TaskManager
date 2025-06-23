using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Models.Enums;

namespace TaskManager.BLL
{
    public class Conversor
    {
        public DateTime ConverteDateTime(string dataParaConverter)
        {
            DateTime.TryParse(dataParaConverter, out DateTime result);
            return result;  
        }
        public Prioridade ConvertePrioridade(string prioridade)
        {
            switch (prioridade)
            {
                case "Alta": return Prioridade.Alta;
                case "Media": return Prioridade.Media;
                case "Baixa": return Prioridade.Baixa;
                default: return Prioridade.Indefinido;
            }
        }
    }
}
