using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estacionamento.Models
{
    public class Estacionamento
    {
        private decimal PrecoInicial { get; set; }
        private decimal PrecoPorHora { get; set; }
        private List<Veiculo> VeiculosEstacionados { get; set; } = new List<Veiculo>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            PrecoInicial = precoInicial;
            PrecoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo(string placa)
        {
            if (VeiculosEstacionados.Any(v => v.Placa == placa))
            {
                Console.WriteLine($"O veiculo com placa {placa} já está estacionado");
                return;
            }

            VeiculosEstacionados.Add(new Veiculo { Placa = placa, HoraEntrada = DateTime.Now });
            Console.WriteLine($"Veiculo {placa} adicionado com sucesso às {DateTime.Now:t}!");
        }

        public void RemoverVeiculo(string placa)
        {
            var veiculo = VeiculosEstacionados.FirstOrDefault(v => v.Placa == placa);
            if (veiculo == null)
            {
                Console.WriteLine($"Nenhum veiculo com a placa {placa} foi encontrado.");
                return;
            }

            DateTime horaSaida = DateTime.Now;
            var tempo = horaSaida - veiculo.HoraEntrada;

            var horas = (decimal)Math.Ceiling(tempo.TotalHours);

            decimal valorTotal = PrecoInicial + (PrecoPorHora * horas);
            VeiculosEstacionados.Remove(veiculo);

            Console.WriteLine($"Veiculo {placa} removido com sucesso! \nEntrada: {veiculo.HoraEntrada:t}. \nSaída: {horaSaida:t}. \nTempo total: {horas} hora(s). \n Valor total a pagar: R$ {valorTotal:F2}.");
        }

        public void ListarVeiculos()
        {
            if (!VeiculosEstacionados.Any())
            {
                Console.WriteLine("Nenhum veiculo estacionado no momento");
                return;
            }

            Console.WriteLine("Veiculos estacionados:");
            foreach(var v in VeiculosEstacionados)
            {
                Console.WriteLine($" Placa: {v.Placa} | Entrada {v.HoraEntrada:t}");
            }
        }
    }
}