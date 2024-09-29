using System.Text;
using System;

namespace DataTierWebServer.Models
{
    public class Generator
    {
        private static readonly Random _random = new Random();
        private static HashSet<string> generatedStrings = new HashSet<string>();

        // Lists of actual names
        private readonly List<string> _firstNames = new List<string>
        {
            "James", "Mary", "John", "Patricia", "Robert", "Jennifer", "Michael", "Linda",
            "William", "Elizabeth", "David", "Barbara", "Richard", "Susan", "Joseph", "Jessica",
            "Thomas", "Sarah", "Charles", "Karen", "Christopher", "Nancy", "Daniel", "Lisa",
            "Matthew", "Margaret", "Anthony", "Betty", "Donald", "Sandra", "Mark", "Ashley",
            "Paul", "Dorothy", "Steven", "Kimberly", "Andrew", "Emily", "Kenneth", "Donna",
            "Joshua", "Michelle", "Kevin", "Carol", "Brian", "Amanda", "George", "Melissa",
            "Edward", "Deborah", "Ronald", "Stephanie", "Timothy", "Rebecca", "Jason", "Laura",
            "Jeffrey", "Sharon", "Ryan", "Cynthia", "Jacob", "Kathleen", "Gary", "Amy",
            "Nicholas", "Shirley", "Eric", "Angela", "Stephen", "Helen", "Jonathan", "Anna",
            "Larry", "Brenda", "Justin", "Pamela", "Scott", "Nicole", "Brandon", "Emma",
            "Benjamin", "Samantha", "Samuel", "Katherine", "Frank", "Christine", "Gregory", "Debra",
            "Raymond", "Rachel", "Alexander", "Catherine", "Patrick", "Carolyn", "Jack", "Janet",
            "Dennis", "Ruth", "Jerry", "Maria"
        };


        private readonly List<string> _lastNames = new List<string>
        {
            "Smith", "Johnson", "Williams", "Brown", "Jones", "Garcia", "Miller", "Davis",
            "Rodriguez", "Martinez", "Hernandez", "Lopez", "Gonzalez", "Wilson", "Anderson", "Thomas",
            "Taylor", "Moore", "Jackson", "Martin", "Lee", "Perez", "Thompson", "White",
            "Harris", "Sanchez", "Clark", "Ramirez", "Lewis", "Robinson", "Walker", "Young",
            "Allen", "King", "Wright", "Scott", "Torres", "Nguyen", "Hill", "Flores",
            "Green", "Adams", "Nelson", "Baker", "Hall", "Rivera", "Campbell", "Mitchell",
            "Carter", "Roberts", "Gomez", "Phillips", "Evans", "Turner", "Diaz", "Parker",
            "Cruz", "Edwards", "Collins", "Reyes", "Stewart", "Morris", "Morales", "Murphy",
            "Cook", "Rogers", "Gutierrez", "Ortiz", "Morgan", "Cooper", "Peterson", "Bailey",
            "Reed", "Kelly", "Howard", "Ramos", "Kim", "Cox", "Ward", "Richardson",
            "Watson", "Brooks", "Chavez", "Wood", "James", "Bennett", "Gray", "Mendoza",
            "Ruiz", "Hughes", "Price", "Alvarez", "Castillo", "Sanders", "Patel", "Myers",
            "Long", "Ross", "Foster", "Jimenez"
        };

        private string GetFirstname()
        {
            return _firstNames[_random.Next(_firstNames.Count)];
        }

        public static string GetPassword(int length)
        {
            string randomString;
            
            do
            {
                randomString = GenerateRandomString(length);
            } while (!generatedStrings.Add(randomString));

            return randomString;
        }

        private static string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder result = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                result.Append(chars[_random.Next(chars.Length)]);
            }
            return result.ToString();
        }

        private string GetLastname()
        {
            return _lastNames[_random.Next(_lastNames.Count)];
        }

        private string GetEmail(string firstName, string lastName)
        {
            return firstName + "." + lastName + "@gmail.com";
        }

        private uint GetAge()
        {
            return (uint)_random.Next(18, 110);
        }

        private int GetBalance()
        {
            return _random.Next(1, 10000000);
        }
        
        private int GetPhoneNum()
        {
            return _random.Next(1000000, 10000000);
        }

        private string GetAddress() 
        {
            int houseNumber = _random.Next(1, 1000);
            string street = _firstNames[_random.Next(_firstNames.Count)] + " " + _lastNames[_random.Next(_lastNames.Count)] + " St.";

            return houseNumber + " " + street;
        }

        public void GetNextAccount(out string password, out string firstName, out string lastName, out string email,
            out uint phoneNumber, out string address)
        {
            password = GetPassword(20);
            firstName = GetFirstname();
            lastName = GetLastname();
            email = GetEmail(firstName, lastName);
            phoneNumber = (uint)GetPhoneNum();
            address = GetAddress();

        }

        public int NumOfUserProfiles()
        {
            return _random.Next(10, 100);
        }
    }
}
