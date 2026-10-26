class Program 
{ 
    static void Main() 
    { 
        Thread thread1 = new Thread(new ThreadStart(Loop1)); 
        Thread thread2 = new Thread(new ThreadStart(Loop2)); 
 
        thread1.Start(); 
        thread2.Start(); 
 
        thread1.Join(); 
        thread2.Join(); 
    } 
 
    static void Loop1() 
    { 
        for (int i = 0; i < 10; i++) 
        { 
            Console.WriteLine("Loop 1: " + i); 
        } 
    } 
 
    static void Loop2() 
    { 
        for (int i = 0; i < 10; i++) 
        { 
            Console.WriteLine("Loop 2: " + i); 
        } 
    } 
} 