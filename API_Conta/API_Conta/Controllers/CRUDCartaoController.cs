using Aplicacao.Interface;
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
    }
}
