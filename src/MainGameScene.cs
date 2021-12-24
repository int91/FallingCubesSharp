using System;
using System.Numerics;
using System.Collections.Generic;
using Raylib_cs;
using static Raylib_cs.Raylib;
using static Raylib_cs.KeyboardKey;
using static Raylib_cs.Color;

namespace TextBasedDemo
{
    class MainGameScene : Scene
    {
        public bool isRunning;
        Player p;
        Timer enemyTimer;
        Text tlives;
        Button b;
        bool alive = true;
        public MainGameScene()
        {
            this.entities = new List<Entity>();
        }

        public override void init()
        {
            isRunning = true;
            b = new Button(300+50, 200, 100, 40);
            tlives = new Text(0, 10, "Lives", WHITE);
            enemyTimer = new Timer();
            p = new Player(new Position(400-16,400), WHITE);
            createEntity(p);
            enemyTimer.waitTime = 0.3f;
            enemyTimer.start();
        }

        public override void update(float deltaTime)
        {
            if (p.lives <= 0)
            {
                alive = false;
            }
            if (!alive)
            {
                deltaTime = 0;
                b.update(deltaTime);
                if (b.isClicked)
                {
                    isRunning = false;
                }
            }
            tlives.setText("Lives: " + p.lives);
            enemyTimer.update(deltaTime);
            if (enemyTimer.isDone)
            {
                Random r = new Random();
                int rX = r.Next(0,800-32);
                int rY = r.Next(-64, 16);
                createEntity(new Enemy(new Position(rX, rY), RED));
                enemyTimer.start();
            }
            
            for (int i = 0; i < entities.Count; i++)
            {
                entities[i].update(deltaTime);
                if (entities[i] is Enemy)
                {
                    var enemr = new Rectangle((int)entities[i].pos.getX(), (int)entities[i].pos.getY(), 32, 32);
                    if (CheckCollisionRecs(enemr, new Rectangle((int)p.pos.getX(), (int)p.pos.getY(), 32, 32)))
                    {
                        entities.RemoveAt(i);
                        p.lives--;
                    }
                    if (entities[i].pos.getY() >= 480)
                    {
                        entities.RemoveAt(i);
                    }
                }
            }
        }

        public override void draw()
        {
            if (!alive)
            {
                b.draw();
            }
            tlives.draw();
            for (int i = 0; i < entities.Count; i++)
            {
                entities[i].draw();
            }
        }
    }
}