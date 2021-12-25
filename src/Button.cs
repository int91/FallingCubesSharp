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
        Text t;
        public Button(int x, int y, int width, int height)
        {
            this.rect = new Rectangle(x, y, width, height);
            t = new Text(x + ((width/2)-20), y + (height/2)-10, "Quit", WHITE);
        }

        public void update(float deltaTime)
        {
            t.update(deltaTime);
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
            t.draw();
        }
    }
}