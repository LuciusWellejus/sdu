class Cat
{
    Cat cat = new Cat(1);
}


if (cat.GetAge() == 1)

{
    cat.SetAge(2);
    if (cat.GetAge()==2)
    {
        cat.SetAge(4);
        if (cat.GetAge()==4)
        {
            Console.WriteLine("success");
        }
    }
}