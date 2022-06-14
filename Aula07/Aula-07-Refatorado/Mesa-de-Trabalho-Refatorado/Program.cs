namespace Mesa_de_Trabalho_Refatorado
{
    public class ConverteDorlar
    {
        public double cotacaoDoDolarHoje = 4.97;
        
        public double VALOR_MINIMO_DE_COMPRA_EM_DOLAR = 100;
        public double VALOR_MAXIMO_DE_COMPRA_EM_DOLAR = 2500;

        
        public double converterRealParaDolar(double valorDaCompraEmReais, double cotacaoDoDolarHoje)
            { 
                valorDaCompraEmReais /= cotacaoDoDolarHoje;

                
                return valorDaCompraEmReais;
            }

        
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            ConverteDorlar convercao = new ConverteDorlar();
            
            Console.WriteLine("Digite o valor da compra: ");

            double valor = convercao.converterRealParaDolar(double.Parse(Console.ReadLine()), convercao.cotacaoDoDolarHoje);

            if (valor < convercao.VALOR_MINIMO_DE_COMPRA_EM_DOLAR)
            {
                Console.WriteLine($"A compra mínima permitida é de $ {convercao.VALOR_MINIMO_DE_COMPRA_EM_DOLAR}");
            }
            else if (valor > convercao.VALOR_MAXIMO_DE_COMPRA_EM_DOLAR)
            {
                Console.WriteLine($"A compra máxima permitida é de $ {convercao.VALOR_MAXIMO_DE_COMPRA_EM_DOLAR}");
            }
            else
            {
                
                Console.WriteLine($"Você pode comprar $ {valor.ToString("N2")}");
            }
   
        }
    }
}