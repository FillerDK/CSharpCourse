using L04_Delegates_4._7;

var people = Person.CreateListOfPeople();

////////////////////////////////
// Start here            
////////////////////////////////
// Hint:
// This piece of code
foreach (var p in people)
    p.PrintPersonName(PrintFullNameLastNameFirst);
// can be translated to
people.ForEach(p => p.PrintPersonName(PrintFullNameLastNameFirst));
// using the ForEach method on List<>. ForEach takes a Lambda as input

//
// Problem 1
// Use this to simplify the foreach statements in the while loop below
// so they take up only one line each, instead of two
//
// Problem 2 (Answer in less than 30 seconds)
// Did Problem 1 simplify or just make your code harder to read?
//
// Problem 3 (May be a hard problem)
// Give the PersonUserClass class a method PrintFullNameLastNameFirst (copy from Person class)
// And add a delegate called Formatter to your Person class
// and a method that takes a this type of delegate as input
// so this call becomes possible on a person:
//
// p.CallDelegate((F, L) => PrintFullNameLastNameFirst(F, L))
// Use this to translate all your ForEach lines in the while loop to something like
// people.ForEach(p => p.CallDelegate((F, L) => PrintFullNameLastNameFirst(F, L)));
//            

while (true) {
    Console.WriteLine("----------------------------------------------------");
    Console.WriteLine("Hvordan vil du have udskrevet navnene?");
    Console.WriteLine("1: Efternavn efterfulgt af fornavn");
    Console.WriteLine("2: Efternavn efterfulgt af fornavn, store bogstaver");
    Console.WriteLine("3: Efternavn efterfulgt af fornavn, små bogstaver");
    Console.WriteLine("4: Kun forbogstav af fornavn efterfulgt af efternavn");
    Console.WriteLine();
    Console.WriteLine("q: For at afslutte!");
    Console.Write("> ");
    var input = Console.ReadLine();
    switch (input.ToUpper()) {
        case "1":
            foreach (var p in people)
                p.PrintPersonName(PrintFullNameLastNameFirst);
            break;
        case "2":
            foreach (var p in people)
                p.PrintPersonName(PrintFullNameAllCaps);
            break;
        case "3":
            foreach (var p in people)
                p.PrintPersonName(PrintFullNameLowerCase);
            break;
        case "4":
            foreach (var p in people)
                p.PrintPersonName(PrintShortName);
            break;
        case "Q": return;
        default:
            Console.WriteLine("Ukendt valg, prøv igen");
            break;
    }
}

string PrintFullNameLastNameFirst(string firstName, string lastName) {
    return string.Format($"{lastName}, {firstName}");
}

string PrintFullNameAllCaps(string firstName, string lastName) {
    return string.Format($"{lastName.ToUpper()}, {firstName.ToUpper()}");
}

string PrintFullNameLowerCase(string firstName, string lastName) {
    return string.Format($"{lastName.ToLower()}, {firstName.ToLower()}");
}

string PrintShortName(string firstName, string lastName) {
    return string.Format($"{firstName.Substring(0, 1)}. {lastName}");
}