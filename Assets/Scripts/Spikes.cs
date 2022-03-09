using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Maze
{
    public sealed class Spikes : Bonus
    {
        public Transform _transform;
        public event Action<string, Color> SpikesUp = delegate (string str, Color color) { };

    protected override void Interaction()
        {
            transform.Translate(0, 1.5f, 0);
            SpikesUp.Invoke(gameObject.name, _color);
           
        }

        public override void Update()
        {
            
        }





    }
}
