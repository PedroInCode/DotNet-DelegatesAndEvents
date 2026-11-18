using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_Eventos;

public class AlertaDeCompras
{
    public void EnviarAlertaUrgente(string produto)
    {
        Console.WriteLine($"ALERTA: Estoque do produto '{produto}' está baixo! Comprar mais.");
    }
}
