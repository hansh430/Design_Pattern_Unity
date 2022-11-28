using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern
{
    //'Client'
    public class PlayerController : MonoBehaviour
    {
        #region Inspector
        [SerializeField] private float speed;
        [SerializeField] private Rigidbody rb;
        #endregion Inspector
        /// <summary>
        /// Object of Player Class
        /// </summary>
        Player player = new Player();

        #region MonoBehaviour
        void Start()
        {
            rb = GetComponent<Rigidbody>();
        }

        /// <summary>
        /// To move player
        /// </summary>
        private void FixedUpdate()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
            rb.AddForce(movement * speed);

        }
        void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.tag == "red")
            {
                player.Bullethit(12);
            }
            else if (other.gameObject.tag == "blue")
            {
                player.Bullethit(9);
            }
            else if (other.gameObject.tag == "green")
            {
                player.Bullethit(3);
            }
        }
        #endregion MonoBehaviour
    }
}
