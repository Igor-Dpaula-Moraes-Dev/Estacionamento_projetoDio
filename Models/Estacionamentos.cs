using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estaciona.Models
{
    public class Veiculo
    {
        public string Placa{get; set;}
        public  DateTime HoraEntrada {get; set;}

        public string Modelo {get; set;}
    }
    public class Estacionamentos
    {
         private decimal precoInicial;
        private decimal precoPorHora;
        private List<Veiculo> veiculos = new List<Veiculo>();
    
    public Estacionamentos(decimal precoInicial, decimal precoPorHora)
    {
        this.precoInicial= precoInicial;
        this.precoPorHora= precoPorHora;
    }

    public void AdicionarVeiculo()
    {
        Console.WriteLine("Informe A Placa Do veiculo que deseja adicionar");
        string placa =Console.ReadLine();    
        Veiculo novoVeiculo = new Veiculo { Placa = placa, HoraEntrada = DateTime.Now };

        veiculos.Add(novoVeiculo);
        Console.WriteLine($"Veiculo  da PLACA: {novoVeiculo.Placa} Adicionado com  Sucesso");
    }

    public void ListarVeiculos()
    {
        Console.WriteLine("Gostaria de pesquisar um veiculo especifico");
       
        if (veiculos.Count ==0)
        {
            Console.WriteLine("Não há veiculos a serem listados");

        }
        else
        {
                Console.WriteLine($"A quantidade de veículos estacionados é: {veiculos.Count}");
                foreach (var veiculoEstacionado in veiculos)
                {
                    Console.WriteLine($"Veículo disponível: Placa: {veiculoEstacionado.Placa}, Entrada: {veiculoEstacionado.HoraEntrada}");
                }

        }


        
    }

    public void RemoverVeiculo()
    {
        
        Console.WriteLine("Digite a placa do veiculo a ser  removido:");
         string  placa =Console.ReadLine();
         Veiculo veiculoEncontrado = null;

         foreach( var veiculo in veiculos)
         {
            if(veiculo.Placa == placa)
            {
                
                veiculoEncontrado= veiculo;
                break;
            }
         }

         
        if (veiculoEncontrado !=  null )
          {  
            veiculos.Remove(veiculoEncontrado);
        
            Console.WriteLine($"Veiculo de {veiculoEncontrado.Placa} removido Com sucesso");
            Console.WriteLine($" Valor a pagar: R$ {calcularValorAPagar(veiculoEncontrado)}");
        }
        else
        {
            Console.WriteLine($"O veiculo {placa} não foi encontrado");
        }
        }
        public decimal calcularValorAPagar(Veiculo veiculo)
        {
            TimeSpan tempoEstacionamento = DateTime.Now - veiculo.HoraEntrada;
            decimal horasEstacionadas = (decimal)tempoEstacionamento.TotalHours;

            // Considerando o preço inicial, ajuste o cálculo conforme necessário
            decimal valorAPagar = precoInicial + horasEstacionadas * precoPorHora;

            return valorAPagar;
        }

    }

    }
    
    