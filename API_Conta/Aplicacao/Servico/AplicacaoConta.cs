using Adaptador.Interfaces;
using Aplicacao.Interface;
using AplicacaoDto.RequisicoesDto.contaDto;
using AplicacaoDto.RespostaDto.contaDto;
using AplicacaoDto.RespostaDto.InsertContaDto;
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
    public class AplicacaoConta : IAplicacaoConta
    {
        private const string erroInserir = "NÃO FOI POSSÍVEL CRIAR ESSA CONTA";
        private const string semDados = "NÃO POSSUI DADOS";
        private readonly IServicoConta _servicoConta;
        private readonly IMapperConta _mapperConta;
        public AplicacaoConta(IServicoConta servicoConta, IMapperConta mapperConta)
        {
            _servicoConta = servicoConta;
            _mapperConta = mapperConta;
        }

        public RespostaGetContaDto GetAllContas()
        {
            try
            {
                List<conta> retorno = _servicoConta.buscaContas().ToList();
                return _mapperConta.MapperToDtoConta(retorno.Count > 0 ? HttpStatusCode.OK : HttpStatusCode.NotFound, retorno.Count > 0 ? "" : semDados, retorno);
            }
            catch (Exception erro)
            {
                return _mapperConta.MapperToDtoConta(HttpStatusCode.InternalServerError, erro.Message);
            }
        }

        public RespostaGetByIdContaDto GetContaById(RequisicaoGetByIdContaDto dto)
        {
            string msgErroValidacao = "";
            if (!msgErroValidacao.Equals(string.Empty))
                return _mapperConta.MapperToDtoGetConta(HttpStatusCode.UnprocessableEntity, msgErroValidacao, null);

            try
            {
                var cadastroConta = _servicoConta.GetContaById(dto.idConta);

                if (cadastroConta == null)
                    return _mapperConta.MapperToDtoGetConta(HttpStatusCode.NotFound, "Consulta não retornou dados, verifique os parâmetros enviados", null);
                else
                    return _mapperConta.MapperToDtoGetConta(HttpStatusCode.OK, "", cadastroConta);
            }
            catch (Exception Erro)
            {
                return _mapperConta.MapperToDtoGetConta(HttpStatusCode.InternalServerError, Erro.ToString(), null);
            }
        }

        public RespostaInsertContaDto Insert(RequisicaoInsertContaDto obj)
        {
            string mensagem = "";

            if (!mensagem.Equals(string.Empty))
                return _mapperConta.MapperToDtoInsert(HttpStatusCode.UnprocessableEntity, mensagem);
            try
            {
                conta retornoConta = _servicoConta.insereConta(obj.num_conta, obj.nome_titular, obj.tipo_conta, obj.situacao, obj.identificador, obj.agencia_id_agencia);
                return _mapperConta.MapperToDtoInsert(retornoConta != null ? HttpStatusCode.Created : HttpStatusCode.InternalServerError, retornoConta != null ? mensagem : erroInserir, retornoConta);
            }
            catch (Exception erro)
            {
                return _mapperConta.MapperToDtoInsert(HttpStatusCode.InternalServerError, erro.Message);
            }
        }
    }
}
