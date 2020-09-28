using System;

class MainClass {
  public static void Main (string[] args) {
 
  double a, r, v;
  Console.WriteLine("\n Exercício C");
  Console.WriteLine("O valor do volume de uma lata");
 
  Console.WriteLine("Digite o raio");
  r = double.Parse(Console.ReadLine());
  Console.WriteLine("Digite o altura");
  a = double.Parse(Console.ReadLine());

  //VOLUME ← 3.14159 * R^2 * ALTURA
  v = (3.14159 * (r * r) * a);
  Console.WriteLine("A apresentação do valor é:" + v);
  }
}