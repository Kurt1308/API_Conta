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

        public cartao insereCartao(long num_cartao, int cvc, int? agencia_id_agencia, int? conta_id_conta)
        {
            var result = _context.cartao.SingleOrDefault(x => x.num_cartao == num_cartao);
            if (result == null)
            {
                cartao cartao = new cartao()
                {
                    //id_cartao = id_cartao,
                    num_cartao = num_cartao,
                    cvc = cvc,
                    agencia_id_agencia = agencia_id_agencia,
                    conta_id_conta = conta_id_conta
                };
                var data = DateTime.UtcNow;
                cartao.mes_ano_vencimento = data.AddYears(5).ToString();
                cartao.limite_saldo_disponivel = Convert.ToDecimal(1000.02);
                cartao.limite_saldo = Convert.ToDecimal(1000.09);
                cartao.situacao = 1;
                _context.cartao.Add(cartao);
                _context.SaveChanges();

                return cartao;
            }

            return null;
        }
    }
}
