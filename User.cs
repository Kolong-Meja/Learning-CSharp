using Newtonsoft.Json;

namespace JsonConverter
{
    class User
    {
        // USER CLASS PROPERTIES
        public string? UUID;
        public string? FullName;
        public string? Email;
        public int? Age;

        [JsonConstructor]
        public User(string UserUUID, string UserFullName, string UserEmail, int UserAge)
        {
            UUID = UserUUID;
            FullName = UserFullName;
            Email = UserEmail;
            Age = UserAge;
        }

        public static void UserProfile()
        {
            User user = new User(
                "b25831ff-77fb-4ccc-80a4-e5b20c383a40",
                "Faisal Ramadhan",
                "faisalrmdhn08@gmail.com",
                21
            );
            var jsonOutput = JsonConvert.SerializeObject(user);
            Console.WriteLine(jsonOutput);
        }
    }
}