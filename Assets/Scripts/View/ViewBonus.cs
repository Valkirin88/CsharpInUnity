using System.Collections;

using UnityEngine;
using System;
using UnityEngine.UI;

namespace Maze
{
    public sealed class ViewBonus
    {
        private Text _bonusLabel;


        public ViewBonus(GameObject bonusLabelPrefab)
        {
            _bonusLabel = bonusLabelPrefab.GetComponent<Text>();
            _bonusLabel.text = String.Empty;
        }

        public void Display(int value)
        {
            _bonusLabel.text = $"Bonus: {value}";
        }

    }
}
