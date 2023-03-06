internal class Program
{
    private static void Main(string[] args)
    {
        int digito, count, resultado;

        Console.Write("Deseja ver a tabuada do: ");
        if (!int.TryParse(Console.ReadLine(), out digito))
        {
            Console.WriteLine("Número diferente de inteiro!");
        }
        else if (digito > 1 && digito < 10)
        {
            count = 0;
            while (count < 11)
            {
                resultado = count * digito;
                Console.WriteLine("{0} x {1} = {2}", count, digito, resultado);
                count++;
            }
        }
    }
}