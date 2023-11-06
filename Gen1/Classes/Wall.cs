using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen1.Classes
{
    internal class Wall : Block
    {
        public Wall() : base() 
        {
            _entity = Entity.Wall;
            _canMoveIn = false;
        }

        public Wall(Point position) : base(position, Color.Black) 
        {
            _entity = Entity.Wall;
            _canMoveIn = false;
        }
    }
}
