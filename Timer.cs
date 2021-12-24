using System;
using System.Numerics;
using System.Collections.Generic;

namespace TextBasedDemo 
{
    class Timer
    {
        float curTime;
        public float waitTime;
        bool isRunning;
        public bool isDone;
        public Timer()
        {
            isRunning = false;
            curTime = 0.0f;
        }

        public void update(float deltaTime)
        {
            if (isRunning)
            {
                curTime += 1 * deltaTime;
                if (curTime >= waitTime)
                {
                    isDone = true;
                    stop();
                }
            }
        }

        public void start()
        {
            isDone = false;
            isRunning = true;
        }

        public void stop()
        {
            isRunning = false;
            curTime = 0.0f;
        }
    }
}