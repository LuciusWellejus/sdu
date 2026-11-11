// Exercise 19.1: CPR Registry
// Subtask 1: Implement in C# a class for this UML diagram.

// Note: The cpr field refers to a Danish social security number format called CPR.
// Hint: When the ToString method is defined in the UML class, then you have to override the method and give it a meaningful implementation.

// Subtask 2 Make a List that contains 5 Person objects. You decide the attribute values. One person must have the CPR number 010101-0101.
// 
// Subtask 3 Loop through your List object and find the person with the CPR number 010101-0101 by calling the method GetCpr on each object.
// Print the result of an (explicit or implicit) call to the ToString method on this object.
// 
//Subtask 4 Create a Dictionary<string, Person> map and add the Person objects to this map that you
// previously added to the List object in subtask 2. Use the CPR number as the key.
// 
// Subtask 5 Find the person with the CPR number 010101-0101 in the Dictionary object and print the 
// value returned from a call to the ToString method on this object.


class Method
{
    public static void Main(String[] args)
    {        
        
        List<Person> person = new List<Person>();
        // Person person = new person();
        
        // $"Name: {Name}, Age: {Age}, Cpr: {CPR},"
        person.Add(new Person("Kasper",15,"140705-0115"));
        person.Add(new Person("Marcus",19,"010101-0101"));
        person.Add(new Person("Marius",20,"140702-0145"));
        person.Add(new Person("Jeppe",19,"340702-1111"));
        person.Add(new Person("Nicklas",18,"140702-0115"));

        
        
        Dictionary<string, Person> map = new Dictionary<string, Person>();


        foreach (Person c in person)
        {
            map.Add(c.GetCpr(), c);
        }      

        foreach (Person c in personList)
        {
            Console.WriteLine($"{c}");
            
            if (c.GetCpr() == "010101-0101")
            {
                Console.WriteLine("Found Cpr 010101-0101");
            } if (map.TryGetValue(c.GetCpr(), out Person foundPerson))
            {
                Console.WriteLine(foundPerson.ToString());
        }
    }
}


public class Person
{    
    public string Name;
    public int Age;
    public string Cpr;
    
    public Person(string name, int age, string cpr)
    {
    Name = name;
    Age = age;
    Cpr = cpr;
    }
    
    public string GetName()
    {
        return Name;
    }
    
    public int GetAge()
    {
    return Age;
    }

    public string GetCpr()
    {
        return Cpr;
    }
    public override string ToString()
    {
     return $"Name: {Name}, Age: {Age}, Cpr: {Cpr},"; // then you have to override the method and give it a meaningful implementation.   
    }
}