using AbstractionDemo.Models;

namespace AbstractionDemo;

public class UserCollection : AbstractCollectionManager<User>
{    
    // Because the method of the abstract class being extended is abstract,
    // the <c>override</c> keyword allows this derived class to implement it.
    public override void InstantiateClient() => Console.WriteLine("Instiatiating MongoClient somehow...");

    public override string CollectionName() => "users";
}
