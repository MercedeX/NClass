using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NClass.Document
{
    public class ClassModel : IClassModel
    {
        string _title;

        List<IEntity> _entities = new List<IEntity>();
        List<IRelation> _relations = new List<IRelation>();


        IDictionary<int, MapType> _id2Map = new Dictionary<int, MapType>();
        public string Name { get => _title; set => _title = value; }

        public IList<IEntity> Entities => _entities;
        public IList<IRelation> Relations => _relations;

        public ClassModel()
        {
          
        }

        public void Add(IEntity entity)
        {
            _entities.Add(entity);

        }
        public void Add(IRelation relation)
        {
            _relations.Add(relation);
        }

    }
}
