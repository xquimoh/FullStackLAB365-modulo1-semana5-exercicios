using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banco
{
    public class PessoaJuridica : Cliente
    {
        public string CNPJ { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public List<string> Socios { get; set; } = new List<string>();
        public DateTime DataAbertura { get; set; }
        
        public static Cliente AbrirEmpresa()
        {

            PessoaJuridica empresa = new PessoaJuridica();
            
            Console.WriteLine("Informe a data de abertura da empresa");
            empresa.DataAbertura = DateTime.Parse(Console.ReadLine());
            Console.WriteLine($"A data de abertura da empresa é {empresa.DataAbertura}");
            Console.WriteLine("Informe a Razão Social da empresa");
            empresa.RazaoSocial = Console.ReadLine();
            Console.WriteLine("Informe o CNPJ da empresa");
            empresa.CNPJ = Console.ReadLine();
            Console.WriteLine("Informe o Nome Fantasia da empresa");
            empresa.NomeFantasia = Console.ReadLine();
            Console.WriteLine("Informe o telefone da empresa");
            empresa.Telefone = Console.ReadLine();
            Console.WriteLine("Informe o e-mail da empresa");
            empresa.Email = Console.ReadLine();
            Console.WriteLine("Informe o número da conta da empresa");
            empresa.NumeroConta = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe a quantidade de sócios da empresa");
            var op = int.Parse(Console.ReadLine());

            
        for (int i = 0; i < op; i++)
            {
                Console.WriteLine($"Digite o CPF do {i+1}o sócio:");
                empresa.Socios.Add(Console.ReadLine());
            }
            

            return empresa;
        }

        public override string ResumoCliente()
        {

            string resumo = $"{NumeroConta}  |  {RazaoSocial}  |  {CNPJ}  |  {NomeFantasia}";
            
            foreach (var socio in Socios)
            {
                resumo += $" |{socio} ";
            }
            
            return resumo;
        
        }
    }
}