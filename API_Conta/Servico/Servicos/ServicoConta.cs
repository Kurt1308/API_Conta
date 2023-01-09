using Core.Interface.Repositorio;
using Core.Interface.Servico;
using Core.Interface.Servicos;
using Dominio.Entidade;
using System.Linq;
using System.Threading.Tasks;

namespace Servico.Servicos
{
    public class ServicoConta : IServiceBase<conta>, IServicoConta
    {
        private readonly IRepositorioConta _repositorioConta;

        public ServicoConta(IRepositorioConta repositorioConta) 
        {
            _repositorioConta = repositorioConta;
        }
        public void Add(conta obj)
        {
            throw new System.NotImplementedException();
        }

        public Task AddAsync(conta obj)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(conta obj)
        {
            throw new System.NotImplementedException();
        }


        public void Update(conta obj)
        {
            throw new System.NotImplementedException();
        }

        public conta insereConta(int num_conta, string nome_titular, string tipo_conta, int situacao, string identificador, int? agencia_id_agencia)
        {
            return _repositorioConta.insereConta(num_conta,  nome_titular,  tipo_conta,  situacao,  identificador, agencia_id_agencia);
        }

        public IQueryable<conta> buscaContas()
        {
            return _repositorioConta.buscaContas();
        }

        public conta GetContaById(long id)
        {
            return _repositorioConta.GetContaById(id);
        }
    }
}
