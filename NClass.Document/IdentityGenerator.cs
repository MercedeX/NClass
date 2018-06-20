using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NClass.Document
{
    public class IdentityGenerator : IIdentityGenerator
    {
        SortedSet<int> _ids = new SortedSet<int>();

        int _current = 1;

        public int NewId {
            get{
               Register(_current);
                return _ids.Last();
                
            }
        }

        public void Register(int id)
        {
            if (!_ids.Contains(id))
            {
                _ids.Add(id);
                _current = _ids.Last()+1;
            }
        }
    }
}
