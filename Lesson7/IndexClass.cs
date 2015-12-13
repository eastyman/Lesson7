using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
   class Index
   {
       public string Name { get; set; }
       public Index(string name)
       {
           Name = name;
       }

}
    class IndexClass
    {
        private Index[] indexes;
        public IndexClass(int length)
        {
            indexes = new Index[length];
        }
       public int Length
       {
          get { return indexes.Length; }
       }
        public Index this[int index]
        {
            get
            {
                return indexes[index];
            }
            set
            {
                indexes[index] = value;

            } 
        }
    }
    
}
