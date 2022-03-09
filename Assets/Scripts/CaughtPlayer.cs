using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Maze
{
    public sealed class CaughtPlayer : EventArgs
    {

        public Color Color {get;}
        public CaughtPlayer(Color color)
        {
            Color = color;
        }
    }
}
