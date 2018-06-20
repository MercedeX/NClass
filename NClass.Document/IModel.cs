using System.Collections.Generic;

namespace NClass.Document
{
    public interface IClassModel
    {
        string Name { get; set; }

        IList<IEntity> Entities { get; }
        IList<IRelation> Relations { get;  }
    }
}