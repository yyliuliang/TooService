using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TooService.Entities
{
    public interface IEntity
    {
        [BsonId]
        string Id { get; set; }
        

        DateTime UpdatedOn { get;  }

        DateTime CreatedOn { get; }

        [BsonIgnore]
        ObjectId ObjectId { get;  }
    }
}
