using System;
using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;
using static Raylib_cs.KeyboardKey;
using static Raylib_cs.Color;


namespace TextBasedDemo
{
    class Player : Entity
    {
        float moveSpeed;
        public int lives = 3;
        public Player(Position pos, Color color) : base(pos, color)
        {
            moveSpeed = 400.0f;
        }

        public override void update(float deltaTime)
        {
            if (IsKeyDown(KEY_D))
            {
                pos.setPosition(pos.getX()+moveSpeed*deltaTime, pos.getY());
            } else if (IsKeyDown(KEY_A))
            {
                pos.setPosition(pos.getX()-moveSpeed*deltaTime, pos.getY());
            }
        }
    }
}