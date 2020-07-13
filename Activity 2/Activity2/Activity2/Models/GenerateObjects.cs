using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Activity2.Models
{
    public class GenerateObjects
    {
        //most of this code is from when I wanted to generate contacts on the fly, and not want to hard code anything in to a list.
        //this made making 5 contacts or 100,000 contacts easy to generate.
        //this has been refined as time went on

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


        private String[] nickNameList = {"BigGuy","TheDude","CoolCat","CircleJ","ThatOneGuy","ThatOneGirl","WhatsHisName","WhatsHerName",
                                    "SomeDude","SomeGirl","SomeGuy","NickName"}; //decided 

        private String[] emailDomain = {"Potato", "FrenchFries", "Oops", "GetMoreRam", "NotAScam",
            "TotallyAScam","Yikes","Oof","Poke", }; //the @something.com


        private String[] CityCodes = { "PHX","LAX","SEA","HNL","NYC", "SFO","SAN", "LAS", "DCA", "CHI", "ATL",
                                        "SYD","CBR","MEL","PER","BNE",
                                        "YTO","YOW","YVR","YMQ",
                                        "MNL","CEB",
                                        "TYO","HND","NRT","OSA",}; //these are the 3 letter city codes
                                                                   //as followed, USA, Australia, Canada, Philippines, Japan

        private String[] TerminalCode = {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z" };
        Random random = new Random();
        public string GenerateName()
        {
            return firstNameList[random.Next(firstNameList.Length)] + " " + lastNameList[random.Next(lastNameList.Length)];
        }

        public string GenerateEmail()
        {
            int determine = random.Next(100);
            if (determine % 2 == 0)
            {
                return "https://www." + firstNameList[random.Next(firstNameList.Length)] + "." + lastNameList[random.Next(lastNameList.Length)] + "@" + emailDomain[random.Next(emailDomain.Length)] + ".com";
            }
            else
            {
                return "https://www." + nickNameList[random.Next(nickNameList.Length)] + "@" + emailDomain[random.Next(emailDomain.Length)] + ".com";
            }
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

        public List<UserModel> GenerateSomeUsers(int amount)
        {
            List<UserModel> returnList = new List<UserModel>();
            for (int count = 0; count < amount; count++)
            {
                returnList.Add(new UserModel(GenerateName(),GenerateEmail(),GeneratePhone()));
            }
            return returnList;
        }


        //generate airline ticket
        public string GenerateTerminal()
        {
            return TerminalCode[random.Next(TerminalCode.Length)] + random.Next(30);
        }
        public string GenerateCurrentCity()
        {
            return CityCodes[random.Next(CityCodes.Length)];
        }
        public string GenerateDestination(string CurrentCity)
        {
            List<String> removeCurrent = new List<string>(CityCodes);
            removeCurrent.Remove(CurrentCity);
            return removeCurrent[random.Next(removeCurrent.Count)]; 
        }
        public string GenerateSeat()
        {
            return random.Next(3) + TerminalCode[random.Next(TerminalCode.Length)];
        }
        public DateTime GenerateDeparture()
        {         
            return DateTime.Today.AddMinutes(random.Next(1320)+120);     //at least two hour flight, then maximum of one day away.
        }
        public int GenerateFlightNumber()
        {
            return random.Next(998)+1;
        }

        public List<AirlineTicket> GetAirlineTickets(int amount)
        {
            List<AirlineTicket> returnList = new List<AirlineTicket>();
            for (int count = 0; count < amount; count++)
            {
                string currentcity = GenerateCurrentCity();
                returnList.Add(new AirlineTicket(GenerateName(),GenerateTerminal(),GenerateDestination(currentcity),currentcity,GenerateSeat(),GenerateDeparture(),GenerateFlightNumber()));
            }
            return returnList;
        }
    }
}