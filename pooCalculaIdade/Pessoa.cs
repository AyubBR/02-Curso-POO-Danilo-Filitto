using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooCalculaIdade
{
    public class Pessoa
    {

        private string nome;

        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value.ToUpper(); }
        }

        private int anoNascimento;

        public int AnoNascimento
        {
            get { return this.anoNascimento; }
            set { this.anoNascimento = value; }
        }

        public void ExibirDados()
        {
            Console.WriteLine("Nome:" + this.Nome);
            Console.WriteLine("Ano de Nascimento:" + this.AnoNascimento);
            Console.WriteLine("Idade:" + CalcularIdade());
        }
        private int CalcularIdade()
        {
            var data = DateTime.Now;
            var ano = data.Year;
            int idade = ano - this.AnoNascimento;
            return idade;
        }

    }


}
