﻿using Aplicacao.Interface;
using AplicacaoDto.RequisicoesDto.DtoCartao;
using AplicacaoDto.RespostaDto.DtoCartao;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API_Conta.Controllers
{
    public class CRUDCartaoController : Controller
    {
        private readonly IAplicacaoCartao _aplicacaoCartao;

        public CRUDCartaoController(IAplicacaoCartao aplicacaoCartao)
        {
            _aplicacaoCartao = aplicacaoCartao;
        }
        /// <summary>
        /// Endpoint que retorna todos os cartões cadastrados
        /// </summary>
        /// <response code="200">Busca realizada com sucesso</response>
        /// <response code="400">Campos obrigatórios não informados</response>
        /// <response code="401">Acesso não autenticado</response>
        /// <response code="403">Acesso não autorizado</response>
        /// <response code="404">Consulta não retornou dados</response>
        /// <response code="500">Erro interno na aplicação, vide campo mensagem</response>
        [ProducesResponseType(typeof(RespostaGetCartaoDto), 200)]
        [ProducesResponseType(typeof(RespostaGetCartaoDto), 404)]
        [ProducesResponseType(typeof(RespostaGetCartaoDto), 500)]
        [AllowAnonymous]
        [HttpGet]
        [Route("GetTodosOsCartoes")]
        public RespostaGetCartaoDto GetAllContas()
        {
            return _aplicacaoCartao.GetAllCartoes();
        }
        /// <summary>
        /// Endpoint para consultar um determinado Cartão
        /// </summary>
        /// <param name="dto"></param>
        /// <returns>Retorna XXX</returns>
        /// <response code="200">Esta requisição foi bem sucedida</response>
        /// <response code="400">O servidor não entendeu a requisição pois está com uma sintaxe inválida</response>
        /// <response code="422">Erro de validação de conteúdo, código não localizado</response>
        /// <response code="500">Erro interno na aplicação, vide campo mensagem</response>
        [ProducesResponseType(typeof(RespostaGetByIdCartaoDto), 200)]
        [ProducesResponseType(typeof(RespostaGetByIdCartaoDto), 400)]
        [ProducesResponseType(typeof(RespostaGetByIdCartaoDto), 422)]
        [ProducesResponseType(typeof(RespostaGetByIdCartaoDto), 500)]
        [AllowAnonymous]
        [HttpPost]
        [Route("GetCartaoPorId")]
        public RespostaGetByIdCartaoDto GetCartaoById([FromBody] RequisicaoGetByIdCartaoDto dto)
        {
            var retorno = _aplicacaoCartao.GetCartaoById(dto);
            HttpContext.Response.StatusCode = (int)retorno.codRetorno;
            return retorno;
        }
    }
}
