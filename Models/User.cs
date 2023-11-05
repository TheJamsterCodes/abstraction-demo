using MongoDB.Bson;

namespace AbstractionDemo.Models;

public class User : BaseModel
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Username { get; set; }
}