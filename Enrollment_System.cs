// Exercise 17.1: Enrollment System

// With all of that as a starting point:

// 1. The program specification has the significant deficiency that it doesn’t describe any possibility to add,
// or remove courses or students. Update the specification so that this functionality is included in the specification.

// 2. Update the list of requirements to reflect these changes.

// 3. Redo the noun/verb analysis on the reviced program specification, and update the list of methods and/or classes.

// 4. Update the CRC card so that it matches the new noun-verb analysis and requiremetns. Add new cards if necessary.

// 5. Update the UML cladd diagram so that it reflects your updated CRC card.

// 6. Update the implementation of the program so that it reflects your new UML class diagram.
// 
// 2.
// F04 Add ajd rek0ve c08rses 
// F05 Add and remove studnets - it must be possible add and remove student from
// 
// 3.
// verb 'add' and 'remove'
// noun 'students' and 'courses'
// 
// 4. 
// Can remove student objects from
// can remove courses objects from 
// can add student object from
//  can 
// 
// 
// 
class Method
{
    public static void Main(String[] args)
    {
        Course[] new courses new courses[]course.length+1]
        for (int i=0; i < course. length; i++)
        newCoourses[i] = courses[i];

        newCourses[i] courses[i];

        newCourses[course.Length]=course;
        courses = newCourses
        
    }    
}

public void add course(Course course)
{ 
}

public add course()new Course('course'))


//
class EnrollmentSystem
{
    public static void Main(String[] args)
    {
        Student student = new Student();
        Console.WriteLine($"The total students are"{EnrollmentSystem{student}}));
        
    }    
}


public class Student 
{ 
    public string name; 
    public int id; 
    
    public Student (string nameValue, int idValue) 
    { 
        name = nameValue; 
        id = idValue; 
    } 
    
    public string GetName() 
    { 
        return name; 
    } 
} 

public class Course 
{ 
    string name; 
    Student[] participants; 
    
    public Course (string nameValue) 
    { 
        name = nameValue; 
        participants = new Student[10]; 
    } 
    
    public void Enroll (Student student) 
    { 
        for (int i=0 ; i<participants.Length ; i++) 
        { 
            if (participants[i] == null) 
            { 
                participants[i] = student; 
                return; 
            } 
        } 
    } 
    
    // RETTELSE 1: Fjernede den ekstra slut-klamme, der var herover, så Remove er inde i klassen
    public void Remove (Student student) 
    { 
        for (int i=0 ; i<participants.Length ; i++) 
        { 
            if (participants[i] == student) 
            { 
                participants[i] = null; 
            } 
        } 
    } 
    
    public Student[] GetParticipants () 
    { 
        // count number of entries 
        int count = 0; 
        foreach (Student student in participants) 
        { 
            if (student != null) 
            { 
                count++; 
            } 
        } 
        
        // RETTELSE 2: Fjernede den slut-klamme, der lukkede metoden for tidligt herover
        
        // make a copy 
        Student[] result = new Student[count]; 
        int index = 0; 
        foreach (Student student in participants) 
        { 
            if (student != null) 
            { 
                result[index++] = student; 
            } 
        } 
        return result; 
    } // Denne klamme lukker nu GetParticipants() korrekt
} // Denne klamme lukker Course-klassen korrekt

public class EnrollmentSystem 
{ 
    public Student[] students; 
    public Course[] courses; 
    
    public void Enroll(Student student, Course course) 
    { 
        course.Enroll(student); 
    } 
    
    public void Remove(Student student, Course course) 
    { 
        course.Remove(student); 
    } 
    
    public void ShowParticipants(Course course) 
    { 
        foreach (Student student in course.GetParticipants()) 
        { 
            Console.WriteLine(student.GetName()); 
        } 
    } 
    
    public void GetCourses() 
    { 
        Console.WriteLine("void for a getter?"); 
    } 
    
    public void GetStudents() 
    { 
        Console.WriteLine("void for a getter?"); 
    } 
}