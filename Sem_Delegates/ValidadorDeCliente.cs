using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_Delegates;

public class ValidadorDeCliente
{
    public bool Validar(Cliente cliente, out List<string> erros)
    {
        //1. Inicializa a lista de erros
        erros = new List<string>();

        //2.Executa cada validação e adiciona o erro à lista, sem interromper a execução
        if (string.IsNullOrWhiteSpace(cliente.Nome))
        {
            erros.Add("Erro: Nome do cliente é obrigatório.");
        }

        //Usamos 'else if' para não checar o tamanho de um nome que já é nulo ou vazio
        else if (cliente.Nome.Length < 5)
        {
            erros.Add("Erro: Nome do cliente deve ter pelo menos 5 caracteres.");
        }

        //A verificação de email pode ser feita de forma independente.
        if(cliente.Email == null || !cliente.Email.Contains("@"))
        {
            erros.Add("Erro: Email do cliente é inválido.");
        }

        //A verificação de idade também é independente.
        if(cliente.Idade < 21)
        {
            erros.Add("Erro: Cliente deve ter pelo menos 21 anos."); 
        }

        //3. O resultado final da validação é se a lista de erros está vazia ou não.
        return erros.Count == 0;
    }
}
