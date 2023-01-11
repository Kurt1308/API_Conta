using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoDto.RequisicoesDto.DtoCartao
{
    /// <summary>
    /// Requisicão para atualizar cartão
    /// </summary>
    public class RequisicaoPutCartaoDto
    {
        /// <summary>
        /// Id do cartao
        /// </summary>
        /// <exemplo>10</exemplo>
        public int id_cartao { get; set; }
        /// <summary>
        /// Id da agencia relacionada a conta
        /// </summary>
        /// <exemplo>2</exemplo>
        public int agencia_id_agencia { get; set; }
        /// <summary>
        /// Id da conta relacionada ao contão
        /// </summary>
        /// <exemplo>2</exemplo>
        public int conta_id_conta { get; set; }
        /// <summary>
        /// Limite de saldo do cartão
        /// </summary>
        /// <exemplo>1000,00</exemplo>
        public decimal? limite_saldo { get; set; }
        /// <summary>
        /// Situação atual da conta
        /// </summary>
        /// <exemplo>Ativa; Inativa</exemplo>
        public int? situacao { get; set; }
    }
}
