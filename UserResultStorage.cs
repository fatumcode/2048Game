using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048WinFormsApp
{
    public class UsersResultStorage
    {
        public static string Path = "UserResults.json";
        public static void Append(User user)
        {
            var usersResults = GetAll();
            usersResults.Add(user);
            Save(usersResults);
        }

        public static List<User> GetAll()
        {
            if (!FileProvider.Exist(Path))
            {
                return new List<User>();
            }
            var fileData = FileProvider.Get(Path);
            var userResults = JsonConvert.DeserializeObject<List<User>>(fileData);
            return userResults;

        }
        public static void Save(List<User> userResults)
        {
            var jsonData = JsonConvert.SerializeObject(userResults, Formatting.Indented);
            FileProvider.Replace(Path, jsonData);

        }

        public static int BestResult()
        {
            var bestResult = 0;
            var allResults = GetAll();
            foreach(var result in allResults)
            {
                if (result.Result > bestResult)
                {
                    bestResult = result.Result;
                }
            }
            return bestResult;
        }
    }
}
