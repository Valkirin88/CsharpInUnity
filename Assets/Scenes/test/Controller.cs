 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Test
{
    public class Controller : IDisposable
    {
        private Transform _playerT;
        private Transform _triggerT;
        private View _playerView;

        public Controller(View player, Transform trigger)
        {
            _playerView = player;
            _playerT = player._transform;
            _triggerT = trigger;

            _playerView.OnLevelObjectContact += ControllerRecieveAction;
        }

        private void ControllerRecieveAction(Collider contactView)
        {
            Debug.Log("Обработчик" + contactView.gameObject.name);
            GameObject.Destroy(contactView.gameObject);
        }

        public void Update()
        {
            Debug.Log("Controller Update");
        }

        public void Dispose()
        {
            _playerView.OnLevelObjectContact -= ControllerRecieveAction;
        }
    }
}