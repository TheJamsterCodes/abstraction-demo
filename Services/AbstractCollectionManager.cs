namespace AbstractionDemo;

/// <summary>
/// Provides default, generic functionality for derived classes to implement on their own.
/// This abstract class can also provide implementation for derived classes to use.
/// Cannot be instantiated, so don't even try big boi.
/// </summary>
/// <typeparam name="D"></typeparam>
public abstract class AbstractCollectionManager<D> where D : class
{    
    public abstract string CollectionName();

    public abstract void InstantiateClient();

    // Derived class that extends this class can invoke and use the implementation.
    public void InsertDocument(D document)
    {        
        Console.WriteLine($"Inserting 1 {GetDocumentName(document)} document into {this.CollectionName()} collection.");
    } 

    // Derived class that extends this class can invoke and use the implementation.
    public void RemoveDocument(D document)
    {
        Console.WriteLine($"Removing 1 {GetDocumentName(document)} document from {this.CollectionName()} collection");

    }

    private static string GetDocumentName(D document) => document.GetType().Name;
}
