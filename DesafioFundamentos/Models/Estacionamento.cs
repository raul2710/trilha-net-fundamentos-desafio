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
            // Pede para usuário digitar a placa do carro para ser adicionado
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa_veiculo = Console.ReadLine().ToUpper();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa_veiculo.ToUpper()))
            {
                Console.WriteLine("Placa já existente");
            }
            else
            {
                veiculos.Add(placa_veiculo);
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pede para usuário digitar a placa do carro que será removido
            string placa = Console.ReadLine().ToUpper();


            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // Usuário entra com a quantidade de horas que o carro ficou no estacinamento                
                int horas;
                int.TryParse(Console.ReadLine(), out horas);

                // Faz o calculo do valor total somando o valor inicial do preço 
                // inicial e o preço por hora proposto pelo usuário
                decimal valorTotal = precoInicial + horas * precoPorHora; 

                // Remove a placa digitada da lista de veículos
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
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                // Mostra todas as placas no estacionamento
                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
