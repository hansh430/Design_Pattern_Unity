using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObjectPoolPattern
{

	public class PoolManager : MonoBehaviour
	{

		#region Public Variables

		public GameObject bulletPrefab;
		public List<GameObject> bullets;
		public int bulletAmount = 20;
		public static PoolManager instance;

		#endregion Public Variables

		#region MonoBehaviour
		private void Awake()
		{
			instance = this;
			bullets = new List<GameObject>(bulletAmount);
			for (int i = 0; i < bulletAmount; i++)
			{
				GameObject instPrefab = Instantiate(bulletPrefab);
				instPrefab.transform.SetParent(transform);
				instPrefab.SetActive(false);
				bullets.Add(instPrefab);

			}
		}
		#endregion MonoBehaviour

		#region Public method
		/// <summary>
		/// This method returns bullets from list
		/// </summary>
		public GameObject GetBullet()
		{
			foreach (GameObject bullet in bullets)
			{
				if (!bullet.activeInHierarchy)
				{
					bullet.SetActive(true);
					return bullet;
				}
			}
			return null;
		}
		#endregion Public method
	}
}
