using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NClass.Document
{
    public class ClassEntity : Entity
    {
        public bool IsReadOnly
        {
            get => default(bool);
            set
            {
            }
        }

        public bool IsNonInheritable
        {
            get => default(bool);
            set
            {
            }
        }

        public bool IsSingleton
        {
            get => default(bool);
            set
            {
            }
        }
    }
}