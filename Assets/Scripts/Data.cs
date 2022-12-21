using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    public static string[] Animals;
    public static string[] Basketball;
    public static string[] Lotr;
    public static string[] Marvel;
    public static string[] Geography;
    public static string[] Professions;
    public static string[] Football;
    public static string[] Furniture;
    public static string[] Famous;
    public static string[] Countries;
    public static string[] Cartoon;
    public static string[] Winter;

    private void Awake()
    {

        Animals = new string[] {"Anteater","Turkey","Lama","Antelope","Owl","Armadillo","Hippopotamus","Goat","Eyelash","Bat",
                                "Pig","Parrot","Squid","Weasel","Octopus","Seahorse","Chicken","Otter","Starfish","Jackal",
                                "Lynx","Meerkat","Rat","Horse","Mandate","Killer Whale","Slugs","Raccoon","Penguin","Elephant",
                                "Beaver","Deer","Shark","Ostrich","Crow","Wolf","Dog", "Bear", "Cat","Snake", "Bird","Monkey",
                                "Crocodile", "Lion", "Tiger" , "Turtle", "Parrot","Fish", "Hamster","Leopard","Jaguar",
                                "Sea Lion","Panther","Mole","Eagle","Pigeon","Nightingale","Slat","Camel","Duck","Panda"}; //60


        Basketball = new string[] {"Derrick Rose","Andre Iguodala","Russell Westbrook","Kawhi Leonard","DeMar DeRozan","Chris Paul","Ja Morant","Devin Booker","Joel Embiid",
                                    "Nikola Jokic","Omer Asik","Ýbrahim Kutluay","Hidayet Turkoglu","Mehmet Okur","Omer Faruk Yurtseven","Furkan Korkmaz",
                                    "Cedi Osman","Alperen Sengun","Zion Williamson","Collin Sexton","Bam Adebayo","Josh Green","Marc Gasol","T.J. Warren",
                                    "Dennis Smith Jr.","Josh Richardson","James Harden","Jaylen Adams","Victor Oladipo","Mo Bamba","Jaxson Hayes","George Hill",
                                    "Karl-Anthony Towns","Facundo Campazzo","Klay Thompson","Trevor Ariza","Kyle Kuzma","Serge Ibaka","Lauri Markkanen","Raul Neto",
                                    "Pat Connaughton","Bruce Brown","Kyle Lowry","Terrance Ferguson","Kelly Olynyk","Jonathan Isaac","Clint Capela","Jaren Jackson Jr.",
                                    "Isaiah Hartenstein","Damian Lillard","Doug McDermott","Ish Smith","Udonis Haslem","Kentavious Caldwell-Pope","Talen Horton-Tucker",
                                    "Garrison Mathews","Cody Martin","Jordan Bell","Patrick Beverley","Ersan Ilyasova","Aaron Holiday","Christian Wood",
                                    "Paul Millsap","Derrick Jones Jr.","Evan Fournier","Michael Carter-Williams","Jarred Vanderbilt","Bobby Portis",
                                    "Norvel Pelle","Skylar Mays","Georges Niang","Shai Gilgeous-Alexander","Lebron James", "Kobe Bryant","J. R. Smith",
                                    "Michael Jordan","Wilt Chamberlain", "Alperen Sengun", "Stephen Curry", "Dirk Nowitzki", "Jayson Tatum" ,
                                    "Kevin Durant", "Shaquille O'Neal", "Giannis Antetokounmpo", "Luka Doncic"}; //85


        Lotr = new string[] { "Thorin Oakenshield","Thingol","Olwe","Fingolfin","Finwe","The Great River","The Fellowship of the Ring",
                              "The Return of the King","The Two Towers","Smaug", "Mumakil", "Giant Eagles", "The Balrog", "Giant Spiders",
                              "Cave Troll", "Warg", "Anduril", "Glamdring", "Bow of Galadhrim", "Witch King's Mace", "Sting", "Fellbeasts",
                              "Orcrist", "Grond", "Black Arrow", "Elves", "Morgul", "Dwarves", "Hobbits", "Lorinand","Khazad-dum",  "Shadowfax",
                              "Lindon","Eriador","Rhovanion","Rhun","Gondor","Mordor","Treebeard", "Pippin Took", "Théoden","One Ring",
                              "Shelob", "Sauron", "Saruman", "Radagast", "Nazgul", "Legolas", "Khamul", "Isildur", "Grima Wormtongue",
                              "Gollum", "Goldberry", "Glorfindel", "Gimli", "Gandalf", "Samwise Gamgee", "Galadriel", "Eowyn","Middle-Earth",
                              "Eothain", "Eomund", "Eomer", "Elrond", "Elendil", "Denethor", "Deagol", "Celeborn", "Bregalad",
                              "Merry Brandybuck", "Boromir", "Tom Bombadil", "Beechbone", "Frodo Baggins", "Bilbo Baggins", "Arwen", "Aragorn"}; //77


        Marvel = new string[] {"Kingpin","Rhino","Mysterio","Dr. Curtis (Lizard)","Sandman","Doctor Octopus","Harry Osborn",
                               "Green Goblin","May Parker","Betty Ross","General Thunderbolt Ross","Nick Fury","Agent Phil Coulson ",
                               "War Machine","Pepper Potts","J.A.R.V.I.S","Star Lord","Destroyer Drax","Mantis","Nebula",
                               "Grandmaster","Surtur","Heimdall","Hela","Odin","Gorr the God Butcher","Jane Foster","Valkyrie",
                               "Abomination","Luke Cage","Adam Warlock","Elektra","Blade","Hellstorm","Hank Pym","Bucky Barnes",
                               "Jack Monroe","Emma Frost","Cyclops","Black Cat","Nocturne","Quasar","Moon Knight","Howard Stark",
                               "Black Bolt","Moondragon","Stingray","Rocket Raccoon","Thing","Scarlet Witch","Captain America",
                               "Watcher","Cypher","Doctor Voodoo","Captain Marvel","Beta Ray Bill","Foggy Nelson","Harry Osborn",
                               "Falcon","Invisible Woman","Gwen Stacy","Hyperion","Jim Hammond","Cassie Lang","Morph","Vision",
                               "Quicksilver","Warpath","Iron Man", "Spiderman", "Wolverine","Hulk", "Black Widow", "Thor",
                               "Doctor Strange", "Thanos" , "Hawkeye", "Loki","Groot", "Ultron"}; //80


        Geography = new string[] { "Mount Rushmore","Yellowstone National Park","Hollywood Sign","The Washington Monument","The Empire State Building",
                                   "Liberty Bell","Yosemite National Park","White House","Road to Hana","Disney World","The Grand Canyon","Times Square",
                                   "Pena Palace","Tower of Pisa","Buckingham Palace","Big Ben","Louvre Museum,","Notre-Dame Cathedral","Kilimanjaro",
                                   "Wonders of the Nile","Sphinx","Sahara Dunes","Victoria Falls","Table Mountain","Trier Cathedral","Sumela Monastery",
                                   "The Blue Mosque","Mount Nemrut","Topkapi Palace","Ephesus Ancient City",
                                   "Cappadocia Fairy Chimneys","Ephesus","Hagia Sophia","Central Park","Chateau de Versailles", "Church of St. Peter",
                                   "Corcovado and Cristo Redentor","Chichen Itza","Prague Castle","Forbidden City","The Louvre", "St. Peter’s Basilica",
                                   "Mount Kilimanjaro","Sydney Opera House","Bagan","Niagara Falls","Borobudur", "Stonehenge", "Church of Our Lady Mary of Zion",
                                    "Grand Canyon", "Petra", "Angkor Wat", "Great Wall of China", "San Miguel Chapel","Mount Fuji", "Christ The Redeemer",
                                   "Pyramids of Giza", "The Taj Mahal", "The Acropolis", "Machu Picchu", "The Statue of Liberty", "The Pantheon",
                                   "Eiffel Tower", "Taj Mahal", "The Colosseum", "Sydney Opera House", "Golden Gate Bridge","The great migration" }; //68


        Professions = new string[] {"Coach","Editor","Bus Driver","Mathematician","Massage Therapist","Marketing Manager","Moneylender",
                                    "Speech-Language Pathologist","Radiologic Technologist","College Professor","Anthropologist",
                                    "Farmer","Secretary","Executive Assistant","Dancer","Mechanical Engineer","Patrol Officer","Veterinary",
                                    "Drafter","Physician","Paramedic","Microbiologist","Carpenter","Web Developer", "Architect","Mason",
                                    "Middle School Teacher","Chef","Civil Engineer","Photographer","Locksmith","Gardener","Radio Presenter",
                                    "Lap Dancer","Gas Fitter","Historian","Bailiff","Auctioneer","Teaching Assistant","Careers Advisor",
                                    "Fork-lift Driver","Economist","Police", "Game Developer", "Fire Fighter","Plumber","Publisher",
                                    "Waiter", "Soldier", "Gardener", "President" , "Nurse", "Engineer","Police Officer","Tailor",
                                    "Biographer", "Artist","Optician","Interpreter","Computer Analyst","Astronomer","Footballer"}; //62


        Football = new string[] { "Neymar","Vinicius Junior","Rodrygo","Samuel Eto","Mesut Ozil","Darwin Nunez","Mohamed Salah",
                                  "Kylian Mbappe","Kyle Walker","Edin Dzeko","Iker Casillas","Pele","Gianluigi Buffon","Ronaldinho","Sergio Busquets",
                                  "Ruud van Nistelrooy","Alfredo Di Stefano","Ivan Perisic","Luis Suarez","Edinson Cavani","Phil Foden",
                                  "Jack Grealish","Radamel Falcao","Timo Werner","Eden Hazard","Figo","Andres Iniesta","Erling Haaland",
                                  "Fatih Terim","Zico","Jordan Pickford","Roberto Firmino","Mats Hummels","Roy Keane","Fabinho","Thomas Lemar",
                                  "Manuel Neuer","Axel Witsel","Ousmane Dembele","Nemanja Matic","Leonardo Bonucci","Dani Alves","Isco","Koke",
                                  "Marco Verratti","Romario","Fernando Torres","Zinedine Zidane","Jorginho","Thiago Silva", "Thierry Henry",
                                  "John Stones", "Nabil Fekir", "Jordi Alba", "Rivaldo", "Alexis Sanchez","Thibaut Courtois","Alex de Souza",
                                  "Sadio Mane", "Lucas Hernandez", "Sergio Ramos", "Kalidou Koulibaly", "Benjamin Pavard","Paolo Maldini",
                                  "Benjamin Mendy", "Hugo Lloris", "Leroy Sane", "Paul Pogba", "Frenkie de Jong", "Marc-Andre ter Stegen",
                                  "Ferenc Puskas", "Xavi", "Raul", "Sergio Agüero", "Virgil van Dijk", "Ciro Immobile","Son Heung-min",
                                  "Paul Scholes", "Marcus Rashford", "Marco Reus", "David de Gea", "Michele Platini", "Willian","Cristano Ronaldo",
                                  "Dries Mertens", "Diego Maradona", "Keylor Navas", "David Luiz", "Xabi Alonso", "Bebeto", "Radja Nainggolan",
                                  "Alisson", "Antoine Griezmann", "Diego Costa", "Kevin De Bruyne", "Paulo Dybala", "Naby Keita", "Romelu Lukaku",
                                  "Thiago Alcantara", "Adrien Rabiot", "Samuel Umtiti", "Bernardo Silva", "Lucas Torreira", "Toni Kroos", "Jan Oblak",
                                  "Claude Makelele", "Roberto Carlos", "Benjamin Pavard", "Willian", "Rogerio Ceni", "James Rodríguez", "Gabriel Jesus",
                                  "Johann Cruyff", "Edgar Davids", "Zlatan Ibrahimovic", "Gerd Müller", "Jose Maria Gimenez", "Olivier Giroud",
                                  "Gonzalo Martínez", "Marcos Alonso", "Gonzalo Higuain", "Angel Di Maria", "Raphael Varane", "Ivan Rakitic",
                                  "Karim Benzema", "Lorenzo Insigne", "Marco Asensio", "Jairzinho", "Gareth Bale", "Edinson Cavani", "Ederson", "Lionel Messi"}; //132


        Furniture = new string[] { "Weighing", "Mirror", "Flowerpot","Vase", "Lamp", "Hot Water Bag",
                             "Laundry Basket", "Toothbrush Holder", "Soap Dish", "Mop", "Pouch","Bed", "Chair",
                             "Towels", "Tablecloth", "Pillow", "Pique", "Duvet", "Blanket", "Bedding Sets",
                             "Curtain","Tray", "Trivet","Ladle", "Spatula", "Storage Containers",
                             "Pasta Strainer","Grater", "Bread Board", "Trash", "Sugar Bowl", "Knife",
                             "Spoon ", "Fork ", "Pans", "Pots", "Blender", "Kettle", "Toast Machine",
                             "Hair Dryer", "Iron","Vacuum Cleaner", "Laptop", "Air Conditioning",
                             "Paddle Box", "Microwave Oven", "Furnace","Dishwasher", "Washing Machine",
                             "Refrigerator", "Cloakroom", "Kitchen Table","Bookshelf", "Television","Coffee table"}; //55


        Famous = new string[] { "Alec Baldwin","Chris Hemsworth","Hugh Jackman","Billie Eilish","Steve Jobs","Selena Gomez","Taylor Swift","Bill Gates",
                                "Eddie Murphy","Madonna","Ariana Grande","Natalie Portman","Denzel Washington","Jennifer Aniston","Scarlett Johansson",
                                "Morgan Freeman","John Lennon","Steven Spielberg","Kanye West","Adriana Lima","Eva Longoria","Meryl Streep","Justin Bieber",
                                "Daniel Radcliffe","Ben Stiller","Drew Barrymore","Audrey Hepburn","The Rock","Elvis Presley","Tiger Woods","Julia Roberts",
                                "Miley Cyrus","Roger Feederer","Rafael Nadal","Elton John","Tom Hanks","Chris Rock","Cameron Diaz","Lil Wayne",
                                "Leonardo DiCaprio","Jay-Z","Johnny Depp","Freddie Mercury","Steve Carell","Mark Wahlberg","Lebron James","Cristiano Ronaldo",
                                "Lionel Messi","Venus Williams","William Shakespeare","Jim Carrey","Bruce Lee","Mustafa Kemal Atatürk","Nikola Tesla","Anne Hathaway",
                                "Eminem","Heidi Klum","Adam Sandler","Muhammad Ali","Pablo Picasso","Usain Bolt","Ryan Reynolds","Brad Pitt", "Lana Del Rey",
                                "Tarkan","Beyonce", "Shakira", "Michael Jackson", "Snoop Dogg", "Eminem" , "50 Cent", "Nicki Minaj","Robert Downey Jr.", "Robert De Niro"}; //74


        Countries = new string[] { "Andorra","Romania","Monaco","United Kingdom","Palestine","Sudan","Zimbabwe","Gabon","Peru","Ecuador",
                                   "Bolivia","Morocco ","U.S.A","Canada","Venezuela","Mexico","Costa Rica","Honduras","Haiti","Jamaica",
                                   "North Korea","South Korea","China","Syria","Saudi Arabia","Kyrgyzstan","Taiwan","Malaysia","Philippines",
                                   "Thailand","Indonesia","Denmark","Andorra","Czech Republic","France","Italy","Slovakia","Bulgaria",
                                   "Netherlands","Switzerland","Belgium","Greece","Ukraine","Spain","Cyprus","Croatia","Norway","Finland",
                                   "Portugal","Estonia","Ireland","Serbia","Armenia","Russia","Turkey", "America", "Japanese","Germany",
                                   "Holland", "Cameron", "South Africa", "Brazil" , "Argentina", "Albenia", "Poland", "Sweden"}; //66


        Cartoon = new string[] { "Duck Dodgers","Star vs. the Forces of Evil","Dexter's Laboratory","Johnny Bravo","Grim & Evil","Family Guy", "Ben 10",
                                 "South Park","American Dad","Miraculous Tales of Ladybug and Cat Noir","Invincible","Rick and Morty","Final Space",
                                 "Castlevania","The Simpsons","Futurama","Danny Phantom","Codename Kids Next Door","Kim Possible","Gravity Falls","The Regular Show",
                                 "Voltron","Avatar The Legend of Korra","Generator Rex","Teenage Mutant Ninja Turtles","Avatar The Last Airbender","Adevnture Time",
                                 "Batman Animated Series","DC Super Hero Girls","Justice League","Victor and Valentino","We Bare Bears","Steven Universe",
                                 "The Secret Saturdays","Foster's Home for Imaginary Friends","Megas XLR","Star Wars: Clone Wars","Courage the Cowardly Dog",
                                 "Ed, Edd n Eddy","Total Drama Island","The Amazing World of Gumball","Teen Titans Go","Tom and Jerry", "Scooby-Doo",
                                 "SpongeBob SquarePants","Beavis and Butt-head", "South Park", "Samurai Jack", "The Flintstones", "The Simpsons" , "The Powerpuff Girls"}; //51


        Winter = new string[] {"Fire Pit","Tire Chain","Penguin","Antarctica","Antibiotic","Apical Pneumonia",
                               "Moisturising Cream","Flu","Dry Skin","Vitamin","Hypothermia","December","January",
                               "February","Long Ear","Elves","Reindeer","Santa Claus","Snow Fairy","Feel Cold",
                               "Pomegranate","Noel","New Year","Hockey","Soup","Snowflake","Snowboarding","Hot Chocolate",
                               "Winter Olympics","Hibernation","Ice Skating","White","Short Days","Bobsledding","Beanie",
                               "Chimney","Winter Wonderland","Frost","Glvove", "Snowman", "Shovel","Cold", "Boot",
                               "Scarf", "Coat" , "Heater", "Storm","Hot Coffee", "Fireplace","Snowball Fight"};  //50
    }

    private void Start()
    {
       

        if (PlayerPrefs.HasKey("GameTime")){} // Oynanýþ süresinin seçeneðini tutuyor.
        else{ PlayerPrefs.SetInt("GameTime",1);}

        if (PlayerPrefs.HasKey("GameSound")) { } // Oyun sesi Açýk/kapalý.
        else { PlayerPrefs.SetInt("GameSound", 1); }


        if (PlayerPrefs.HasKey("GameSoundEffect")) { } // Ses efektleri açýk/kapalý
        else { PlayerPrefs.SetInt("GameSoundEffect", 1); }


        if (PlayerPrefs.HasKey("GameScore")) { } // Doðru skor sayýsýný tutuyor.
        else { PlayerPrefs.SetInt("GameScore", 0); }

        if (PlayerPrefs.HasKey("CategoriesSelection")) { } // Belirli kategoriyi tutuyor.
        else { PlayerPrefs.SetInt("CategoriesSelection", 0); }

        if (PlayerPrefs.HasKey("interstitialsControl")) { } // Interstitials reklamýnýn kontrol deðeri.
        else { PlayerPrefs.SetInt("interstitialsControl", 0); }
        if (PlayerPrefs.HasKey("Initialize")) { } // Interstitials reklamýnýn kontrol deðeri.
        else { PlayerPrefs.SetInt("Initialize", 0); }

    }
    
}
