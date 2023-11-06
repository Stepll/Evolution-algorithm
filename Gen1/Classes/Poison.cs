using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen1.Classes
{
    internal class Poison : Block
    {
        public Poison() : base()
        {
            _entity = Entity.Poison;
        }

        public Poison(Point position) : base(position, Color.Red)
        {
            _entity = Entity.Poison;
        }
    }
}
