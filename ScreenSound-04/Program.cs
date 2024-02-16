using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://www.cheapshark.com/api/1.0/deals");
        Console.Write("Insira o numero A: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Insira o numero B: ");
        int b = int.Parse(Console.ReadLine());
        int c = a / b;
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Problema indentificado: {ex.Message}");
    }
}