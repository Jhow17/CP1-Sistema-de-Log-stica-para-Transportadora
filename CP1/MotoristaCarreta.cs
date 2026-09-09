using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP1
{
    class MotoristaCarreta : FuncionarioTransporte
    {
        public string CategoriaCNH { get; set; }
        public string PlacaVeiculo { get; set; }

        public MotoristaCarreta(string nome, int registro, string categoriaCNH, string placaVeiculo):base(nome, registro) {


            CategoriaCNH = categoriaCNH;

            PlacaVeiculo = placaVeiculo;


        
        }
    }
}
