using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Activity_3.Models
{
    public class CustomGenerator
    {

        Random random = new Random();
        private String[] firstNameList = {"Andre","James", "John", "Robert", "Micheal", "William",

            "Ariana","Mary", "Patricia", "Jennifer", "Linda", "Elizabeth",

            "Joshua", "Nicole", "Cristal","Christian","Charles","David","Daniel","Joanna","Joe","Joseph",

            "Anna","Andrew","Benjamin","Betty","Charlie","DK","Danielle","Ester","Eugene","Frank","Fran","George","Geo",
            "Henry","Hwasa","Ian","Irelia","Jason","Jessica","Killmonger","Katarina","Lucian","Lissandra","Lanna","Monica","Matt",
            "Nathaniel","Natasha","Ophelia","Orlando","Patrick","Patricia","Queso","Quiche","Rachel","Randy","Sandy","Samuel","Tammy","Thomas",
            "Udyr","Ursula","Violet","Vince","Winston","Wanda","Wendy","Xena","Xander","Zadie","Zayne"
            }; //Most common first names male and female

        private String[] lastNameList = {"Smith", "Johnson", "Williams", " Jones", "Brown",
            "Davis", "Miller", "Wilson", "Moore", "Taylor"};    //Most common last names

        private String[] emailDomain = {"boogle", "lahoo","ping","lazy","gotmail","applejuice" };

        public string GenerateName()
        {
            return firstNameList[random.Next(firstNameList.Length)] + " " + lastNameList[random.Next(lastNameList.Length)];
        }

        public int GenerateAge()
        {
            return random.Next(18,99);  //only dealing with adults here!
        }

        public String GeneratePhone()
        {
            String phoneNumber = "";
            int num;
            num = random.Next(899) + 100;
            phoneNumber = "(" + num + ")";
            num = random.Next(899) + 100;
            phoneNumber += num + "-";
            num = random.Next(8999) + 1000;
            phoneNumber += num;
            return phoneNumber;
        }

        public string GenerateEmail(string name)
        {
            return "https://www." + name + "@" + emailDomain[random.Next(emailDomain.Length)] + ".com";
        }

        public List<Customer> GenerateCustomers(int amount)
        {
            List<Customer> returnList = new List<Customer>();
            for (int i = 0; i < amount; i++)
            {
                string name = GenerateName();
                returnList.Add(new Customer(returnList.Count, name, GenerateAge(), GeneratePhone(), GenerateEmail(String.Concat(name.Where(thename => !Char.IsWhiteSpace(thename))))));
            }
            return returnList;
        }
    }
}