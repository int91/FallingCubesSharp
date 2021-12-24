using System;
using System.Numerics;
using System.Collections.Generic;
using Raylib_cs;
using static Raylib_cs.Raylib;
using static Raylib_cs.KeyboardKey;
using static Raylib_cs.Color;

namespace TextBasedDemo
{
    class Scene
    {
        public List<Entity> entities;
        public Scene()
        {
            this.entities = new List<Entity>();
        }
        public virtual void init(){}
        public virtual void update(float deltaTime){}
        public virtual void draw(){}
        public void createEntity(Entity ent)
        {
            this.entities.Add(ent);
        }
    }
}