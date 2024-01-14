namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // Implementado!!!!!
                Console.WriteLine("Digite a placa do veículo para estacionar:");
                 string carro =Console.ReadLine();
                veiculos.Add(carro);
        }

        public void RemoverVeiculo()
        {
            // Implementado!!!!!
            int horas = 0;
              string placa = "";
            Console.WriteLine("Digite a placa do veículo para remover:");
            placa = Console.ReadLine();

           
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                string hrs= Console.ReadLine();
                horas=int.Parse(hrs);
                decimal valorTotal = 0;
                valorTotal = precoInicial + precoPorHora * horas;

                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Implementado!!!!!
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
               
                foreach (var veiculo in veiculos)   
                    Console.WriteLine(veiculo.ToString());
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
