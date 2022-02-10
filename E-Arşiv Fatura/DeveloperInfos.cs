using System;

namespace E_Arşiv_Fatura
{
    class DeveloperInfos
    {
        private static string name = "Mehmet";
        private static string lastName = "Sezer";
        private static string fullName = name + lastName;
        private static int age = DateTime.Now.Year - 2003;
        private static string instagramAddress = "https://www.instagram.com/mehmett_ssezer/";
        private static string gitHubAddress = "https://github.com/KeyBoarT";

        public static string Name
        {
            get { return name; }
        }

        public static string LastName
        {
            get { return lastName; }
        }

        public static string FullName
        {
            get { return fullName; }
        }

        public static int Age
        {
            get { return age; }
        }

        public static string InstagramAddress
        {
            get { return instagramAddress; }
        }

        public static string GitHubAddress
        {
            get { return gitHubAddress; }
        }
    }
}
