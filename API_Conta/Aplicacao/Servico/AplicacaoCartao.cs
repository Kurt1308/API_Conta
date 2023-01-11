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
        private const string erroInserir = "NÃO FOI POSSÍVEL CADASTRAR ESSE CARTÃO";
        private const string erroAtualizar = "NÃO FOI POSSÍVEL ATUALIZAR ESSE CARTÃO";
        private readonly IServicoCartao _servicoCartao;
        private readonly IMapperCartao _mapperCartao;
        public AplicacaoCartao(IServicoCartao servicoCartao, IMapperCartao mapperCartao)
        {
            _servicoCartao = servicoCartao;
            _mapperCartao = mapperCartao;
        }

        public RespostaPutCartaoDto AtualizarCartao(RequisicaoPutCartaoDto obj)
        {
            string mensagem = "";
            if (!mensagem.Equals(string.Empty))
                return _mapperCartao.MapperToDtoPut(HttpStatusCode.UnprocessableEntity, mensagem);
            try
            {
                cartao retornoCartao = _servicoCartao.atualizarCartao(obj.id_cartao, obj.conta_id_conta, obj.agencia_id_agencia, obj.limite_saldo, obj.situacao);

                return _mapperCartao.MapperToDtoPut(retornoCartao != null ? HttpStatusCode.OK : HttpStatusCode.InternalServerError, retornoCartao != null ? mensagem : erroAtualizar, retornoCartao);
            }
            catch (Exception erro)
            {
                return _mapperCartao.MapperToDtoPut(HttpStatusCode.InternalServerError, erro.Message);
            }
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

        public RespostaInsertCartaoDto Insert(RequisicaoInsertCartaoDto obj)
        {
            string mensagem = "";

            if (!mensagem.Equals(string.Empty))
                return _mapperCartao.MapperToDtoInsert(HttpStatusCode.UnprocessableEntity, mensagem);
            try
            {
                cartao retornoCartao = _servicoCartao.insereCartao(obj.num_cartao, obj.cvc, obj.agencia_id_agencia, obj.conta_id_conta);
                return _mapperCartao.MapperToDtoInsert(retornoCartao != null ? HttpStatusCode.Created : HttpStatusCode.InternalServerError, retornoCartao != null ? mensagem : erroInserir, retornoCartao);
            }
            catch (Exception erro)
            {
                return _mapperCartao.MapperToDtoInsert(HttpStatusCode.InternalServerError, erro.Message);
            }
        }
    }
}
