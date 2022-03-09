using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

namespace Maze
{
    public sealed class ViewEndGame
    {
        private Text _endGameLabel;

        public ViewEndGame(GameObject endGamePrefab)
        {
            _endGameLabel = endGamePrefab.GetComponent<Text>();
            _endGameLabel.text = String.Empty;
        }


        public void GameOver(string name, Color color)
        {
            //_endGameLabel.text = $"GameOver.Bonus Name {name} Color: {color}";
        }


    }
}
