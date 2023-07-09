using System;
class Address 
{
 public string _streetAddress;
 public string _city;
 public string _stateOrProvince;


    public AddressNotUSA() 
    {
    return;
    }

    Address() 
    {
        Console.WriteLine($"Address: " {_streetAddress}, {_city}, {_stateOrProvince});
    }

}





