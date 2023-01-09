using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoDto.RequisicoesDto.contaDto
{
    /// <summary>
    /// Requisição para cadastrar conta
    /// </summary>
    public class RequisicaoInsertContaDto
    {
        /// <summary>
        /// Número da conta 
        /// </summary>
        /// <exemplo>20356</exemplo>
        public int num_conta { get; set; }
        /// <summary>
        /// Nome do titular da conta
        /// </summary>
        /// <exemplo>Lucas Dias</exemplo>
        public string nome_titular { get; set; }
        /// <summary>
        /// Tipo de conta 
        /// </summary>
        /// <exemplo>Pessoa física; Pessoal jurídica</exemplo>
        public string tipo_conta { get; set; }
        /// <summary>
        /// Situação atual da conta
        /// </summary>
        /// <exemplo>Ativa; Inativa</exemplo>
        public int situacao { get; set; }
        /// <summary>
        /// Número do cpf ou cnpj caso seja pessoa física ou jurídica
        /// </summary>
        /// <exemplo>101.251.452-65</exemplo>
        public string identificador { get; set; }
        /// <summary>
        /// Id da agencia relacionada a conta
        /// </summary>
        /// <exemplo>2</exemplo>
        public int? agencia_id_agencia { get; set; }
    }
}
