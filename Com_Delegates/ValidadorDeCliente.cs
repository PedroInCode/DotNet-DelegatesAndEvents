using System.Diagnostics.CodeAnalysis;

namespace Com_Delegates;

public sealed class ValidadorDeCliente //sealed significa que a classe não pode ser herdada
{
    //Criando o Delegate.
    public delegate string? RegraDeValidacao(Cliente cliente); 

    //Lista somente leitura -> readonly
    private readonly List<RegraDeValidacao> _regras = []; 

    public ValidadorDeCliente AdicionarRegra(RegraDeValidacao regra)
    {
        ArgumentNullException.ThrowIfNull(regra); //Garante que a regra não seja NÚLA.
        _regras.Add(regra);
        return this; //Permite o encadeamento de chamadas
    }

    public bool Validar(Cliente cliente, [NotNullWhen(returnValue: false)] out List<string>? erros)
    {
        if(cliente is null)
        {
            throw new ArgumentNullException(nameof(cliente));
        }

        //No inicio do método Validar
        erros = new List<string>(); //Sempre inicializa a lista.

        foreach(var regra in _regras)
        {
            var erro = regra(cliente);
            if (!string.IsNullOrWhiteSpace(erro))
            {
                erros ??= [];
                erros.Add(erro);
            }
        }

        return erros.Count == 0; // Verifica se a lista está vazia.
    }
}
