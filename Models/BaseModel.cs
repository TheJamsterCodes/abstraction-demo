using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AbstractionDemo.Models;

/// <summary>
/// Cannot be instantiated.
/// </summary>
public abstract class BaseModel
{
    [BsonId]
    public ObjectId ObjectId { get; set; }

    public string CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public string UpdatedBy { get; set; }
    public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;
}