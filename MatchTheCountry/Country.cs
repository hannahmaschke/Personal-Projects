using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace MatchTheCountry
{
    public class Country
    {

        static public string[] name =
            {
                "Afghanistan",
                 "Australia",
                 "Andorra",
                 "Armenia",
                 "Argentina",
                 "Austria",
                 "Algeria",
                 "Azerbaijan",
                 "Bolivia",
                 "Belgium",
                 "Bahamas",
                 "Bolivia",
                 "Belarus",
                 "Botswana",
                 "Angola",
                 "Antigua and Barbuda",
                 "Aruba",
                 "Bahrain",
                 "Bangladesh",
                 "Barbados",
                 "Belize",
                 "Benin",
                 "Bermuda",
                 "Bosnia and Herzegovina",
                 "Brazil",
                 "Brunei",
                 "Bulgaria",
                 "Burkina Faso",
                 "Burundi",
                 "Cabo Verde",
                 "Cambodia",
                 "Cayman Islands",
                 "Chad",
                 "Chile",
                 "China",
                 "Colombia",
                 "Congo",
                 "Costa Rica",
                 "Croatia",
                 "Cuba",
                 "Cyprus",
                 "Czechia",
                 "Denmark",
                 "Djibouti",
                 "Dominican Republic",
                 "Ecuador",
                 "Egypt",
                 "El Salvador",
                 "Eritrea",
                 "Estonia",
                 "Ethiopia",
                 "Fiji",
                 "Finland",
                 "France",
                 "French Polynesia",
                 "Georgia",
                 "Germany",
                 "Ghana",
                 "Greece",
                 "Greenland",
                 "Grenada",
                 "Guam",
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
                 "Kazakhstan",
                 "Kenya",
                 "Kuwait",
                 "Latvia",
                 "Lebanon",
                 "Libya",
                 "Lithuania",
                 "Luxembourg",
                 "Macedonia",
                 "Madagascar",
                 "Malaysia",
                 "Malta",
                 "Mexico",
                 "Monaco",
                 "Mongolia",
                 "Montenegro",
                 "Morocco",
                 "Mozambique",
                 "Myanmar",
                 "Nepal",
                 "Netherlands",
                 "New Zealand",
                 "Nicaragua",
                 "Niger",
                 "Nigeria",
                 "North Korea",
                 "Norway",
                 "Papua New Guinea",
                 "Pakistan",
                 "Palestine",
                 "Panama",
                 "Paraguay",
                 "Peru",
                 "Philippines",
                 "Poland",
                 "Portugal",
                 "Puerto Rico",
                 "Qatar",
                 "Romania",
                 "Russia",
                 "Rwanda",
                 "Samoa",
                 "Saudi Arabia",
                 "Senegal",
                 "Serbia",
                 "Seychelles",
                 "Sierra Leone",
                 "Singapore",
                 "Slovakia",
                 "Slovenia",
                 "Somalia",
                 "South Africa",
                 "South Korea",
                 "Spain",
                 "Sri Lanka",
                 "Sudan",
                 "Sweden",
                 "Switzerland",
                 "Syria",
                 "Tajikistan",
                 "Tanzania",
                 "Thailand",
                 "Trinidad and Tobago",
                 "Tunisia",
                 "Turkey",
                 "Turkmenistan",
                 "Turks and Caicos",
                 "Uganda",
                 "United Kingdom",
                 "Ukraine",
                 "United Arab Emirates",
                 "United States",
                 "Uruguay",
                 "Uzbekistan",
                 "U.S. Virgin_Islands",
                 "Venezuela",
                 "Vietnam",
                 "Yemen",
                 "Zambia",
                 "Zimbabwe"


        };

        static public Image[] flag =
        {
            Properties.Resources.Afghanistan,
            Properties.Resources.Australia,
            Properties.Resources.Andorra,
            Properties.Resources.Armenia,
            Properties.Resources.Argentina,
            Properties.Resources.Austria,
            Properties.Resources.Algeria,
            Properties.Resources.Azerbaijan,
            Properties.Resources.Bolivia,
            Properties.Resources.Belgium,
            Properties.Resources.Bahamas,
            Properties.Resources.Bolivia,
            Properties.Resources.Belarus,
            Properties.Resources.Botswana,
            Properties.Resources.Angola,
            Properties.Resources.Antigua_and_Barbuda,
            Properties.Resources.Aruba,
            Properties.Resources.Bahrain,
            Properties.Resources.Bangladesh,
            Properties.Resources.Barbados,
            Properties.Resources.Belize,
            Properties.Resources.Benin,
            Properties.Resources.Bermuda,
            Properties.Resources.Bosnia_and_Herzegovina,
            Properties.Resources.Brazil,
            Properties.Resources.Brunei,
            Properties.Resources.Bulgaria,
            Properties.Resources.Burkina_Faso,
            Properties.Resources.Burundi,
            Properties.Resources.Cabo_Verde,
            Properties.Resources.Cambodia,
            Properties.Resources.Cayman_Islands,
            Properties.Resources.Chad,
            Properties.Resources.Chile,
            Properties.Resources.China,
            Properties.Resources.Colombia,
            Properties.Resources.Congo,
            Properties.Resources.Costa_Rica,
            Properties.Resources.Croatia,
            Properties.Resources.Cuba,
            Properties.Resources.Cyprus,
            Properties.Resources.Czechia,
            Properties.Resources.Denmark,
            Properties.Resources.Djibouti,
            Properties.Resources.Dominican_Republic,
            Properties.Resources.Ecuador,
            Properties.Resources.Egypt,
            Properties.Resources.El_Salvador,
            Properties.Resources.Eritrea,
            Properties.Resources.Estonia,
            Properties.Resources.Ethiopia,
            Properties.Resources.Fiji,
            Properties.Resources.Finland,
            Properties.Resources.France,
            Properties.Resources.French_Polynesia,
            Properties.Resources.Georgia,
            Properties.Resources.Germany,
            Properties.Resources.Ghana,
            Properties.Resources.Greece,
            Properties.Resources.Greenland,
            Properties.Resources.Grenada,
            Properties.Resources.Guam,
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
            Properties.Resources.Kazakhstan,
            Properties.Resources.Kenya,
            Properties.Resources.Kuwait,
            Properties.Resources.Latvia,
            Properties.Resources.Lebanon,
            Properties.Resources.Libya,
            Properties.Resources.Lithuania,
            Properties.Resources.Luxembourg,
            Properties.Resources.Macedonia,
            Properties.Resources.Madagascar,
            Properties.Resources.Malaysia,
            Properties.Resources.Malta,
            Properties.Resources.Mexico,
            Properties.Resources.Monaco,
            Properties.Resources.Mongolia,
            Properties.Resources.Montenegro,
            Properties.Resources.Morocco,
            Properties.Resources.Mozambique,
            Properties.Resources.Myanmar,
            Properties.Resources.Nepal,
            Properties.Resources.Netherlands,
            Properties.Resources.New_Zealand,
            Properties.Resources.Nicaragua,
            Properties.Resources.Niger,
            Properties.Resources.Nigeria,
            Properties.Resources.North_Korea,
            Properties.Resources.Norway,
            Properties.Resources.Papua_New_Guinea,
            Properties.Resources.Pakistan,
            Properties.Resources.Palestine,
            Properties.Resources.Panama,
            Properties.Resources.Paraguay,
            Properties.Resources.Peru,
            Properties.Resources.Philippines,
            Properties.Resources.Poland,
            Properties.Resources.Portugal,
            Properties.Resources.Puerto_Rico,
            Properties.Resources.Qatar,
            Properties.Resources.Romania,
            Properties.Resources.Russia,
            Properties.Resources.Rwanda,
            Properties.Resources.Samoa,
            Properties.Resources.Saudi_Arabia,
            Properties.Resources.Senegal,
            Properties.Resources.Serbia,
            Properties.Resources.Seychelles,
            Properties.Resources.Sierra_Leone,
            Properties.Resources.Singapore,
            Properties.Resources.Slovakia,
            Properties.Resources.Slovenia,
            Properties.Resources.Somalia,
            Properties.Resources.South_Africa,
            Properties.Resources.South_Korea,
            Properties.Resources.Spain,
            Properties.Resources.Sri_Lanka,
            Properties.Resources.Sudan,
            Properties.Resources.Sweden,
            Properties.Resources.Switzerland,
            Properties.Resources.Syria,
            Properties.Resources.Tajikistan,
            Properties.Resources.Tanzania,
            Properties.Resources.Thailand,
            Properties.Resources.Trinidad_and_Tobago,
            Properties.Resources.Tunisia,
            Properties.Resources.Turkey,
            Properties.Resources.Turkmenistan,
            Properties.Resources.Turks_and_Caicos,
            Properties.Resources.Uganda,
            Properties.Resources.UK,
            Properties.Resources.Ukraine,
            Properties.Resources.United_Arab_Emirates,
            Properties.Resources.United_States,
            Properties.Resources.Uruguay,
            Properties.Resources.Uzbekistan,
            Properties.Resources.U_S__Virgin_Islands,
            Properties.Resources.Venezuela,
            Properties.Resources.Vietnam,
            Properties.Resources.Yemen,
            Properties.Resources.Zambia,
            Properties.Resources.Zimbabwe


        };

        static public string[] capital =
        {
                 "Kabul",          // Afghanistan
                 "Canberra",    // Australia
                 "Andorra la Vella", // Andorra
                 "Yerevan",   // Armenia
                 "Buenos Aires", // Argentina
                 "Vienna",    //Austria
                 "Algiers",   // Algeria
                 "Baku", // Azerbaijan
                 "Sucre",  //Bolivia
                 "Brussels", //Belgium
                 "Nassau", //Bahamas
                 "Sucre", //Bolivia
                 "Minsk", //Belarus
                 "Gaborone", //Botswana
                 "Luanda", //Angola
                 "Saint Johns",//Antigua and Barbuda
                 "Oranjestad", //Aruba
                 "Manama",//Bahrain
                 "Dhaka", //Bangladesh
                 "Bridgetown", //Barbados
                 "Belmopan", //Belize
                 "Porto-Novo", //Benin
                 "Hamilton", //Bermuda
                 "Sarajevo", //Bosnia and Herzegovina
                 "Brasilia", //Brazil
                 "Bandar Seri Begawan", //Brunei
                 "Sofia", //Bulgaria
                 "Ouagadougou", //Burkina Faso
                 "Gitega", //Burundi
                 "Praia", //Cabo Verde
                 "Phnom Penh",  //Cambodia
                 "George Town", //Cayman Islands
                 "N'Djamena", //Chad
                 "Santiagos", //Chile
                 "Beijing",   //China
                 "Bogota", //Colombia
                 "Kinshasa",  //Congo
                 "San Jose", //Costa Rica
                 "Zagreb", //Croatia
                 "Havana",  //Cuba
                 "Nicosia", //Cyprus
                 "Prague", //Czechia"
                 "Copenhagen", //Denmark
                 "Djibouti", //Djibouti
                 "Santo Domingo", //Dominican Republic
                 "Quito", //Ecuador 
                 "Cairo",  //Egypt
                 "San Salvador", //El Salvador
                 "Asmara", //Eritrea
                 "Estonia", //Tallinn
                 "Addis Ababa", //Ethiopia
                 "Suva",  //Fiji
                 "Helsinki",  //Finland
                 "Paris", //France
                 "Papeete", //French Polynesia
                 "Tbilisi", //Georgia
                 "Berlin", //Germany
                 "Accra", //Ghana
                 "Athens", //Greece
                 "Nuuk", //Greenland
                 "Saint Georges", //Grenada
                 "Hagatna", //Guam
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
                 "Astana", //Kazakhstan
                 "Nairobi", //Kenya
                 "Kuwait City", //Kuwait
                 "Riga", //Latvia
                 "Beirut", //Lebanon
                 "Tripoli", //Libya
                 "Vilnius", //Lithuania
                 "Luxembourg", //Luxembourg
                 "Skopje", //Macedonia
                 "Antananarivo", //Madagascar
                 "Kuala Lumpur", //Malaysia
                 "Valletta", //Malta
                 "Mexico City", //Mexico
                 "Monaco", //Monaco
                 "Ulaanbaatar", //Mongolia
                 "Podgorica", //Montenegro
                 "Rabat", //Morocco
                 "Maputo", //Mozambique
                 "Naypyidaw", //Myanmar
                 "Kathmandu", //Nepal
                 "Amsterdam", //Netherlands
                 "Wellington", //New Zealand
                 "Managua", //Nicaragua
                 "Niamey", //Niger
                 "Abuja", //Nigeria
                 "North Korea", //Pyongyang
                 "Oslo", //Norway
                 "Port Moresby", //Papua New Guinea
                 "Islamabad", //Pakistan
                 "Jerusalem", //Palestine
                 "Panama City", //Panama
                 "Asunción", //Paraguay
                 "Lima", //Peru
                 "Manila", //Philippines
                 "Warsaw", //Poland
                 "Lisbon", //Portugal
                 "San Juan", //Puerto Rico
                 "Doha", //Qatar
                 "Bucharest", //Romania
                 "Moscow", //Russia
                 "Kigali", //Rwanda
                 "Apia", //Samoa
                 "Riyadh", //Saudi Arabia
                 "Dakar", //Senegal
                 "Belgrade", //Serbia
                 "Victoria", //Seychelles
                 "Freetown", //Sierra Leone
                 "Singapore", //Singapore
                 "Bratislava", //Slovakia
                 "Ljubljana", //Slovenia
                 "Mogadishu", //Somalia
                 "Cape Town", //South Africa
                 "Seoul", //South Korea
                 "Madrid", //Spain
                 "Colombo", //Sri Lanka
                 "Khartoum", //Sudan
                 "Stockholm", //Sweden
                 "Bern", //Switzerland
                 "Damascus", //Syria
                 "Dushanbe", //Tajikistan
                 "Dodoma", //Tanzania
                 "Bangkok", //Thailand
                 "Port of Spain", //Trinidad and Tobago
                 "Tunis", //Tunisia
                 "Ankara", //Turkey
                 "Ashgabat", //Turkmenistan
                 "Cockburn Town", //Turks and Caicos
                 "Kampala", //Uganda
                 "London", //United Kingdom
                 "Kyiv", //Ukraine
                 "Dubai", //United Arab Emirates
                 "Washington D.C.", //United States
                 "Montevideo", //Uruguay
                 "Tashkent", //Uzbekistan
                 "Charlotte Amalie", //U.S. Virgin_Islands
                 "Caracas", //Venezuela
                 "Hanoi", //Vietnam
                 "Sana'a", //Yemen
                 "Lusaka", //Zambia
                 "Harare" //Zimbabwe
        };


    }
}