using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            Rectangle rectanglemove = new Rectangle(50);
            Rectangle squaremove = new Rectangle(20, 30);
            Rectangle rectangle = new Rectangle(100, 100, 50, 50);
            Rectangle square = new Rectangle(50, 50, 50);
            

            rectanglemove.MoveTo(50, 50);
            squaremove.Set(100, 100, rechthoek.GetWidth(), rechthoek.GetHeight());

        }
        class Rectangle
        {
            private float x, y, width, height;

            public void MoveTo(float x, float y)
            {
                x = this.x;
                y = this.y;
            }
            public bool isSquare()
            {
                if (this.height == this.width)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            public void Set(float x, float y, float width, float height)
            {
                this.x = x;
                this.y = y;
                this.width = width;
                this.height = height;
            }

            public float GetWidth()
            {
                return this.width;
            }

            public float GetHeight()
            {
                return this.height;
            }

            public Rectangle(float x, float y, float height, float width)
            {
                this.x = x;
                this.y = y;
                this.height = height;
                this.width = width;
            }

            public Rectangle(float x, float y, float size)
            {
                this.x = x;
                this.y = y;
                this.height = size;
                this.width = size;
            }

            public Rectangle(float width, float height)
            {
                this.width = width;
                this.height = height;
            }

            public Rectangle(float size)
            {
                this.width = size;
                this.height = size;
            }

        }
    }
}
