using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program {
    public struct Amigos
    {
        public string Nome;
        public int idade;
    }
    static void Main(string[] args)
    {
      Console.WriteLine("Lista de amigos do Yoda: ");
      Console.WriteLine("Amigo 1: ");
        Amigos N1;
      Console.Write("Nome: ");
        N1.Nome = "Alfredo";
        Console.WriteLine(N1.Nome);
        Amigos I1;
        Console.Write("Idade: ");
        I1.idade = 678;
        Console.WriteLine(I1.idade);

      List<string> qualidadesN1 = new List<string> {"amigável", "tímido", "Esperto"};

      Console.WriteLine("Qualidades: ");
      string q1 = qualidadesN1[0];
      Console.WriteLine("1° - " +q1);
      string q2 = qualidadesN1[1];
      Console.WriteLine("2° - " +q2);
      string q3 = qualidadesN1[2];
      Console.WriteLine("3° - " +q3);

      Console.WriteLine("Amigo 2: ");
        Amigos N2;
       Console.Write("Nome: ");
        N2.Nome = "Grogu";
        Console.WriteLine(N2.Nome);
        Amigos I2;
        Console.Write("Idade: ");
        I2.idade = 50;
        Console.WriteLine(I2.idade);

      List<string> qualidadesN2 = new List<string> {"amigável", "Curioso", "Brilhante"};

      Console.WriteLine("Qualidades: ");
      string Q1 = qualidadesN2[0];
      Console.WriteLine("1° - " +Q1);
      string Q2 = qualidadesN2[1];
      Console.WriteLine("2° - " +Q2);
      string Q3 = qualidadesN2[2];
      Console.WriteLine("3° - " +Q3);

      Console.WriteLine("Amigo 3: ");
        Amigos N3;
        Console.Write("Nome: ");
        N3.Nome = "Mandaloriano";
        Console.WriteLine(N3.Nome);
        Amigos I3;
        Console.Write("Idade: ");
        I3.idade = 45;
        Console.WriteLine(I3.idade); 

      List<string> qualidadesN3 = new List<string> {"Introvertido", "Cuidadoso", "Cabeça-quente"};

      Console.WriteLine("Qualidades: ");
      string D1 = qualidadesN3[0];
      Console.WriteLine("1° - " +D1);
      string D2 = qualidadesN3[1];
      Console.WriteLine("2° - " +D2);
      string D3 = qualidadesN3[2];
      Console.WriteLine("3° - " +D3);
      

    }
  }
