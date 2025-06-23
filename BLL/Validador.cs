using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.BLL
{
    public class Validador
    {
        public bool ValidaEntradaDados(string titulo, DateTime dataVencimento)
        {
            bool tituloValidado = ValidaTitulo(titulo);
            bool dataVencimentoValidado = ValidaDataVencimento(dataVencimento);

            if (!tituloValidado)
            {
                MessageBox.Show("Verifique o titulo informado", "Favor verificar titulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!dataVencimentoValidado)
            {
                MessageBox.Show("Verifique a data de vencimento informada", "Favor verificar data de vencimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }
        
        public bool ValidaTitulo(string titulo)
        {
            return titulo != string.Empty ? true : false;
        }
        public bool ValidaDataVencimento(DateTime dataVencimento)
        {
            return dataVencimento > DateTime.UtcNow ? true : false;
        }
    }
}
