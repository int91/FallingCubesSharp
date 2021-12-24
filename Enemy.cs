using System;
using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace TextBasedDemo
{
    class Enemy : Entity
    {
        float moveSpeed;
        public Enemy(Position pos, Color color) : base(pos, color)
        {
            moveSpeed = 220.0f;
        }

        public override void update(float deltaTime)
        {
            pos.setPosition(pos.getX(), pos.getY()+moveSpeed*deltaTime);
        }
    }
}