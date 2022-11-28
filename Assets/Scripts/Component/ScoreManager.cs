using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ComponentPattern
{
    public class ScoreManager : MonoBehaviour
    {

        #region Inspector
        private int scoreCount = 0;
        #endregion Inspector

        #region MonoBehaviour
        /// <summary>
        /// GameOver
        /// </summary>
        void OnCollisionEnter(Collision other)
        {
            if (other.collider.tag == "Enemy")
            {
                Time.timeScale = 0;
                GameManager.instance.gameOverPanel.SetActive(true);
            }
        }

        /// <summary>
        /// Weldone
        /// </summary>
        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "coin")
            {
                scoreCount++;
                GameManager.instance.scoreText.text = "Score: " + scoreCount.ToString();
                Destroy(other.gameObject);
                if (scoreCount == 5)
                {
                    Time.timeScale = 0;
                    GameManager.instance.welldonePanel.SetActive(true);
                }

            }
        }
        #endregion MonoBehaviour
    }
}
