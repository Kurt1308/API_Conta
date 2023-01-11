using AplicacaoDto.RequisicoesDto.DtoCartao;
using AplicacaoDto.RespostaDto.DtoCartao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Interface
{
    public interface IAplicacaoCartao
    {
        RespostaInsertCartaoDto Insert(RequisicaoInsertCartaoDto requisicaoInsertCartaoDto);
        RespostaGetCartaoDto GetAllCartoes();
        RespostaGetByIdCartaoDto GetCartaoById(RequisicaoGetByIdCartaoDto dto);
    }
}
