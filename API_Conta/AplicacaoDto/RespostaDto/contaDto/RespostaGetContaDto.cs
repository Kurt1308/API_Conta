using Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoDto.RespostaDto.contaDto
{
    public class RespostaGetContaDto : RespostaDto
    {
        /// <summary>
        /// Resposta que retorna uma lista com todas as contas cadastradas
        /// </summary>
        public List<conta> contas { get; set; }
    }
}
