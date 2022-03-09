using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Maze
{
    public sealed class Main : MonoBehaviour, IDisposable
    {
       
      
        private ListExecuteObject _interactiveObject;
        private CameraController _cameraController;
        private InputController _inputController;

        private ViewEndGame _viewEndGame;
        private ViewBonus _viewBonus;

        private Reference _reference;

        private int _bonusCount;

        [SerializeField] private GameObject _player;
        [SerializeField] private Button _restartButton;

        private Image _imageEndGame;
        private Image _imageLevelComplited;
       

        void Awake()
        {
            _reference = new Reference();

            _interactiveObject = new ListExecuteObject();
            _cameraController = new CameraController(_player.transform, _reference.MainCamera.transform);
            _inputController = new InputController(_player.GetComponent<Unit>());

            _interactiveObject.AddExecuteObject(_cameraController);
            _interactiveObject.AddExecuteObject(_inputController);

            

            _viewBonus = new ViewBonus(_reference.BonusLabel);
            _viewEndGame = new ViewEndGame(_reference.EndGameLabel);

            _imageEndGame = _reference.ImageGameOver.GetComponent<Image>();
            _imageEndGame.gameObject.SetActive(false);

           _imageLevelComplited = _reference.ImageLevelComplited.GetComponent<Image>();
            _imageLevelComplited.gameObject.SetActive(false);
            
            
            _restartButton = _reference.RestartButton.GetComponent<Button>();
            _restartButton.onClick.AddListener(RestartGame);
            _restartButton.gameObject.SetActive(false);

          
            

            foreach(var item in _interactiveObject)
            {
                if(item is GoodBonus goodBonus)
                {
                    goodBonus.AddPoints += AddBonus;
                }
                if(item is BadBonus badBonus)
                {
                    badBonus.OnCaughtPlayer += _viewEndGame.GameOver;
                    badBonus.OnCaughtPlayer += CaughtPlayer;
                }
                if (item is Spikes spikes)
                {
                    spikes.SpikesUp += _viewEndGame.GameOver;
                    spikes.SpikesUp += CaughtPlayer;
                }
            }

        }




        void Update()
        {
            for (int i = 0; i < _interactiveObject.Length; i++)
            {
                if(_interactiveObject[i] == null)
                {
                    continue;
                }
                _interactiveObject[i].Update();
            }
        }

        private void RestartGame()
        {
            SceneManager.LoadScene(0);
            Time.timeScale = 1;
        }

        private void CaughtPlayer(string value, Color args)
        {
           
            _imageEndGame.gameObject.SetActive(true);
            _restartButton.gameObject.SetActive(true);
            Time.timeScale = 0;
        }

        private void AddBonus(int value)
        {
            _bonusCount += value;
            _viewBonus.Display(_bonusCount);
            if (_bonusCount == 1)
                Win();
        }    

        public void Dispose()
        {

        }

        private void Win()
        {
            _imageLevelComplited.gameObject.SetActive(true);
            _restartButton.gameObject.SetActive(true);
            Time.timeScale = 0;
        }

    }
} 