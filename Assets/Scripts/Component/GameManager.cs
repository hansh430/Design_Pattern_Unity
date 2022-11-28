using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ComponentPattern
{
	public class GameManager : MonoBehaviour
	{

		#region Inspector
		public GameObject gameOverPanel;
		public GameObject welldonePanel;
		public Text scoreText;
		#endregion Inspector

		/// <summary>
		/// Singleton
		/// </summary>
		public static GameManager instance;

		#region MonoBehaviour
		private void Awake()
		{
			if (instance != null)
			{
				Destroy(gameObject);
			}
			else
			{
				instance = this;
				//DontDestroyOnLoad(gameObject);
			}
		}
		#endregion MonoBehaviour
	}
}