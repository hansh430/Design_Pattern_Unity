using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ComponentPattern
{
    public class MovementController : MonoBehaviour
    {

        #region Inspector
        [SerializeField] private GameObject player;
        [SerializeField] private float speed;
        [SerializeField] private Rigidbody rb;
        #endregion Inspector

        #region MonoBehaviour
        void Start()
        {
            rb = player.GetComponent<Rigidbody>();
        }

        private void FixedUpdate()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
            rb.AddForce(movement * speed);

        }
        #endregion MonoBehaviour
    }
}
