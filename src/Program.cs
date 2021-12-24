using System;
using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;
using static Raylib_cs.KeyboardKey;
using static Raylib_cs.Color;

//NOTE: This project was made before I found out about the more recent Raylib_CsLo library which is way better than this one.
//The Raylib "RayGui" library didn't work in this one, hence why I made my own Button class to handle exiting the game after
//you die.

namespace TextBasedDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            InitWindow(800, 480, "Falling Cubes - Raylib Sharp Edition");
            SetTargetFPS(60);
            MainGameScene mgs = new MainGameScene();
            mgs.init();
            float deltaTime = GetFrameTime();
            
            while (mgs.isRunning && !WindowShouldClose())
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
