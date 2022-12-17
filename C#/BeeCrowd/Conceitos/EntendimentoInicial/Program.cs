using System;


namespace SistemaBancario
{
    public class Gerente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int Cpf { get; set; }

        public void AprovarHorasDeFuncionarios(int Cpf)
        {
            //lógica para aprovar horas
        }
    }

    public class instaciaOBjeto
    {
        public static void Main()
        {
            var ObjetoGerent = new Gerente();
        }


    }
}


