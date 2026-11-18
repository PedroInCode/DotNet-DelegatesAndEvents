using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_Eventos;

public class SistemaDeReposicao
{
    public void CriarPedidoDeReposicaoAutomatico(string produto)
    {
        Console.WriteLine($"SISTEMA: Pedido de reposição para '{produto}' criado automaticamente.");
    }
}
