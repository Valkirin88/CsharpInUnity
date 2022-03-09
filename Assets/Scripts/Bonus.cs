using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Maze
{
    public  abstract class Bonus : MonoBehaviour, IExecute
    {
       private bool _isInteractable;
        public bool IsInteractible
        {
            get { return _isInteractable; }

            private set
            {
                _isInteractable = value;
                GetComponent<Renderer>().enabled = value;
                GetComponent<Collider>().enabled = value;
            }
        }
        protected Color _color;

       // public ParticleSystem.MainModule main;

        private void Start()
        {
            IsInteractible = true;
            _color = Random.ColorHSV();
           

            if (TryGetComponent(out Renderer renderer))
            {
                renderer.sharedMaterial.color = _color;

            }
        }
       

        private void OnTriggerEnter(Collider other)
        {
            if (!IsInteractible||!other.CompareTag("Player"))
            {
                return;
            }
            
            Interaction();
            IsInteractible = false;

        }

        protected abstract void Interaction();
        public abstract void Update();
       
    }
}