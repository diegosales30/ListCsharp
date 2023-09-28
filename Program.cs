using System;
using System.Collections.Generic;

namespace ListCsharp
{
   class Program
   {
     static void Main(string[] args)
     {
      //lista é uma classe do c#, é possivel criar e instaciar na mesma linha e com valores
      //List<string> list = new() {"maria", "alex", "diego"};
      //vantagens da lista é que o tamanho é variavel, facil para inserir e deletar posições
      //é um obj? e possui nós, sua desvantagem é que é preciso percorrer cada elemento para chegar
      //no elemento procurado, diferente de vetores que é acessivel pela posição ex: array[6]
      List<string> list = new();

      //add adiciona sempre no final da lista
      list.Add("diego");
      list.Add("daniel");
      list.Add("rafael");
      list.Add("rose");
      //inserir com o metodo insert, passando a posição e o valor
      list.Insert(2, "generaldo");

      foreach (string item in list)
      {
        Console.WriteLine(item);
      }
      Console.WriteLine("-----------------");
      //Usando a expressão lambda dentro do find para encontra a primeira ocorrencia dentro da lista que corresponde a verificação.
      string buscaPrimeiraOcorrencia = list.Find(x => x[0] == 'd');
      Console.WriteLine("primeira ocorrencia encontrada: " + buscaPrimeiraOcorrencia);
      //Usando a expressão lambda dentro do FindLast para encontra a ultima ocorrencia dentro da lista que corresponde a verificação.
      string buscaUltimaOcorrencia = list.FindLast(x => x[0] == 'd');
      Console.WriteLine("ultima ocorrencia encontrada: " + buscaUltimaOcorrencia);
      Console.WriteLine("==============================================");
      //Usando a expressão lambda dentro do FindIndex para encontra a PRIMEIRA POSIÇÃO dentro da lista que corresponde a verificação.
      int buscaPrimeiraPosicao = list.FindIndex(x => x[0] == 'd');
      Console.WriteLine("Primeira posição encontrada: " + buscaPrimeiraPosicao);
      //Usando a expressão lambda dentro do FindIndex para encontra a ULTIMA POSIÇÃO dentro da lista que corresponde a verificação.
      int buscaUltimaPosicao = list.FindLastIndex(x => x[0] == 'd');
      Console.WriteLine("Ultima posição encontrada: " + buscaUltimaPosicao);

      //fazer um filtro na lista e guardar saida em outra lista, buscar todas as ocorrencias que possiem mais de 5 caracters.
      Console.WriteLine("==============================================");
      List<string> listSaida = list.FindAll(x => x.Length > 5);
      foreach (string item in listSaida)
      {
        Console.WriteLine("Ocorrencias que possuem mais de 5 caracters: " + item); 
      }

       Console.WriteLine("==============================================");
       //metodos para remover da lista
       list.Remove("diego");
       foreach (string item in list)
      {
        Console.WriteLine(item); 
      }



     }
   }
}