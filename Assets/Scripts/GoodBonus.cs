using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Maze
{
    public class GoodBonus : Bonus, IFly, IFlicker, ICloneable
    {
        [SerializeField] private Material _material;
        
        private float heightFly = 1f;
        public int Point = 1;

        public event Action<int> AddPoints = delegate (int i) { };

        private void Awake()
        {
            _material = GetComponent<Renderer>().material;
          
        }

        protected override void Interaction()
        {
            AddPoints.Invoke(Point);
            Debug.Log("No iteraction");
        }

        public void Fly()
        {
            transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time, heightFly), transform.position.z);
        
        }

        public void Flick()
        {
            _material.color = new Color(_material.color.r, _material.color.g, _material.color.b, Mathf.PingPong(Time.time, 2.0f));
           
        }

        public object Clone()
        {
            return new GoodBonus
            {
                heightFly = heightFly,
                _material = _material
            };
        }

        public override void Update()
        {
            Fly();
            Flick();
        }



    }
}
