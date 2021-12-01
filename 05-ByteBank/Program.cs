using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente gabriela = new Cliente();

            //gabriela.nome = "Gabriela";
            //gabriela.profissao = "Desenvolvedora C#";
            //gabriela.cpf = "1234565879";

            ContaCorrente conta = new ContaCorrente();

            //conta.titular = gabriela;
            //conta.titular = new Cliente();
            //conta.titular.nome = "Gabriela Costa";
            //conta.titular.profissao = "Desenvolvedora C#";
            //conta.titular.cpf = "1234565879";
            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 563765;

            if(conta.titular == null)
            {
                Console.WriteLine("Ops, a referencia em conta.titular é NULL!!!");
            }

            //Console.WriteLine(gabriela.nome);
            //Console.WriteLine(conta.titular.nome);
            //Console.WriteLine(conta.titular.cpf);
            //Console.WriteLine(conta.titular.profissao);

            Console.ReadLine();

        }
    }
}
