using Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interface.Servico
{
    public interface IServicoCartao
    {
        cartao insereCartao(long num_cartao, int cvc, int? agencia_id_agencia, int? conta_id_conta);
        IQueryable<cartao> buscaCartoes();
        cartao GetCartaoById(int id);
        cartao atualizarCartao(int id_cartao, int conta_id_conta, int agencia_id_agencia, decimal? limite_saldo, int? situacao);
    }
}
