using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ByteBank
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //CalcularBonificacao();

            UsarSistema();

            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("111.222.333-33");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("555.777.555-55");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            sistemaInterno.Logar(parceiro, "123456");

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "abc");

        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer pedro = new Designer("809.988.999-00");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("111.222.333-33");
            roberta.Nome = "Roberta";

            Auxiliar maria = new Auxiliar("777.777.666-89");
            maria.Nome = "Maria";

            GerenteDeConta camila = new GerenteDeConta("555.777.555-55");
            camila.Nome = "Camila";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(maria);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de Bonificacao do mes: " + gerenciadorBonificacao.GetTotalBonificacao());

        }
    }
}
