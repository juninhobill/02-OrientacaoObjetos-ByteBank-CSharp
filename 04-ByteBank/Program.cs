using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno";
            Console.WriteLine(contaDoBruno.saldo);

            bool resultadodoSaque = contaDoBruno.Sacar(500);

            Console.WriteLine(contaDoBruno.saldo);
            Console.WriteLine(resultadodoSaque);

            contaDoBruno.Depositar(500);
            Console.WriteLine(contaDoBruno.saldo);


            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";

            bool resultadoTransferencia = contaDoBruno.Transferir(200, contaDaGabriela);

            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);

            Console.WriteLine(resultadoTransferencia);

            bool resultadoTransferencia2 = contaDaGabriela.Transferir(100, contaDoBruno);

            Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);
            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);

            Console.WriteLine(resultadoTransferencia2);

            Console.ReadLine();
        }
    }
}
