using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SingletonPattern
{
    public class SpaceCounter : Singleton<SpaceCounter>
    {
        #region Inspector
        [SerializeField] private Text scoreText;
        #endregion Inspector

        #region Internal Variable
        private int score;
        #endregion Internal Variable

        #region Public method
        public void IncreaseScore()
        {
            score++;
            scoreText.text = "Space pressed: " + score.ToString() + " times";
        }
        #endregion Public method
    }
}
