using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidade
{
    /// <summary>
    /// Entidade que mapeia tabela conta no banco de dados
    /// </summary>
    public class conta
    {
        /// <summary>
        /// Id da conta
        /// </summary>
        /// <exemplo>10</exemplo>
        [Key]
        public int? id_conta { get; set; }
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
        /// Data do último acesso na conta 
        /// </summary>
        /// <exemplo>2023-01-01</exemplo>
        public string ultimo_acesso { get; set; }
        /// <summary>
        /// Situação atual da conta
        /// </summary>
        /// <exemplo>Ativa; Inativa</exemplo>
        public int? situacao { get; set; }
        /// <summary>
        /// Data da criação da conta 
        /// </summary>
        /// <exemplo>2023-01-01</exemplo>
        public string? data_criacao { get; set; }
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
