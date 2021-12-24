using System;
using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace TextBasedDemo
{
    class Entity
    {
        public Position pos;
        Color color;
        public Entity(Position pos, Color color)
        {
            this.pos = pos;
            this.color = color;
        }

        public virtual void update(float deltaTime)
        {

        }

        public virtual void draw()
        {
            DrawRectangle(((int)this.pos.getX()), ((int)this.pos.getY()), 32, 32, this.color);
        }
    }
}