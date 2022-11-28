using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManagement : MonoBehaviour {

    [SerializeField] private GameObject mainPanel;
	public void LoadInfoPanel(GameObject panel)
    {
        panel.SetActive(true);
    }
    public void Back()
    {
        mainPanel.SetActive(true);
    }
    public void LoadDesiredScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
