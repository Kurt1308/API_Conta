using Core.Interface.Repositorio;
using Data;
using Dominio.Entidade;
using Repositorio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.RepositorioConta
{
    public class RepositorioCartao : RepositoryBase<cartao>, IRepositorioCartao
    {
        private readonly SqlContext _context;

        public RepositorioCartao(SqlContext Context) : base(Context)
        {
            _context = Context;
        }
        public IQueryable<cartao> buscaCartoes()
        {
            return _context.cartao.AsQueryable();
        }

        public cartao GetCartaoById(int id)
        {
            return _context.cartao.Where(x => x.id_cartao == id).FirstOrDefault();
        }
    }
}
