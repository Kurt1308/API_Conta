using Adaptador.Interfaces;
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
