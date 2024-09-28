namespace DataTierWebServer.Models
{
    public class Generator
    {
        private readonly Random _random = new Random();

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

        private string GetAddress() 
        {
            int houseNumber = _random.Next(1, 1000);
            string street = _firstNames[_random.Next(_firstNames.Count)] + " " + _lastNames[_random.Next(_lastNames.Count)] + " St.";

            return houseNumber + " " + street;
        }

        public void GetNextAccount(out uint acctNo, out string firstName, out string lastName, out int balance)
        {
            acctNo = GetAge();
            firstName = GetFirstname();
            lastName = GetLastname();
            balance = GetBalance();
        }

        public int NumOfAccounts()
        {
            return _random.Next(10, 100);
        }
    }
}
