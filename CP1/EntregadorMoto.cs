using System;

namespace CP1
{
    class EntregadorMoto : FuncionarioTransporte
    {
        public string PlacaVeiculo { get; set; }

        public EntregadorMoto(string nome, int registro, string placaVeiculo) : base(nome, registro)
        {
            PlacaVeiculo = placaVeiculo;
        }

        public override void MostrarDetalhes()
        {
            Console.WriteLine($"[ENTREGADOR DE MOTO] Nome: {Nome}, Registro: {Registro}, Placa do veículo: {PlacaVeiculo}");
        }
    }
}
