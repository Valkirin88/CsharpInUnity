using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Maze
{
    public sealed class Reference
    {
        private GameObject _bonusLabel;
        private GameObject _endGameLabel;
        private GameObject _restartButton;
        private Canvas _canvas;
        private Camera _mainCamera;
        private GameObject _imageGameOver;
        private GameObject _imageLevelComplited;



        public GameObject BonusLabel
        {
            get
            {
                if (_bonusLabel == null)
                {
                    GameObject bonusPrefab = Resources.Load<GameObject>("UI/Bonus");
                    _bonusLabel = Object.Instantiate(bonusPrefab, Canvas.transform);
                }
                return _bonusLabel;
            }

            set => _bonusLabel = value;
        }
        public GameObject EndGameLabel
        {
            get
            {
                if (_endGameLabel == null)
                {
                    GameObject endGamePrefab = Resources.Load<GameObject>("UI/EndGame");
                    _endGameLabel = Object.Instantiate(endGamePrefab, Canvas.transform);

                }
                return _endGameLabel;
            }
            set => _endGameLabel = value;
        }
        public GameObject RestartButton
        {
            get
            {
                if (_restartButton == null)
                {
                    GameObject restartButtonPrefab = Resources.Load<GameObject>("UI/RestartButton");
                    _restartButton = Object.Instantiate(restartButtonPrefab, Canvas.transform);

                }
                return _restartButton;
            }
            set => _restartButton = value;
        }
        public Canvas Canvas
        {
            get
            {
                if (_canvas == null)
                {
                    _canvas = Object.FindObjectOfType<Canvas>();
                }
                return _canvas;
            }
            set => _canvas = value;
        }
        public Camera MainCamera
        {
            get
            {
                if (_mainCamera == null)
                {
                    _mainCamera = Camera.main;
                }

                return _mainCamera;
            }
            set => _mainCamera = value;
        }

        public GameObject ImageGameOver
        {
            get
            {
                if (_imageGameOver == null)
                {
                    GameObject imagePrefab = Resources.Load<GameObject>("UI/ImageGameOver");
                    _imageGameOver = Object.Instantiate(imagePrefab, Canvas.transform);



                }
                return _imageGameOver;
            }
            set => _imageGameOver = value;
        }

        public GameObject ImageLevelComplited
        {
            get
            {
                if (_imageLevelComplited == null)
                {
                    GameObject imageLevelPrefab = Resources.Load<GameObject>("UI/ImageLevelCompleted");
                    _imageLevelComplited = Object.Instantiate(imageLevelPrefab, Canvas.transform);



                }
                return _imageLevelComplited;
            }
            set => _imageLevelComplited = value;
        }
    }
}
