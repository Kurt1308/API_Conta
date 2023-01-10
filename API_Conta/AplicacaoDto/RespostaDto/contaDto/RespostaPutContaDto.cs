using Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoDto.RespostaDto.contaDto
{
    /// <summary>
    /// Requisição para atualizar conta
    /// </summary>
    public class RespostaPutContaDto : RespostaDto
    {
        /// <summary>
        /// Resposta ao inserir, devolve um objeto do tipo conta
        /// </summary>
        public conta conta { get; set; }
    }
}
