using Adaptador.Interfaces;
using AplicacaoDto.RespostaDto.contaDto;
using AplicacaoDto.RespostaDto.InsertContaDto;
using Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Adaptador.Map
{
    public class MapperConta : IMapperConta
    {
        public RespostaGetContaDto MapperToDtoConta(HttpStatusCode codRetorno, string mensagem, List<conta> conta = null)
        {
            return new RespostaGetContaDto()
            {
                codRetorno = codRetorno,
                Mensagem = mensagem,
                contas = conta
            };
        }

        public RespostaInsertContaDto MapperToDtoInsert(HttpStatusCode codRetorno, string mensagem, conta conta = null)
        {
            return new RespostaInsertContaDto()
            {
                codRetorno = codRetorno,
                Mensagem = mensagem,
                conta = conta
            };
        }
    }
}
