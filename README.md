# Iterators-And-Comparators

1. Library
Create a class Book which should have three public properties:
 string Title
 int Year
 List&lt;string&gt; Authors
Authors can be anonymous, one or many. A Book should have only one constructor.
Create a class Library which should store a collection of books and implement the IEnumerable&lt;Book&gt; interface.
 List&lt;Book&gt; books
A Library should be could be intilized without books or with any number of books and should have only one
constructor.

2. Library Iterator
Extend your solution from the prevoius task. Inside the Library class create a nested class LibraryIterator which
should implement the IEnumerator&lt;Book&gt; interface. Try to implement the bodies of the inherited methods by
yourself. You will need two more members:
 List&lt;Book&gt; books
 int currentIndex
Now you should be able to iterate through a Library in the Main method.

3. Comparable Book
Extend your solution from the prevoius task. Implement the IComparable&lt;Book&gt; interface in the existing class
Book. The comparison between two books should happen in the following order:
 First sort them in ascending chronological order (by year)
 If two books are published in the same year, sort them alphabetically
Override the ToString() method in your Book class so it returns a string in the format:
 {title} - {year}
Change your Library class so that it stores the books in the correct order.
You don’t need to change anything in your Main method from the previous task except for the way to print a book
on the Console.

4. Book Comparator
Extend your solution from the prevoius task. Create a class BookComparator which should implement the
IComparer&lt;Book&gt; interface and thus include the following method:
 int Compare(Book, Book)
BookComparator must compare two books by:
1. Book title - alphabetical order
2. Year of publishing a book - from the newest to the oldest
Modify your Library class once again to implement the new sorting.

Problem 1. ListyIterator
Create a generic class &quot;ListyIterator&quot;, it should receive the collection which it will iterate over, through its
constructor. You should store the elements in a List. The class should have three main functions:
 Move - should move an internal index position to the next index in the list, the method should return true if
it successfully moved and false if there is no next index.
 HasNext - should return true if there is a next index and false if the index is already at the last element of
the list.
 Print - should print the element at the current internal index, calling Print on a collection without elements
should throw an appropriate exception with the message &quot;Invalid Operation!&quot;.
By default, the internal index should be pointing to the 0 th index of the List. Your program should support the
following commands:
Create {e1 e2 …} void Creates a ListyIterator from the
specified collection. In case of a
Create command without any elements,
you should create a ListyIterator
with an empty collection.
Move boolean This command should move the
internal index to the next index.
Print void This command should print the
element at the current internal
index.
HasNext boolean Returns whether the collection has a
next element.
END void Stops the input.
Input
Input will come from the console as lines of commands. The first line will always be the only Create command in the
input. The last command received will always be the only END command.
Output
For every command from the input (with the exception of the END and Create commands) print the result of that
command on the console, each on a new line. In case of Move or HasNext commands print the return value of the
methods, in case of a Print command you don’t have to do anything additional as the method itself should already
print on the console. Your program should catch any exceptions thrown because of validations (calling Print on an
empty collection) and print their messages instead.
Constraints:
 There will always be only 1 Create command and it will always be the first command passed.
 The number of commands received will be between [1…100].
 The last command will always be the only END command.

Problem 2. Collection
Using the ListyIterator from the last problem, extend it by implementing the IEnumerable&lt;T&gt; interface, implement
all methods desired by the interface manually (use yield return for GetEnumerator() method). Add a new command
PrintAll that should foreach the collection and print all elements on a single line separated by a space.
Input
Input will come from the console as lines of commands. The first line will always be the only Create command in the
input. The last command received will always be the only END command.
Output
For every command from the input (with the exception of the END and Create commands) print the result of that
command on the console, each on a new line. In case of Move or HasNext commands print the return value of the
method, in case of a Print command you don’t have to do anything additional as the method itself should already
print on the console. In case of a PrintAll command you should print all elements on a single line separated by
spaces. Your program should catch any exceptions thrown because of validations and print their messages instead.
Constraints
 Do NOTuse the GetEnumerator() method from the base class. Use your own implementation using “yield
