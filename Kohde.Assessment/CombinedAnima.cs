using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kohde.Assessment
{
    public abstract class CombinedAnima : ICombinedAnima
    {
        public int Age { get; set; }

        public string Name { get; set; }

        public abstract override string ToString();

        public abstract string GetDetails();
    }
}
