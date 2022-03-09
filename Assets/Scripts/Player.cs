using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace Maze
{
    public sealed class Player : Unit
    {

        private void Awake()
        {
            _transform = transform;
            if (GetComponent<Rigidbody>())
            {
                _rigidbody = GetComponent<Rigidbody>();

            }
        }

        public override void Move(float x, float y, float z)
        {
            
            if (_rigidbody)
            {
                _rigidbody.AddForce(new Vector3(x, y, z) * Speed);
            }
            else
            {
                Debug.Log("No Rigidbody");
            }

        }

        private void Update()
        {
            
        }






    }
    
}
