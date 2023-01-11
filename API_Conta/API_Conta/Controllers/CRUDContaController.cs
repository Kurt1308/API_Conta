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
        /// <param name="dto"></param>
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
        [Route("InserirConta")]
        public RespostaInsertContaDto Insert([FromBody] RequisicaoInsertContaDto dto)
        {
            var retorno = _aplicacaoConta.Insert(dto);
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
        //[AllowAnonymous]
        [HttpGet]
        [Route("GetTodasAsContas")]
        public RespostaGetContaDto GetAllContas()
        {
            return _aplicacaoConta.GetAllContas();
        }
        /// <summary>
        /// Endpoint para consultar uma determinada Conta
        /// </summary>
        /// <param name="dto"></param>
        /// <returns>Retorna XXX</returns>
        /// <response code="200">Esta requisição foi bem sucedida</response>
        /// <response code="400">O servidor não entendeu a requisição pois está com uma sintaxe inválida</response>
        /// <response code="422">Erro de validação de conteúdo, código não localizado</response>
        /// <response code="500">Erro interno na aplicação, vide campo mensagem</response>
        [ProducesResponseType(typeof(RespostaGetByIdContaDto), 200)]
        [ProducesResponseType(typeof(RespostaGetByIdContaDto), 400)]
        [ProducesResponseType(typeof(RespostaGetByIdContaDto), 422)]
        [ProducesResponseType(typeof(RespostaGetByIdContaDto), 500)]
        [AllowAnonymous]
        [HttpPost]
        [Route("GetContaPorId")]
        public RespostaGetByIdContaDto GetContaById([FromBody] RequisicaoGetByIdContaDto dto)
        {
            var retorno = _aplicacaoConta.GetContaById(dto);
            HttpContext.Response.StatusCode = (int)retorno.codRetorno;
            return retorno;
        }
        /// <summary>
        /// Endpoint para atualizar conta 
        /// </summary>
        /// <param name="dto"></param>
        /// <response code="200">Busca realizada com sucesso</response>
        /// <response code="400">Campos obrigatórios não informados</response>
        /// <response code="401">Acesso não autenticado</response>
        /// <response code="403">Acesso não autorizado</response>
        /// <response code="422">Erro de válidação de conteúdo, vide campo mensagem</response>
        /// <response code="500">Erro interno na aplicação, vide campo mensagem</response>
        [ProducesResponseType(typeof(RespostaPutContaDto), 200)]
        [ProducesResponseType(typeof(RespostaPutContaDto), 422)]
        [ProducesResponseType(typeof(RespostaPutContaDto), 500)]
        [AllowAnonymous]
        [HttpPut]
        public RespostaPutContaDto Put([FromBody] RequisicaoPutContaDto dto)
        {
            var retorno = _aplicacaoConta.AtualizarConta(dto);
            HttpContext.Response.StatusCode = (int)retorno.codRetorno;
            return retorno;
        }
    }
}
