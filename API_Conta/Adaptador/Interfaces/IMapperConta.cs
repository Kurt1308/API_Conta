using AplicacaoDto.RespostaDto.contaDto;
using AplicacaoDto.RespostaDto.InsertContaDto;
using Dominio.Entidade;
using System.Collections.Generic;
using System.Net;

namespace Adaptador.Interfaces
{
    public interface IMapperConta
    {
        RespostaInsertContaDto MapperToDtoInsert(HttpStatusCode codRetorno, string mensagem, conta conta = null);
        RespostaGetContaDto MapperToDtoConta(HttpStatusCode codRetorno, string mensagem, List<conta> conta = null);
    }
}
