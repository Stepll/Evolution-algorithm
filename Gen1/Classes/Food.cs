using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen1.Classes
{
    internal class Food : Block
    {
        public Food() : base()
        {
            _entity = Entity.Food;
        }

        public Food(Point position) : base(position, Color.Green)
        {
            _entity = Entity.Food;
        }
    }
}
