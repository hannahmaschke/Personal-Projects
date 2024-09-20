using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchTheCountry
{
    public class EasyMode
    {
        static public string[] name =
            {
                "Afghanistan",
                 "Australia",
                 "Argentina",
                 "Austria",
                 "Belgium",
                 "Brazil",
                 "Bulgaria",
                 "Chile",
                 "China",
                 "Colombia",
                 "Costa Rica",
                 "Cuba",
                 "Czechia",
                 "Denmark",
                 "Dominican Republic",
                 "Ecuador",
                 "Egypt",
                 "El Salvador",
                 "Ethiopia",
                 "Finland",
                 "France",
                 "Germany",
                 "Greece",
                 "Greenland",
                 "Guatemala",
                 "Guyana",
                 "Haiti",
                 "Honduras",
                 "Hong Kong",
                 "Hungary",
                 "Iceland",
                 "India",
                 "Indonesia",
                 "Iran",
                 "Iraq",
                 "Ireland",
                 "Israel",
                 "Italy",
                 "Jamaica",
                 "Japan",
                 "Jordan",
                 "Mexico",
                 "Nepal",
                 "Netherlands",
                 "New Zealand",
                 "Nicaragua",
                 "Nigeria",
                 "North Korea",
                 "Norway",
                 "Pakistan",
                 "Palestine",
                 "Panama",
                 "Paraguay",
                 "Peru",
                 "Philippines",
                 "Poland",
                 "Portugal",
                 "Russia",
                 "Saudi Arabia",
                 "Serbia",
                 "Singapore",
                 "South Africa",
                 "South Korea",
                 "Spain",
                 "Sri Lanka",
                 "Sweden",
                 "Switzerland",
                 "Syria",
                 "Thailand",
                 "Turkey",
                 "Uganda",
                 "United Kingdom",
                 "Ukraine",
                 "United Arab Emirates",
                 "United States",
                 "Uruguay",
                 "Venezuela",
                 "Vietnam",
                 "Zimbabwe"


        };


        static public Image[] flag =
        {
            Properties.Resources.Afghanistan,
            Properties.Resources.Australia,
            Properties.Resources.Argentina,
            Properties.Resources.Austria,
            Properties.Resources.Belgium,
            Properties.Resources.Brazil,
            Properties.Resources.Bulgaria,
            Properties.Resources.Chile,
            Properties.Resources.China,
            Properties.Resources.Colombia,
            Properties.Resources.Costa_Rica,
            Properties.Resources.Cuba,
            Properties.Resources.Czechia,
            Properties.Resources.Denmark,
            Properties.Resources.Dominican_Republic,
            Properties.Resources.Ecuador,
            Properties.Resources.Egypt,
            Properties.Resources.El_Salvador,
            Properties.Resources.Ethiopia,
            Properties.Resources.Finland,
            Properties.Resources.France,
            Properties.Resources.Germany,
            Properties.Resources.Greece,
            Properties.Resources.Greenland,
            Properties.Resources.Guatemala,
            Properties.Resources.Guyana,
            Properties.Resources.Haiti,
            Properties.Resources.Honduras,
            Properties.Resources.Hong_Kong,
            Properties.Resources.Hungary,
            Properties.Resources.Iceland,
            Properties.Resources.India,
            Properties.Resources.Indonesia,
            Properties.Resources.Iran,
            Properties.Resources.Iraq,
            Properties.Resources.Ireland,
            Properties.Resources.Israel,
            Properties.Resources.Italy,
            Properties.Resources.Jamaica,
            Properties.Resources.Japan,
            Properties.Resources.Jordan,
            Properties.Resources.Mexico,
            Properties.Resources.Nepal,
            Properties.Resources.Netherlands,
            Properties.Resources.New_Zealand,
            Properties.Resources.Nicaragua,
            Properties.Resources.Nigeria,
            Properties.Resources.North_Korea,
            Properties.Resources.Norway,
            Properties.Resources.Pakistan,
            Properties.Resources.Palestine,
            Properties.Resources.Panama,
            Properties.Resources.Paraguay,
            Properties.Resources.Peru,
            Properties.Resources.Philippines,
            Properties.Resources.Poland,
            Properties.Resources.Portugal,
            Properties.Resources.Russia,
            Properties.Resources.Saudi_Arabia,
            Properties.Resources.Serbia,
            Properties.Resources.Singapore,
            Properties.Resources.South_Africa,
            Properties.Resources.South_Korea,
            Properties.Resources.Spain,
            Properties.Resources.Sri_Lanka,
            Properties.Resources.Sweden,
            Properties.Resources.Switzerland,
            Properties.Resources.Syria,
            Properties.Resources.Thailand,
            Properties.Resources.Turkey,
            Properties.Resources.Uganda,
            Properties.Resources.UK,
            Properties.Resources.Ukraine,
            Properties.Resources.United_Arab_Emirates,
            Properties.Resources.United_States,
            Properties.Resources.Uruguay,
            Properties.Resources.Venezuela,
            Properties.Resources.Vietnam,
            Properties.Resources.Zimbabwe


        };

        static public string[] capital =
        {
                 "Kabul",          // Afghanistan
                 "Canberra",    // Australia
                 "Buenos Aires", // Argentina
                 "Vienna",    //Austria
                 "Brussels", //Belgium
                 "Brasilia", //Brazil
                 "Sofia", //Bulgaria
                 "Santiagos", //Chile
                 "Beijing",   //China
                 "Bogota", //Colombia
                 "San Jose", //Costa Rica
                 "Havana",  //Cuba
                 "Prague", //Czechia"
                 "Copenhagen", //Denmark
                 "Santo Domingo", //Dominican Republic
                 "Quito", //Ecuador 
                 "Cairo",  //Egypt
                 "San Salvador", //El Salvador
                 "Addis Ababa", //Ethiopia
                 "Helsinki",  //Finland
                 "Paris", //France
                 "Berlin", //Germany
                 "Athens", //Greece
                 "Nuuk", //Greenland
                 "Guatemala City", //Guatemala
                 "Georgetown", //Guyana
                 "Port-au-Prince", //Haiti
                 "Tegucigalpa", //Honduras
                 "Hong Kong", //Hong Kong
                 "Budapest", //Hungary
                 "Reykjavik", //Iceland
                 "New Delhi", //India
                 "Jakarta", //Indonesia
                 "Tehran", //Iran
                 "Baghdad", //Iraq
                 "Dublin", //Ireland
                 "Jerusalem", //Israel
                 "Rome", //Italy
                 "Kingston", //Jamaica
                 "Tokyo", //Japan
                 "Amman", //Jordan  
                 "Mexico City", //Mexico
                 "Kathmandu", //Nepal
                 "Amsterdam", //Netherlands
                 "Wellington", //New Zealand
                 "Managua", //Nicaragua
                 "Abuja", //Nigeria
                 "North Korea", //Pyongyang
                 "Oslo", //Norway
                 "Islamabad", //Pakistan
                 "Jerusalem", //Palestine
                 "Panama City", //Panama
                 "Asunción", //Paraguay
                 "Lima", //Peru
                 "Manila", //Philippines
                 "Warsaw", //Poland
                 "Lisbon", //Portugal
                 "Moscow", //Russia
                 "Riyadh", //Saudi Arabia
                 "Belgrade", //Serbia
                 "Singapore", //Singapore
                 "Cape Town", //South Africa
                 "Seoul", //South Korea
                 "Madrid", //Spain
                 "Colombo", //Sri Lanka
                 "Stockholm", //Sweden
                 "Bern", //Switzerland
                 "Damascus", //Syria
                 "Bangkok", //Thailand
                 "Ankara", //Turkey
                 "Kampala", //Uganda
                 "London", //United Kingdom
                 "Kyiv", //Ukraine
                 "Dubai", //United Arab Emirates
                 "Washington D.C.", //United States
                 "Montevideo", //Uruguay
                 "Caracas", //Venezuela
                 "Hanoi", //Vietnam
                 "Harare" //Zimbabwe
        };
    }
}
