using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidade
{
    /// <summary>
    /// Entidade que mapeia tabela agencia no banco de dados
    /// </summary>
    public class agencia
    {
        /// <summary>
        /// Id da agencia
        /// </summary>
        /// <exemplo>1</exemplo>
        public long? id_agencia { get; set; }
        
        /// <summary>
        /// Número da agencia
        /// </summary>
        /// <exemplo>6208-0</exemplo>
        public string num_agencia { get; set; }
    }
}
