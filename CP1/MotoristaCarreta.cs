using System;

namespace CP1
{
    class MotoristaCarreta : FuncionarioTransporte
    {
        public string CategoriaCNH { get; set; }

        public MotoristaCarreta(string nome, int registro, string categoriaCNH) : base(nome, registro)
        {
            CategoriaCNH = categoriaCNH;
        }

        public override void MostrarDetalhes()
        {
            Console.WriteLine($"[MOTORISTA DE CARRETA] Nome: {Nome}, Registro: {Registro}, Categoria da CNH: {CategoriaCNH}");
        }
    }
}
