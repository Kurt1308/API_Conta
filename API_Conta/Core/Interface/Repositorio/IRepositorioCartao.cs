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
        IQueryable<cartao> buscaCartoes();
    }
}
