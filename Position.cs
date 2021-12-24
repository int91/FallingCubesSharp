using System;

namespace TextBasedDemo
{
    class Position
    {
        float x;
        float y;
        public Position(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public void setPosition(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public float getX()
        {
            return this.x;
        }

        public float getY()
        {
            return this.y;
        }
    }
}