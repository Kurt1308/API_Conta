using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoDto.RequisicoesDto.DtoCartao
{
    /// <summary>
    /// Requisição para obter dados do cartao por id 
    /// </summary>
    public class RequisicaoGetByIdCartaoDto
    {
        /// <summary>
        /// Id do cartao
        /// </summary>
        /// <exemplo>10</exemplo>
        public int id_cartao { get; set; }
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
