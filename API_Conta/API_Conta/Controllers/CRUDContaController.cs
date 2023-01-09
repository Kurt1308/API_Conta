using Aplicacao.Interface;
using AplicacaoDto.RequisicoesDto.contaDto;
using AplicacaoDto.RespostaDto.contaDto;
using AplicacaoDto.RespostaDto.InsertContaDto;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API_Conta.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "Bearer")]
    public class CRUDContaController : Controller
    {
        private readonly IAplicacaoConta _aplicacaoConta;

        public CRUDContaController(IAplicacaoConta aplicacaoConta)
        {
            _aplicacaoConta = aplicacaoConta;
        }
        /// <summary>
        /// Endpoint para cadastrar conta 
        /// </summary>
        /// <param name="requisicaoInsertContaDto"></param>
        /// <response code="201">Cadastro realizado com sucesso</response>
        /// <response code="400">Campos obrigatórios não informados</response>
        /// <response code="401">Acesso não autenticado</response>
        /// <response code="403">Acesso não autorizado</response>
        /// <response code="422">Erro de válidação de conteúdo, vide campo mensagem</response>
        /// <response code="500">Erro interno na aplicação, vide campo mensagem</response>
        [ProducesResponseType(typeof(RespostaInsertContaDto), 201)]
        [ProducesResponseType(typeof(RespostaInsertContaDto), 422)]
        [ProducesResponseType(typeof(RespostaInsertContaDto), 500)]
        [AllowAnonymous]
        [HttpPost]
        [Route("Insert")]
        public RespostaInsertContaDto Insert([FromBody] RequisicaoInsertContaDto requisicaoInsertContaDto)
        {
            var retorno = _aplicacaoConta.Insert(requisicaoInsertContaDto);
            HttpContext.Response.StatusCode = (int)retorno.codRetorno;
            return retorno;
        }
        /// <summary>
        /// Endpoint que retorna todas as contas cadastradas
        /// </summary>
        /// <response code="200">Busca realizada com sucesso</response>
        /// <response code="400">Campos obrigatórios não informados</response>
        /// <response code="401">Acesso não autenticado</response>
        /// <response code="403">Acesso não autorizado</response>
        /// <response code="404">Consulta não retornou dados</response>
        /// <response code="500">Erro interno na aplicação, vide campo mensagem</response>
        [ProducesResponseType(typeof(RespostaGetContaDto), 200)]
        [ProducesResponseType(typeof(RespostaGetContaDto), 404)]
        [ProducesResponseType(typeof(RespostaGetContaDto), 500)]
        [AllowAnonymous]
        [HttpGet]
        [Route("agenda")]
        public RespostaGetContaDto GetAllContas()
        {
            return _aplicacaoConta.GetAllContas();
        }
    }
}
