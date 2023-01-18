using Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoDto.RespostaDto.DtoCartao
{
    /// <summary>
    /// Resposta com um cartão filtrado por id
    /// </summary>
    public class RespostaGetByIdCartaoDto : RespostaDto
    {
        /// <summary>
        /// Resposta que retorna cartão por id
        /// </summary>
        public cartao cartao { get; set; }
    }
}
