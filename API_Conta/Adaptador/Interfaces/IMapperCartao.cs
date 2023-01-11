using AplicacaoDto.RespostaDto.DtoCartao;
using Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Adaptador.Interfaces
{
    public interface IMapperCartao
    {
        RespostaGetCartaoDto MapperToDtoCartao(HttpStatusCode codRetorno, string mensagem, List<cartao> conta = null);
        RespostaGetByIdCartaoDto MapperToDtoGetCartao(HttpStatusCode codRetorno, string mensagem, cartao item);
    }
}
