using System;

namespace CP1
{
    public abstract class FuncionarioTransporte
    {
        private string nome;
        private int registro;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Registro
        {
            get { return registro; }
            set { registro = value; }
        }

        public FuncionarioTransporte(string nome, int registro)
        {
            Nome = nome;
            Registro = registro;
        }

        public virtual void MostrarDetalhes()
        {
            Console.WriteLine($"Nome: {Nome}, Registro: {Registro}");
        }
    }
}
