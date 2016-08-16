using System.Collections.Generic;
using System.Linq;

namespace MutationTesting
{
    public class Sequence
    {
        private readonly IEnumerable<object> values;

        public Sequence(IEnumerable<object> values)
        {
            this.values = values;
        }

        public bool HaveSingleItem()
        {
            if (this.values.Any() && this.values.Count() < 2)
                return true;
            return false;
        }
    }
}