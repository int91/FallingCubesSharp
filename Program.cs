using System;
using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;
using static Raylib_cs.KeyboardKey;
using static Raylib_cs.Color;

namespace TextBasedDemo
{
    class Program
    {
        //TODO: Randomize enemy spawn positions
        static void Main(string[] args)
        {
            InitWindow(800, 480, "Falling Cubes - Raylib Sharp Edition");
            SetTargetFPS(60);
            MainGameScene mgs = new MainGameScene();
            mgs.init();
            float deltaTime = GetFrameTime();
            
            while (mgs.isRunning)
            {
                deltaTime = GetFrameTime();
                mgs.update(deltaTime);
                BeginDrawing();
                ClearBackground(BLACK);
                mgs.draw();
                EndDrawing();
            }

            CloseWindow();
        }
    }
}
