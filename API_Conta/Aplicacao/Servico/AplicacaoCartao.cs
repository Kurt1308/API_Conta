using Adaptador.Interfaces;
using Aplicacao.Interface;
using AplicacaoDto.RequisicoesDto.DtoCartao;
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

        public RespostaGetByIdCartaoDto GetCartaoById(RequisicaoGetByIdCartaoDto dto)
        {
            string msgErroValidacao = "";
            if (!msgErroValidacao.Equals(string.Empty))
                return _mapperCartao.MapperToDtoGetCartao(HttpStatusCode.UnprocessableEntity, msgErroValidacao, null);

            try
            {
                var cadastroCartao = _servicoCartao.GetCartaoById(dto.id_cartao);

                if (cadastroCartao == null)
                    return _mapperCartao.MapperToDtoGetCartao(HttpStatusCode.NotFound, "Consulta não retornou dados, verifique os parâmetros enviados", null);
                else
                    return _mapperCartao.MapperToDtoGetCartao(HttpStatusCode.OK, "", cadastroCartao);
            }
            catch (Exception Erro)
            {
                return _mapperCartao.MapperToDtoGetCartao(HttpStatusCode.InternalServerError, Erro.ToString(), null);
            }
        }
    }
}
