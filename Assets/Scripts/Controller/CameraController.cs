using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Maze
{
    public class CameraController : IExecute
    {

        private Transform _player;
        private Vector3 _offset;
        private Transform _camTransform;
     
        public  CameraController(Transform player, Transform mainCamera)
        {
            _player = player;
            _camTransform = mainCamera;
         //   _camTransform.LookAt(_player);
            _offset = _camTransform.position - _player.position;
                      
        }

        public void Update()
        {
            _camTransform.position = _player.position + _offset;
          
        }
    }
}
