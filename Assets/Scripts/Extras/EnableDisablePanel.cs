using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnableDisablePanel : MonoBehaviour {

    #region Inspector
    [SerializeField] private Toggle toggle;
	[SerializeField] private bool isEnable;
	#endregion Inspector

	#region Monobehaviour
	void Update () {
		isEnable = toggle.GetComponent<Toggle>().isOn;
		
		if(isEnable)
        {
			gameObject.SetActive(false);
        }
        
	}
	#endregion Monobehaviour
}
