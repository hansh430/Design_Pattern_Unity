using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour {

    #region Public method
    /// <summary>
    /// Method to load main scene
    /// </summary>
    public void LoadMainScene(string sceneName)
    {
		Time.timeScale = 1;
		SceneManager.LoadScene(sceneName);
    }
    #endregion Public method
}
