using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace DocumentFlow.Data
{
    public class MongoExamples
    {
        private const string ConnectStringLocal = "mongodb://localhost:27017";
        private const string ConnectStringAtlas = "mongodb+srv://AntonPr:<password>@cluster0.o9nqv6x.mongodb.net";
        private static string ConnectString = ConnectStringLocal;

        public static User Find(string login) // Returns a document
        {
            var client = new MongoClient(ConnectString);
            var database = client.GetDatabase("DBUser");
            var collection = database.GetCollection<User>("User");
            var document = collection.Find(x => x.Login == login).FirstOrDefault();
            return document;
        }

        public static void SaveValues(string login, User user) // Replaces the document
        {
            var client = new MongoClient(ConnectString);
            var database = client.GetDatabase("DBUser");
            var collection = database.GetCollection<User>("User");
            collection.ReplaceOne(x => x.Login == login, user);
        }

        public static void AddToDB(User user)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("DBUser");
            var collection = database.GetCollection<User>("User");
            collection.InsertOne(user);
        }

        public static void ReplaceByName(string login, User user)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("DBUser");
            var collection = database.GetCollection<User>("User");
            collection.ReplaceOne(x => x.Login == login, user);
        }
    }
}   