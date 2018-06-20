using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NClass.Document
{
    public interface IEntityMember
    {
        int Id { get;  }
        string Title { get; set; }
        int TypeId { get; set; }
    }
}