using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
    public class InputController : IExecute
    {
        private float horizontal;
        private float vertical;
        private readonly Unit _player;
                  

        public InputController(Unit player)
        {
            _player = player;
        }

       public void Update()
        {
             horizontal = Input.GetAxis("Horizontal");
             vertical = Input.GetAxis("Vertical");

             _player.Move(horizontal, 0f, vertical);
        }
    }
}
