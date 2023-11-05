using AbstractionDemo;
using AbstractionDemo.Models;

var user = new User 
{
    ObjectId = new MongoDB.Bson.ObjectId(),
    Firstname = "James",
    Lastname = "Alanis",
    Username = "elJamster"
};

var userCollection = new UserCollection();

userCollection.InstantiateClient();
userCollection.InsertDocument(user);
userCollection.RemoveDocument(user);


