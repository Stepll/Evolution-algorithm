using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen1.Classes
{
    abstract class Block
    {
        public Block()
        {
            _position = new Point(10, 10);
        }

        public Block(Point point, Color? color = null)
        {
            _position = point;

            _color = color ?? Color.Black;
        }

        public void DrawBlock(PaintEventArgs e)
        {
            SolidBrush brush = new SolidBrush(_color);

            Point drowPos = this._position.ToSizeCoordinate(_size);

            Rectangle rect = new Rectangle(drowPos.X, drowPos.Y + _marginTop, _size, _size);

            e.Graphics.FillRectangle(brush, rect);
        }


        public Point GetPosition()
        {
            return _position;
        }

        public Entity GetEntity() 
        {
            return _entity;
        }

        public bool CanMove() 
        {
            return _canMoveIn;
        }

        protected bool _canMoveIn = true;

        protected Entity _entity = Entity.Air;

        protected Point _position;

        protected int _size = 8;

        protected int _marginTop = 30;

        protected Color _color = Color.Black;
    }
}
