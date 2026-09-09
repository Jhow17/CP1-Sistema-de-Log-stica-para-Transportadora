using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP1
{
    class EntregadorMoto : FuncionarioTransporte
    {
        

        public string PlacaVeiculo { get; set; }

        public EntregadorMoto(string nome, int registro, string placaVeiculo) : base(nome, registro) {


            PlacaVeiculo = placaVeiculo;


        }

    }
}
