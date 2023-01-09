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
    public class RepositorioConta : RepositoryBase<conta>, IRepositorioConta
    {
        private readonly SqlContext _context;

        public RepositorioConta(SqlContext Context) : base(Context)
        {
            _context = Context;
        }

        public IQueryable<conta> buscaContas()
        {
            return _context.conta.AsQueryable();
        }

        public conta insereConta(int num_conta, string nome_titular, string tipo_conta, int situacao, string identificador, int? agencia_id_agencia)
        {
            var result = _context.conta.SingleOrDefault(x => x.num_conta == num_conta);
            if (result == null)
            {
                conta conta = new conta()
                {
                    //id_conta = id_conta,
                    num_conta = num_conta,
                    nome_titular = nome_titular,
                    tipo_conta = tipo_conta,
                    situacao = situacao,
                    identificador = identificador,
                    agencia_id_agencia = agencia_id_agencia
                };
                var data = DateTime.UtcNow;
                conta.data_criacao = data;
                _context.conta.Add(conta);
                _context.SaveChanges();

                return conta;
            }

            return null;
        }
    }
}
