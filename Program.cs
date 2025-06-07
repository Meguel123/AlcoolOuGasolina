Console.WriteLine("--- Álcool ou Gasolina? ---");

Console.Write("Digite o preço do álcool (R$)......: ");
decimal precoAlcool = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite o preço da gasolina (R$)....: ");
decimal precoGasolina = Convert.ToDecimal(Console.ReadLine());

decimal razao = CalcularRazao(precoAlcool, precoGasolina);
bool valeGasolina = ValeAPenaGasolina(razao);

decimal percentual = razao * 100;
Console.WriteLine();
Console.WriteLine($"O preço do álcool corresponde a {percentual:F1}% do preço da gasolina.");

if (valeGasolina)
    Console.WriteLine("Recomendação: Abasteça com GASOLINA.");
else
    Console.WriteLine("Recomendação: Abasteça com ÁLCOOL.");

decimal CalcularRazao(decimal alcool, decimal gasolina)
{
    return alcool / gasolina;
}

bool ValeAPenaGasolina(decimal razao)
{
    return razao > 0.73m;
}

