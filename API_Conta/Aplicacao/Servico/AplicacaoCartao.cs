using Adaptador.Interfaces;
using Aplicacao.Interface;
using AplicacaoDto.RespostaDto.DtoCartao;
using Core.Interface.Servico;
using Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Servico
{
    public class AplicacaoCartao : IAplicacaoCartao
    {
        private const string semDados = "NÃO POSSUI DADOS";
        private readonly IServicoCartao _servicoCartao;
        private readonly IMapperCartao _mapperCartao;
        public AplicacaoCartao(IServicoCartao servicoCartao, IMapperCartao mapperCartao)
        {
            _servicoCartao = servicoCartao;
            _mapperCartao = mapperCartao;
        }
        public RespostaGetCartaoDto GetAllCartoes()
        {
            try
            {
                List<cartao> retorno = _servicoCartao.buscaCartoes().ToList();
                return _mapperCartao.MapperToDtoCartao(retorno.Count > 0 ? HttpStatusCode.OK : HttpStatusCode.NotFound, retorno.Count > 0 ? "" : semDados, retorno);
            }
            catch (Exception erro)
            {
                return _mapperCartao.MapperToDtoCartao(HttpStatusCode.InternalServerError, erro.Message);
            }
        }
    }
}
