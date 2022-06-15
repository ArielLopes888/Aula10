namespace Aula10_po
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Usuario pessoa1 = new Usuario();
            Console.WriteLine("Digite seu nome: ");
            pessoa1.SetNome(Console.ReadLine());
            Console.WriteLine ($" Olá, { pessoa1.nomeDoUsuario }! Seja bem-vindo ao cálculo do seu ano de nascimento ") ;

            Console.WriteLine(" Digite a sua idade agora: ");
            pessoa1.SetIdade(int.Parse(Console.ReadLine()));
            Console.WriteLine($"Seu ano de nascimento é {pessoa1.CalcularIdade()}");
        }
    }
    public class Usuario
    {
        public string nomeDoUsuario;
        public int idadeDoUsuario;
        public int anoAtual = 2022;
        public int calcularAnoNascimento;

        public void SetNome(string nome)
        {
            this.nomeDoUsuario = nome;

        }
        public void SetIdade(int idade)
        {
            this.idadeDoUsuario = idade;
        }
        public int CalcularIdade()
        {
            calcularAnoNascimento = this.anoAtual - idadeDoUsuario;
            return calcularAnoNascimento;
        }
    }
}