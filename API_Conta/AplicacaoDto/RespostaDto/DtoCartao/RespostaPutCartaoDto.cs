using Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoDto.RespostaDto.DtoCartao
{
    /// <summary>
    /// Retorna cartão com dados atualizados
    /// </summary>
    public class RespostaPutCartaoDto : RespostaDto
    {
        /// <summary>
        /// Resposta ao inserir, devolve um objeto do tipo conta
        /// </summary>
        public cartao cartao { get; set; }
    }
}
