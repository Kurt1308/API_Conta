using Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoDto.RespostaDto.DtoCartao
{
    /// <summary>
    /// Resposta que retorna um objeto e uma mensagem relacionados ao cartão cadastrado
    /// </summary>
    public class RespostaInsertCartaoDto : RespostaDto
    {
        /// <summary>
        /// Resposta que retorna cartão 
        /// </summary>
        public cartao cartao { get; set; }
    }
}
