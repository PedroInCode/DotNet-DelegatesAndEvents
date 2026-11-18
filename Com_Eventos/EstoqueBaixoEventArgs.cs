using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com_Eventos;

public sealed class EstoqueBaixoEventArgs
{
    public string Produto { get; }
    public int QuantidadeAtual { get; }
    public DateTime DataDoAlertaUtc { get; }

    public EstoqueBaixoEventArgs(string produto, int quantidadeAtual)
    {
        Produto = produto;
        QuantidadeAtual = QuantidadeAtual;
        DataDoAlertaUtc = DateTime.UtcNow; //registrar sempre em UTC.
    }
}
