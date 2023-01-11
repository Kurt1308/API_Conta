using Adaptador.Interfaces;
using AplicacaoDto.RespostaDto.DtoCartao;
using Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Adaptador.Map
{
    public class MapperCartao : IMapperCartao
    {
        public RespostaGetCartaoDto MapperToDtoCartao(HttpStatusCode codRetorno, string mensagem, List<cartao> cartao = null)
        {
            return new RespostaGetCartaoDto()
            {
                codRetorno = codRetorno,
                Mensagem = mensagem,
                cartoes = cartao
            };
        }

        public RespostaGetByIdCartaoDto MapperToDtoGetCartao(HttpStatusCode codRetorno, string mensagem, cartao item)
        {
            return new RespostaGetByIdCartaoDto
            {
                codRetorno = codRetorno,
                Mensagem = mensagem,
                cartao = item
            };
        }
    }
}
