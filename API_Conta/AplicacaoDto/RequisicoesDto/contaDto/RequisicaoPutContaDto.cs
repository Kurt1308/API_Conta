using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoDto.RequisicoesDto.contaDto
{
    /// <summary>
    /// Requisição para atualizar conta
    /// </summary>
    public class RequisicaoPutContaDto
    {
        /// <summary>
        /// Id da conta 
        /// </summary>
        /// <exemplo>20356</exemplo>
        public int idConta { get; set; }
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
    }
}
