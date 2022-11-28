using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace ObjectPoolPattern
{

    public class UIManager : MonoBehaviour
    {

        #region Inspector
        [SerializeField] private Text bulletText;
        [SerializeField] private GameObject welldonePanel;
        [SerializeField] private GameObject RetryPanel;
        [SerializeField] private List<GameObject> objectToHide;
        #endregion Inspector

        #region MonoBehaviour
        private void OnEnable()
        {
            Bullet.welldone += Weldone;
            PlayerScript.over += Wrong;
            PlayerScript.updateBullet += UpdateBulletCount;
        }
        private void OnDisable()
        {
            Bullet.welldone -= Weldone;
            PlayerScript.over -= Wrong;
            PlayerScript.updateBullet -= UpdateBulletCount;
        }
        #endregion MonoBehaviour

        #region Private Methods
        private void UpdateBulletCount(int bulletCount)
        {
            bulletText.text = "Hit Left: " + bulletCount.ToString();
        }
        private void Weldone()
        {
            welldonePanel.SetActive(true);
            for (int i = 0; i < objectToHide.Count; i++)
            {
                objectToHide[i].SetActive(false);
            }
        }
        private void Wrong()
        {
            RetryPanel.SetActive(true);
            for (int i = 0; i < objectToHide.Count; i++)
            {
                objectToHide[i].SetActive(false);
            }
        }
        #endregion Private Methods
    }
}
