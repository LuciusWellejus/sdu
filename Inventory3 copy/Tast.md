Exercise 25.1: Inventory

These tasks build on the series of tasks about a storage system. The task includes the code from
section 25.10.0.1 below. There is quite a bit.

Subtask 1
Create a new project in your development environment and add the files from section 25.10.0.1.
Make sure that the Main method in Test runs and that it behaves in a reasonable way.

Subtask 2
The code is divided into 3 namespaces. Look through the code and count how many references
there are from one file to another. A reference means a method call or an access to an attribute/variable. It is not so important that the numbers are exact and you can just focus on
references that cross namespaces. Furthermore, we are not interested in whether the references
are at the object or class level (count both). Complete the following table so that one field
contains the number of references from a file on the x-axis to a file on the y-axis. Time how long
it takes to complete the table.

Subtask 3
Describe the responsibilities of each namespace.

Subtask 4
Based on the analysis in subtask 2, describe the extent to which these responsibilities depend on
each other.
If you want to change a file in the Domain namespace, which files could you risk having to adjust
in order not to introduce an error? In which namespaces are these files located? How do these
answers depend on which file the change is made in?

Subtask 5
How would the answer to the previous task change if we had another project (that we did not
know about) that used our Domain namespace?

Subtask 6
Now create a copy of the project and add a namespace named Interface with an interface
named IDomain. This interface must contain the following content:

Subtask 7
Now create a class named Domain in the namespace Domain. This class must be declared public
and implement the interface Interface.IDomain. This class must now function as the only link
between the Domain namespace and the Presentation namespace.
To do this, the constructor must take a filename of type string as an argument. This filename
must be stored in an object attribute named filename. In addition, the constructor must create
an Inventory object and store a reference to it in an object variable named inventory.
Override all the methods from Interface.IDomain:
• Load This method should call Load on inventory with filename as argument.
• Store This method should call Store on inventory with filename as argument.
• AddNonFoodItem This method should create a NonFoodItem object with the parameters it has received, and call AddItem on inventory with this object as argument.

Subtask 8
Modify the access modifiers in ALL other classes in the namespace Domain to be default (in other
words, remove the public keyword before the class names).
Update all classes in the namespace Presentation to create an object of type Domain.Domain,
store this in a variable of type Interface.IDomain and make sure that all references to the
Domain namespace go through this object.
Make sure that the Main method in Test can run and that it behaves in a reasonable manner.

Subtask 9
Now we have two versions of this codebase: the released one and the updated one. They do the
same thing, but have different code qualities.
Let’s repeat subtask 4 for the updated codebase: If you want to change a file in the Domain
namespace, which files could you risk having to adjust in order not to introduce an error? In
which namespaces are these files located? How do these answers depend on which file the change
is made in?
Let’s repeat subtask 5 for the updated codebase: How would the answer to the previous task
change if we had another project (that we didn’t know about) that used our Domain namespace?

Subtask 10
In what ways is which codebase better?