return”
 There will always be only 1 Create command and it will always be the first command passed.
 The number of commands received will be between [1…100].
 The last command will always be the only END command.

Problem 3. Stack
Since you have passed the basic algorithms course, now you have a task to create your custom stack. You are aware
of the Stack&#39;s structure. There is a collection to store the elements and two functions (not from the functional
programming) - to push an element and to pop it. Keep in mind that the first element which is popped is the last in
the collection. The push method adds an element to the top of the collection and the pop method returns the top
element and removes it.
Write your custom implementation of Stack&lt;T&gt; and implement IEnumerable&lt;T&gt; interface. Your implementation of
the GetEnumerator() method should follow the rules of the Abstract Data Type – Stack (return the elements in
reverse order of adding them to the stack)
Input
The input will come from the console as lines of commands. Commands will only be push and pop, followed by
integers for the push command and no another input for the pop command.
Format:
 Push {element1}, {element2}, … {elementN} – add given elements to the stack
 Pop – removes the last pushed element from the stack
Output
When you receive END, the input is over. Foreach the stack twice and print all elements each on new line.
Constraints
 The elements in the push command will be valid integers between [2 -32 …2 32 -1].
 The commands will always be valid (always be either Push, Pop or END).
 If Pop command could not be executed as expected (e.g. no elements in the stack), print on the console:
&quot;No elements&quot;.

Problem 4. Froggy
Let&#39;s play a game. You have a tiny little Frog, and a Lake that has path of stones in it. Every stone has a number. Our
frog must cross the lake along that path and then return. But there are some rules when jumping on the stones.
Firstly, the frog must jump on all even positions of the stones in ascending order and then on all odd positions but
in reversed order. The order of the stones and their numbers will be given on the first line of input. Then you must
print the order of stones in which our frog jumped from one to the other.
Try to achieve this functionality by creating a class Lake (it will hold all stone numbers in order) that implements
IEnumerable&lt;int&gt; interface and overrides its GetEnumerator() methods.

Problem 5. Comparing Objects
There is a Comparable interface but probably you already know it. Your task is simple. Create a class Person. Each
person should have a name, an age and a town. You should implement the interface – IComparable&lt;T&gt; and
implement the CompareTo method. When you compare two people, first you should compare their names, after
that - their age and finally - their towns.
Input
On every line, you will be given people in format:
{name} {age} {town}
Collect them till you receive &quot;END&quot;
After that, you will receive an integer N - the N th person in your collection. Starting from 1.
Output
On the single output line, you should bring statistics, how many people are equal to him, how many people are not
equal to him and the total people in your collection.
Format: {number of equal people} {number of not equal people} {total number of people}
Constraints
Input names, ages and addresses will be valid. Input number will be always а valid integer in range [2…100]
If there are no equal people print: &quot;No matches&quot;

Problem 6. Strategy Pattern
An interesting pattern you may have heard of is the Strategy Pattern, if we have multiple ways to do a task (say sort
a collection) it allows the client to choose the way that most fits his needs. A famous implementation of the pattern
in C# are the List&lt;T&gt;.Sort() and Array.Sort() methods that take an IComparer as an argument.
Create a class Person that holds a name and age. Create 2 Comparators for Person (classes which implement the
IComparer&lt;Person&gt; interface). The first comparator should compare people based on the length of their name as a
first parameter, if 2 people have a name with the same length, perform a case-insensitive compare based on the
first letter of their name instead. The second comparator should compare them based on their age.
Create 2 SortedSets of type Person, the first should implement the name comparator and the second
should implement the age comparator.
Input
On the first line of input you will receive a number N. On each of the next N lines you will receive information about
people in the format “&lt;name&gt; &lt;age&gt;”. Add the people from the input into both sets (both sets should hold all the
people passed in from the input).
Output
Foreach the sets and print each person from the set on a new line in the same format that you received them. Start
with the set that implements the name comparator.
Constraints
 A person’s name will be a string that contains only alphanumerical characters with a length between [1…50]
symbols.
 A person’s age will be a positive integer between [1…100].
 The number of people N will be a positive integer between [0…100].