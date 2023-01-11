using Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoDto.RespostaDto.DtoCartao
{
    public class RespostaGetByIdCartaoDto : RespostaDto
    {
        /// <summary>
        /// Resposta que retorna cartão por id
        /// </summary>
        public cartao cartao { get; set; }
    }
}
