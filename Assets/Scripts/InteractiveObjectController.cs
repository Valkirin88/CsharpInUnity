using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Maze
{

    public class InteractiveObjectController : MonoBehaviour, IComparable<Bonus>
    {
        ListExecuteObject interavtiveObj;
        

        private void Start()
        {
            interavtiveObj = new ListExecuteObject();
        }

              
        void Update()
        {
         //   interavtiveObj.Update();
        }

        public int CompareTo(Bonus other)
        {
            if (other is Bonus bonus) return name.CompareTo(other.name);
            else throw new ArgumentException("Некорректное значение");
        }
    }
}
