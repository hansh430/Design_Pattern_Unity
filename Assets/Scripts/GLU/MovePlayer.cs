using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameLoopPattern
{
    public class MovePlayer : MonoBehaviour
    {
        #region Private Variable
        private Rigidbody rb;
        #endregion Private Variable

        #region MonoBehaviour
        void Awake()
        {
            rb = transform.GetComponent<Rigidbody>();
        }
        #endregion MonoBehaviour

        #region Public method

        /// <summary>
        /// Method to move player
        /// </summary>
        public void Move(float speed, bool isJumping)
        {
            if (isJumping)
            {
                rb.AddForce(new Vector3(0f, speed * 10f, 0f));
            }
        }
        #endregion Public method
    }
}
