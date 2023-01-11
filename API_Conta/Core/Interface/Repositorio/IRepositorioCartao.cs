using Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interface.Repositorio
{
    public interface IRepositorioCartao
    {
        cartao insereCartao(long num_cartao, int cvc, int? agencia_id_agencia, int? conta_id_conta);
        IQueryable<cartao> buscaCartoes();
        cartao GetCartaoById(int id);
    }
}
