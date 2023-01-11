using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoDto.RequisicoesDto.DtoCartao
{
    /// <summary>
    /// Requisição para cadastrar cartão 
    /// </summary>
    public class RequisicaoInsertCartaoDto
    {
        /// <summary>
        /// Número do cartao 
        /// </summary>
        /// <exemplo>20356</exemplo>
        public long num_cartao { get; set; }
        /// <summary>
        /// Código de segurança do cartão
        /// </summary>
        /// <exemplo>365</exemplo>
        public int cvc { get; set; }
        /// <summary>
        /// Id da agencia relacionada a conta
        /// </summary>
        /// <exemplo>2</exemplo>
        public int? agencia_id_agencia { get; set; }
        /// <summary>
        /// Id da conta relacionada ao contão
        /// </summary>
        /// <exemplo>2</exemplo>
        public int? conta_id_conta { get; set; }
    }
}
