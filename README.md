This is a very simple library to check if two proper first names are the same.  For instance Abe is short for Abraham so Abe Smith and Abraham Smith are likely to be the same name.  At the moment there are two static methods for your use

```NameSearch.GetOtherFormsOfNames(String name)``` -  returns a list of other forms of the name, including the given form.

```NameSearch.AreTheSame(String name1, String name2)``` -  returns true if the names are the same and false otherwise.

The namedatabase was taken from Brian Lalonde's perl module which can be found at http://search.cpan.org/~brianl/Lingua-EN-Nickname/Nickname.pm.
