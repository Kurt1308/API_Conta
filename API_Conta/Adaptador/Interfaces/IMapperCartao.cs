﻿using AplicacaoDto.RespostaDto.DtoCartao;
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
        RespostaPutCartaoDto MapperToDtoPut(HttpStatusCode codRetorno, string mensagem, cartao cartao = null);
        RespostaInsertCartaoDto MapperToDtoInsert(HttpStatusCode codRetorno, string mensagem, cartao cartao = null);
        RespostaGetCartaoDto MapperToDtoCartao(HttpStatusCode codRetorno, string mensagem, List<cartao> conta = null);
        RespostaGetByIdCartaoDto MapperToDtoGetCartao(HttpStatusCode codRetorno, string mensagem, cartao item);
    }
}
