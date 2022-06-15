namespace aula10_exc8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaDeFilmes deFilmes = new ListaDeFilmes();

            Console.WriteLine("---------- Resultados da Atividade ----------");


            Console.WriteLine($"1.1. Lista de todos os filmes separados por ponto e vírgula: {deFilmes.apresentaTodosOsFilmesSeparadosPorPontoVirgula()}");


            Console.WriteLine($"1.2. Retorna a quantidade de filmes da lista: {deFilmes.quantidadeTotalDeFilmes()}");



            Console.WriteLine($"1.3. Buscar um filme pelo indice: {deFilmes.buscarNomeDoFilmePeloIndice(0)}");


            Console.WriteLine($"1.4. Adiciona um filme pelo nome: {string.Join("; ", deFilmes.adicionaUmNovoFilmePeloSeuNome("Sexta -feira 13th"))}");


            Console.WriteLine($"1.5. Atualizar um filme pelo seu índice {string.Join("; ", deFilmes.atualizarUmFilmePeloSeuIndice(3, "Rocky III"))}");


        }
    }

    public class ListaDeFilmes
    {
        String[] listaDeFilmes = { "Clube dos Cinco", "A Hora do Pesadelo", "Karatê Kid", "Rocky IV", "Conan, o Bárbaro", "Highlander" };
        public string apresentaTodosOsFilmesSeparadosPorPontoVirgula()
        {
            string lista = " ";
            Console.WriteLine(lista);
            for (int indice = 0; indice < listaDeFilmes.Length; indice++)
            {
                lista += $"{listaDeFilmes[indice]}";
                if (indice != (listaDeFilmes.Length - 1))
                {
                    lista += "; ";
                }
            }
            return lista;
        }


        public int quantidadeTotalDeFilmes()
        {
            int quantidadeTotal = listaDeFilmes.Length;
            return quantidadeTotal;
        }



        public string buscarNomeDoFilmePeloIndice(int indiceDoFilme)
        {
            return listaDeFilmes[indiceDoFilme];
        }


        public String[] adicionaUmNovoFilmePeloSeuNome(string nomeDoFilme)
        {
            return listaDeFilmes.Append(nomeDoFilme).ToArray();
        }



        public String[] atualizarUmFilmePeloSeuIndice(int indiceDoFilme, string filme)
        {

            listaDeFilmes[indiceDoFilme] = filme;
            Console.WriteLine(filme);
            return listaDeFilmes;
        }



        public String[] listarTodosOsFilmesComSeuIndiceNaLista()
        {
            string[] listaComIndice = new string[listaDeFilmes.Length];
            int count;
            for (count = 0; count < listaDeFilmes.Length; count++)
            {
                listaComIndice[count] = $"{count} - {listaDeFilmes[count]}";
            }

            return listaComIndice;

        }

    }
}



/* 1.6 Retorna 
0 - Clube dos Cinco 
1 - A Hora do Pesadelo 
2 - Karatê Kid
3 - Rocky III
4 - Conan, o Bárbaro
5 - Highlander
6 - Sexta-feira 13th */
Console.WriteLine("1.6. Listar todos os filmes com seu indice/posicao na lista:");

string[] listaDeTodosOsFilmesComIndice = listarTodosOsFilmesComSeuIndiceNaLista();
foreach (string filme in listaDeTodosOsFilmesComIndice)
{
    Console.WriteLine($"\t{filme}");
}