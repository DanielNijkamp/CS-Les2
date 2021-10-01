using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            Rectangle Cube = new Rectangle(20, 0, 0);
            Rectangle Cube2 = new Rectangle(100, 100);
            
        }

        
    }
    class Rectangle
    {
        private float x, y, width, height;



        public Rectangle(float size, float x, float y)
        {
            this.x = x;
            this.y = y;

            this.width = size;
            this.height = size;
        }
        public Rectangle(float width, float height)
        {
            this.width = width;
            this.height = height;
        }
        public Rectangle(float x, float y, float width, float height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

    }
    }
