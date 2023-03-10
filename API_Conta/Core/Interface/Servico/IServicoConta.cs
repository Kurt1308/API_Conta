using Core.Interface.Servicos;
using Dominio.Entidade;

namespace Core.Interface.Servico
{
    public interface IServicoConta : IServiceBase<conta>
    {
        conta insereConta(int num_conta, string nome_titular, string tipo_conta, int situacao, string identificador, int? agencia_id_agencia);
    }
}
