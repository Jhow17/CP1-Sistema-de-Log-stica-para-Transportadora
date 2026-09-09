using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP1
{
    public abstract class FuncionarioTransporte
    {
        private string nome;
        private int registro;

        public string Nome {
            get { return nome; }

            set { nome = value; }

        }

        public int Registro {
            get { return registro;  }

            set { registro = value;  }
        }

        public FuncionarioTransporte(string nome, int registro) {
            Nome = nome;
            Registro = registro;
        }

        public  virtual  void  MostrarDetalhes() {

            Console.Write($"Nome:{Nome}, e o Registro do Funcionario e {Registro}");

        }




    }
}
