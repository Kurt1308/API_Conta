using AplicacaoDto.RequisicoesDto.contaDto;
using AplicacaoDto.RespostaDto.contaDto;
using AplicacaoDto.RespostaDto.InsertContaDto;

namespace Aplicacao.Interface
{
    public interface IAplicacaoConta
    {
        RespostaInsertContaDto Insert(RequisicaoInsertContaDto requisicaoInsertContaDto);
        RespostaGetContaDto GetAllContas();
    }
}
