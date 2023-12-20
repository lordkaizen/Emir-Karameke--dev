﻿namespace ConsoleUI;

// Class default access modifier (erişim belirteci): internal
class Ogrenci
{
    // default access modifier: private
    internal string FirstName { get; set; } // Property
    internal string LastName { get; set; } // Property
    internal int Yas { get; set; } // Property

    internal string FullName { 
        get { 
            return $"{FirstName} {LastName}";
        } 
    }
    //internal string GetFullName()
    //{
    //    return $"{FirstName} {LastName}";
    //}
}
