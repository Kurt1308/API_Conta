using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoDto.RequisicoesDto.contaDto
{
    /// <summary>
    /// Requisição para obter dados da conta por id 
    /// </summary>
    public class RequisicaoGetByIdContaDto
    {
        /// <summary>
        /// Id da agência 
        /// </summary>
        /// <exemplo>20356</exemplo>
        public int fkAgencia { get; set; }
        /// <summary>
        /// Id da conta 
        /// </summary>
        /// <exemplo>20356</exemplo>
        public int idConta { get; set; }
    }
}
