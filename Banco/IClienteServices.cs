using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banco
{
    public interface IClienteServices
    {
        void CriarConta();
        Cliente BuscarCliente();
        void ExibirClientes();
    }
        
}