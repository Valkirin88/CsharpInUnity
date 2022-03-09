using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
namespace Test
{
    public class View : MonoBehaviour
    {
        [SerializeField] public Transform _transform;
        [SerializeField] public Collider _collider;
        [SerializeField] public Rigidbody _rigidbode;

        public Action<Collider> OnLevelObjectContact { get; set; }

        private void OnTriggerEnter(Collider other)
        {
            Debug.Log(other);
            Collider LevelObject = other;
            OnLevelObjectContact?.Invoke(LevelObject);
        }
    }
}
 