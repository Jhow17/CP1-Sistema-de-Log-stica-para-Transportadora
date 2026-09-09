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
   

        public MotoristaCarreta(string nome, int registro, string categoriaCNH):base(nome, registro) {


            CategoriaCNH = categoriaCNH;



        
        }
    }
}
