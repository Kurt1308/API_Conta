using Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interface.Repositorio
{
    public interface IRepositorioConta : IRepositoryBase<conta>
    {
        conta insereConta(int num_conta, string nome_titular, string tipo_conta, int situacao, string identificador, int? agencia_id_agencia);
    }
}
