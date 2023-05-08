using Microsoft.VisualBasic;

namespace C_HW_modul_05;

class Magazine
{
    public Magazine(string nameMagazine, string yearOfFoundation, string description, string phone,
        string email, UInt32 countOfEmployees)
    {
        _nameMagazine = nameMagazine;
        _yearOfFoundation = yearOfFoundation;
        _description = description;
        _phone = phone;
        _email = email;
        _countOfEmployees = countOfEmployees;
    }

    public string _nameMagazine { get; set; }
    public string _yearOfFoundation { get; set; }
    public string _description { get; set; }
    public string _phone { get; set; }
    public string _email { get; set; }

    public UInt32 _countOfEmployees { get; set; }

    public void print()
    {
        Console.WriteLine(
            _nameMagazine + "\n" + _yearOfFoundation + "\n" + _description + "\n" + _phone + "\n" + _email + "\n" +
            _countOfEmployees);
    }

    public static Magazine operator +(Magazine magazine, UInt32 count)
    {
        magazine._countOfEmployees += count;
        return magazine;
    }

    public static Magazine operator -(Magazine magazine, UInt32 count)
    {
        magazine._countOfEmployees -= count;
        return magazine;
    }

    public static bool operator ==(Magazine magazine1, Magazine magazine2)
    {
        if (magazine2._countOfEmployees == magazine1._countOfEmployees)
            return true;
        return false;
    }

    public static bool operator !=(Magazine magazine1, Magazine magazine2)
    {
        if (magazine2._countOfEmployees != magazine1._countOfEmployees)
            return true;
        return false;
    }

    public static bool operator >(Magazine magazine1, Magazine magazine2)
    {
        if (magazine1._countOfEmployees > magazine2._countOfEmployees)
            return true;
        return false;
    }

    public static bool operator <(Magazine magazine1, Magazine magazine2)
    {
        if (magazine1._countOfEmployees < magazine2._countOfEmployees)
            return true;
        return false;
    }

    public override bool Equals(Object obj)
    {
        Magazine magazine = (Magazine)obj;
        if (_countOfEmployees == magazine._countOfEmployees)
            return true;
        return false;
    }
}

class Shop
{
    public Shop(string nameMagazine, string adress, string description, string phone, string email, double square)
    {
        _nameMagazine = nameMagazine;
        _adress = adress;
        _description = description;
        _phone = phone;
        _email = email;
        _square = square;
    }

    public string _nameMagazine { get; set; }
    public string _adress { get; set; }
    public string _description { get; set; }
    public string _phone { get; set; }
    public string _email { get; set; }
    public double _square { get; set; }

    public void print()
    {
        Console.WriteLine(_nameMagazine + "\n" + _adress + "\n" + _description + "\n" + _phone + "\n" + _email + "\n" +
                          _square);
    }


    public static Shop operator +(Shop shop, UInt32 count)
    {
        shop._square += count;
        return shop;
    }

    public static Shop operator -(Shop shop, UInt32 count)
    {
        shop._square -= count;
        return shop;
    }

    public static bool operator ==(Shop shop1, Shop shop2)
    {
        if (shop1._square == shop2._square)
            return true;
        return false;
    }

    public static bool operator !=(Shop shop1, Shop shop2)
    {
        if (shop1._square != shop2._square)
            return true;
        return false;
    }

    public static bool operator >(Shop shop1, Shop shop2)
    {
        if (shop1._square > shop2._square)
            return true;
        return false;
    }

    public static bool operator <(Shop shop1, Shop shop2)
    {
        if (shop1._square < shop2._square)
            return true;
        return false;
    }

    public override bool Equals(Object obj)
    {
        Shop shop = (Shop)obj;
        if (_square == shop._square)
            return true;
        return false;
    }
}

class BookList
{
    public BookList()
    {
    }

    public void print()
    {
        foreach (var book in _booklist)
        {
            Console.WriteLine(book);
        }
    }

    public static BookList operator +(BookList blist, string nameBook)
    {
        blist._booklist.Add(nameBook);
        return blist;
    }

    public static BookList operator -(BookList blist, string nameBook)
    {
        blist._booklist.Remove(nameBook);
        return blist;
    }

    public static bool operator ==(BookList blist, string nameBook)
    {
        foreach (var book in blist._booklist)
        {
            if (nameBook == book)
                return true;
        }

        return false;
    }

    public static bool operator !=(BookList blist, string nameBook)
    {
        foreach (var book in blist._booklist)
        {
            if (nameBook == book)
                return false;
        }

        return true;
    }

    public string this[int index]
    {
        get => _booklist[index];
        set => _booklist[index] = value;
    }

    public int IndexBook(string nameBook)
    {
        for (int i = 0; i < _booklist.Capacity; i++)
        {
            if (_booklist[i] == nameBook)
            {
                return i;
            }
        }

        return -1;
    }

    private List<string> _booklist = new List<string>();
}