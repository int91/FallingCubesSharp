using System;
using Raylib_cs;
using static Raylib_cs.Color;

namespace TextBasedDemo
{
    class Text
    {
        private float posX, posY;
        private String text;
        private Color color;
        public Text(float posX, float posY, String text, Color color)
        {
            this.posX = posX;
            this.posY = posY;
            this.text = text;
            this.color = color;
        }

        public void setText(String newText)
        {
            this.text = newText;
        }

        public void update(float deltaTime)
        {

        }
        public void draw()
        {
            Raylib.DrawText(this.text, ((int)this.posX), ((int)this.posY), 20, this.color);
        }
    }
}