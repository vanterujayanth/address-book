using AdressBook;
using System;
using System.Collections.Generic;
class AddressBookMainFunction
{
    public static void Main(string[] args)
    {

        
       PersionalDetails p1 = new PersionalDetails("jayanth","v","kavali","90908957","nellore","india","524201","vasd@efew");
       AddresBookOPerations a1 = new AddresBookOPerations(); 
       PersionalDetails p2 = new PersionalDetails("Somesh", "v", "kavali", "90908957", "nellore", "india", "524201", "vasd@efew");     
       p1 = new PersionalDetails("jayanthjhhi", "v", "kavali", "90908957", "nellore", "india", "524201", "vasd@efew");

       a1.AddContact(p1);
       a1.AddContact(p2);
       a1.Show();
        experssions e1 = new experssions();
        //  a1.FindThePerson("jayanth", "v");
        // // a1.EditDEtails("jayanth", "v");
        ////  a1.DeliteTheIndex("jayanth", "v");

        //  a1.Show();

        // Console.ReadKey();
    }
}