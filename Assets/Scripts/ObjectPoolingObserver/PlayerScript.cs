using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObjectPoolPattern
{

	public class PlayerScript : MonoBehaviour
	{
		#region Inspector
		[SerializeField] private GameObject bulletPrefeb;
		[SerializeField] private Transform gunPosition;
		[SerializeField] private int shootCount = 10;
		[SerializeField] private float PlayerSpeed = 5.0f;
		#endregion Inspector

		#region Delegates and Events
		//deligates
		public delegate void BulletCount(int bulletCount);
		public delegate void WrongAttempt();
		//event  
		public static event BulletCount updateBullet;
		public static event WrongAttempt over;
		#endregion Delegates and Events

		#region MonoBehaviour
		void Update()
		{
			float amtToMove = Input.GetAxis("Horizontal") * PlayerSpeed * Time.deltaTime;
			transform.Translate(Vector3.right * amtToMove);
			if (shootCount == 0)
			{
				over();  //event called
			}
		}

		#endregion MonoBehaviour

		#region Public method
		/// <summary>
		/// This Method is used to fire a bullet
		/// </summary>
		public void Fire()
		{
			GameObject bullet = PoolManager.instance.GetBullet();
			if (bullet != null)
			{
				bullet.transform.position = gunPosition.transform.position;
				bullet.SetActive(true);

			}
			shootCount--;
			updateBullet(shootCount);  //event is called
		}
		#endregion Public method

	}
}
