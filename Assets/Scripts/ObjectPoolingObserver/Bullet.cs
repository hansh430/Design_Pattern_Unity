using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObjectPoolPattern
{

	public class Bullet : MonoBehaviour
	{
		#region Inspector
		[SerializeField] private float bulletSpeed = 10f;
		[SerializeField] private float lifeDuration = 2f;
		[SerializeField] private float lifeTimer;
		[SerializeField] private int rightHit;
		#endregion Inspector

		#region Delegates and Events
		//delegate  
		public delegate void CubeHit();

		//event  
		public static event CubeHit welldone;
		#endregion Delegates and Events

		#region MonoBehaviour
		private void OnEnable()
		{
			lifeTimer = lifeDuration;
		}

		void Start()
		{
			rightHit = 0;
		}

		private void Update()
		{
			transform.position += Vector3.forward * bulletSpeed * Time.deltaTime;
			lifeTimer -= Time.deltaTime;
			if (lifeTimer <= 0)
			{
				gameObject.SetActive(false);
			}
		}

		private void OnTriggerEnter(Collider other)
		{
			if (other.CompareTag("cube"))
			{
				Destroy(other.gameObject);
				rightHit++;
				if (rightHit == 4)
				{
					welldone(); //event is called
				}
			}
		}
		#endregion MonoBehaviour
	}
}
