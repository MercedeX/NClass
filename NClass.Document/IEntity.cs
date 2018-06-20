using System.Collections.Generic;

namespace NClass.Document
{
    public interface IEntity
    {
        int Id { get; }
        string Title { get; set; }
        bool IsDead { get; }
        IList<IEntityMember> Members { get;  }
        IList<IEntity> Inherits { get;  }
    }
}