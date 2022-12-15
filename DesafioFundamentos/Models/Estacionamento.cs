namespace DesafioFundamentos.Models {
    public class Estacionamento {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora) {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo() {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placaVeiculos = Console.ReadLine();
            veiculos.Add(placaVeiculos);
        }

        public void RemoverVeiculo() {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placaVeiculos =Console.ReadLine();
            string placa = placaVeiculos;
            

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper())) {

                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = 0;
                decimal valorTotal = 0; 
                horas = Convert.ToInt32(Console.ReadLine());
                valorTotal = precoInicial + (precoPorHora * horas);

                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            } else {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos() {
    
            if (veiculos.Any()) {
                Console.WriteLine("Os veículos estacionados são:");
              
                int contadorForeach = 0;
                foreach(string placaVeiculos in veiculos) {
                    Console.WriteLine($"Veículo N° {contadorForeach+1}: {placaVeiculos}");
                    contadorForeach++;
                }
                
            } else {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
