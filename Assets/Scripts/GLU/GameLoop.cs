using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameLoopPattern
{
	public class GameLoop : MonoBehaviour
	{
        #region Inspector
        [SerializeField] private bool isJumping;
		[SerializeField] private MovePlayer movePlayer;
		#endregion Inspector

		#region MonoBehaviour
		void Awake()
		{
			movePlayer = GetComponent<MovePlayer>();
			isJumping = false;
		}
		void Update()
		{
			if (!isJumping)
			{
				isJumping = Input.GetButtonDown("Jump");
			}
		}

		void FixedUpdate()
		{
			float move = Input.GetAxis("Vertical");
			movePlayer.Move(move, isJumping);
		}
		#endregion MonoBehaviour
	}
}
