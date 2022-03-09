using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Maze
{
    public abstract class Unit : MonoBehaviour
    {

        [SerializeField] public Rigidbody _rigidbody;
        public Transform _transform;
        public float Speed = 5;
        
        
      

        public abstract void Move(float x, float y, float z);
      

            
    }
}
