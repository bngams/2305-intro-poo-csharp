// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// créer un tableau
//   0  1  2  3    4 
//  [10] [] [] [] [20]
int[] numbers = new int[5];

numbers[0] = 10;
numbers[4] = 20;

//   0    1    2    3    4 
//  [10] [20] [30] [40] [20]
int[] numbersBis = {10, 20, 30, 40, 50};


// parcours du tableau
for (int i = 0; i < 5; i++)
{
  // aficher uniquement les nombres pairs
  // operator modulo %
  if(numbersBis[i] % 2 == 0) {
    Console.WriteLine(numbersBis[i]);
  }
}

foreach (int n in numbersBis)
{
  if(n % 2 == 0) {
    Console.WriteLine(n);
  }
}