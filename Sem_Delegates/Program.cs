using Sem_Delegates;

Console.WriteLine("\n ### Exemplo de validação sem usar Delegates ### \n");
Console.ReadKey();

Console.WriteLine("\nValidando cliente : Zé - emial#hotmail.com - 19 anos\n");

//Cliente com múltiplos problemas de validação para testar a coleta de erros.
var cliente = new Cliente("Zé", "emial#hotmail.com", 19);

var validador = new ValidadorDeCliente();

//A chamada ao método 'Validar' passa uma variável para receber os erros.
if(validador.Validar(cliente, out List<string> listaDeErros))
{
    Console.WriteLine("Cliente válido!");
}
else
{
    //Se a validação falhar, exibe todos os erros coletados.
    Console.WriteLine("Foram encontrados os seguintes erros de validação:");
    foreach(var erro in listaDeErros)
    {
        Console.WriteLine($"- {erro}");
    }
}

Console.WriteLine("\nEnd of validation.");
Console.ReadKey();
