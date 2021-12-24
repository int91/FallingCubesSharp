using System;
using System.Collections.Generic;
using Raylib_cs;
using static Raylib_cs.Raylib;
using static Raylib_cs.KeyboardKey;
using static Raylib_cs.Color;
using static Raylib_cs.MouseButton;

namespace TextBasedDemo
{
    class Button
    {
        private Rectangle rect;
        private Color color;
        private bool isHovering = false;
        public bool isClicked = false;
        public Button(int x, int y, int width, int height)
        {
            this.rect = new Rectangle(x, y, width, height);
        }

        public void update(float deltaTime)
        {
            isHovering = false;
            isClicked = false;
            color = BLUE;
            if (CheckCollisionPointRec(GetMousePosition(), rect))
            {
                isHovering = true;
            }
            if (isHovering)
            {
                color = SKYBLUE;
                if (IsMouseButtonPressed(MOUSE_LEFT_BUTTON) && isClicked != true)
                {
                    color = WHITE;
                    isClicked = true;
                }
            }
        }

        public void draw()
        {
            DrawRectangleRec(rect, color);
        }
    }
}