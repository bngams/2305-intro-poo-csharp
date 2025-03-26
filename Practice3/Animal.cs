public class Animal {
  public string Name { get; set; }
  public int Age { get; set; }
  public bool EstAdopte { get; set; }

  public Animal(string name, int age, bool estAdopte) {
    Name = name;
    Age = age;
    EstAdopte = estAdopte;
  }

  public virtual void SePresenter() {
    Console.WriteLine($"Je suis un animal nommé {Name} et j'ai {Age} an(s).");
  }
}