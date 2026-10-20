Person person = new Person{name="L", age = 20, adult = true};

Console.WriteLine($"{person.name} is {person.age} years old. Is he an adult? {person.adult}$");

class Person{
    public string name;
    public int age;
    public bool adult;
}