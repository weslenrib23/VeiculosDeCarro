﻿namespace Veiculos
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculosDeCarro = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos" - feito!!

            Console.WriteLine("Digite a placa do veículo para estacionar:");
            veiculosDeCarro.Add(Console.ReadLine());
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa - feito!!

            string placa = "";
            placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculosDeCarro.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");


                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado, - feito!!
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal - feito!!               

                int horas = 0;
                decimal valorTotal = 0;
                horas = Convert.ToInt32(Console.ReadLine());
                valorTotal = precoInicial + precoPorHora * horas;

                // TODO: Remover a placa digitada da lista de veículos - feito!!


                veiculosDeCarro.Remove(placa.ToUpper());

                Console.WriteLine($"O veículo {placa.ToUpper()} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
            // *IMPLEMENTE AQUI*

            if (veiculosDeCarro.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                int i = 1;

                foreach (string cadaVeiculo in veiculosDeCarro)
                {
                    Console.WriteLine($"{i}º veículo: {cadaVeiculo.ToUpper()}");
                    i++;
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}