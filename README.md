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
