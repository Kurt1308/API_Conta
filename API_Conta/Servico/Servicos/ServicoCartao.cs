using Core.Interface.Repositorio;
using Core.Interface.Servico;
using Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servico.Servicos
{
    public class ServicoCartao : IServicoCartao
    {
        private readonly IRepositorioCartao _repositorioCartao;

        public ServicoCartao(IRepositorioCartao repositorioCartao)
        {
            _repositorioCartao = repositorioCartao;
        }
        public IQueryable<cartao> buscaCartoes()
        {
            return _repositorioCartao.buscaCartoes();
        }

        public cartao GetCartaoById(int id)
        {
            return _repositorioCartao.GetCartaoById(id);
        }
    }
}
