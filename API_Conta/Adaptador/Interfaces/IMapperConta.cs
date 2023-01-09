using AplicacaoDto.RespostaDto.InsertContaDto;
using Dominio.Entidade;
using System.Net;

namespace Adaptador.Interfaces
{
    public interface IMapperConta
    {
        RespostaInsertContaDto MapperToDtoInsert(HttpStatusCode codRetorno, string mensagem, conta conta = null);
    }
}
