using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen1.Classes
{
    internal class Bot : Block
    {
        public Bot() : base()
        {
            _entity = Entity.Bot;
            _canMoveIn = false;
        }

        public Bot(Point position) : base(position, Color.Blue)
        {
            _entity = Entity.Bot;
            _canMoveIn = false;
        }

        public Bot(Point position, int[] brain) : base(position, Color.Blue)
        {
            _entity = Entity.Bot;
            _canMoveIn = false;

            Array.Copy(brain, Brain, 64);
        }

        public Bot(Point position, int[] brain, Color color) : base(position, color)
        {
            _entity = Entity.Bot;
            _canMoveIn = false;

            Array.Copy(brain, Brain, 64);
        }

        public void SetPosition(Point point) 
        {
            _position = point;
        }

        public void Turn(Side side) 
        {
            Side = (Side)(((int)Side + (int)side) % 8);
        }

        public int HP = 40;

        public int[] Brain = new int[64];

        public int Index = 0;

        public Side Side = Side.Top;

        public int Energy = 0;
    }
}
