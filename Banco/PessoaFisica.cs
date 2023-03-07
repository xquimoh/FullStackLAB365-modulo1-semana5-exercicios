using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banco
{
    public class PessoaFisica : Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Idade { get {return (int)(Math.Floor((DateTime.Now - DataNascimento).TotalDays / 365.25)); } private set {} }
        
        
        public override string ResumoCliente()
        {
            return $"{NumeroConta}  |  {Nome}  | {CPF}  |  {DataNascimento}  | {Endereco}  |  {Telefone}";
        }
        public bool EhMaior()
        {
            return Idade >= 18;
        }
        
        public static Cliente CriarConta()
        {

            PessoaFisica pessoa = new PessoaFisica();
            
            Console.WriteLine("Informe a data de nascimento do cliente:");
            pessoa.DataNascimento = DateTime.Parse(Console.ReadLine());
            if(!pessoa.EhMaior()){
                Console.WriteLine("Não é possivel abrir a conta, pois o cliente é menor de idade");
                return null;
            }
            Console.WriteLine($"Cliente tem {pessoa.Idade} anos de idade");
            Console.WriteLine("Informe o nome do cliente:");
            pessoa.Nome = Console.ReadLine();
            Console.WriteLine("Informe o CPF do cliente:");
            pessoa.CPF = Console.ReadLine();
            Console.WriteLine("Informe o endereco do cliente:");
            pessoa.Endereco = Console.ReadLine();
            Console.WriteLine("Informe o telefone do cliente:");
            pessoa.Telefone = Console.ReadLine();
            Console.WriteLine("Informe o e-mail do cliente:");
            pessoa.Email = Console.ReadLine();
            Console.WriteLine("Informe o número da conta do cliente");
            pessoa.NumeroConta = int.Parse(Console.ReadLine());

            return pessoa;
        }
    }
}