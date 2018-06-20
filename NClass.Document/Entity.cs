using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NClass.Document
{
    public class Entity : IEntity
    {
        List<IEntityMember> _members;
        List<IEntity> _parents;

        public virtual int Id { get; }
        public virtual string Title { get; set; }
        public virtual bool IsDead { get;  }
        public virtual IList<IEntityMember> Members => _members;
        public virtual IList<IEntity> Inherits => _parents;  
    }
}
