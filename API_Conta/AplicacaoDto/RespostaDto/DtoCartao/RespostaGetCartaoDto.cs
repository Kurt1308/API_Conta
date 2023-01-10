using Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoDto.RespostaDto.DtoCartao
{
    /// <summary>
    /// Retorna uma lista com cartões cadastrados
    /// </summary>
    public class RespostaGetCartaoDto : RespostaDto
    {
        /// <summary>
        /// Resposta que retorna uma lista com todos os cartoes cadastrados
        /// </summary>
        public List<cartao> cartoes { get; set; }
    }
}
