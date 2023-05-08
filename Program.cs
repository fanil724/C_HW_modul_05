using C_HW_modul_05;

// Magazine magazine = new Magazine("Igromir", "1995", "games", "8956246354654", "igromir@mail.ru", 23);
// Magazine magazine2 = new Magazine("Igromir", "1995", "games", "8956246354654", "igromir@mail.ru", 3);
// Console.WriteLine(magazine._countOfEmployees);
// Console.WriteLine(magazine2._countOfEmployees);
// Console.WriteLine(magazine2.Equals(magazine));
// Shop shop1 = new Shop("magnit","56/20г","продуктовый","888552549623","magnit@mail.ru",502.3);
// Shop shop2 = new Shop("magnit","56/20г","продуктовый","888552549623","magnit@mail.ru",502.3);
// // shop1 -= 234;
// shop1.print();
// Console.WriteLine();
// shop2.print();
// Console.WriteLine("\n"+(shop1.Equals(shop2)));
BookList book = new BookList();
book += "история";
book += "химия";
book += "информатика";
book += "физика";
book += "литература";
book += "математика";
book.print();
book[2] = "шекспир";
// book -= "химия";
Console.WriteLine();
book.print();
Console.WriteLine(book.IndexBook("физика"));

// Console.WriteLine(book != "химия");