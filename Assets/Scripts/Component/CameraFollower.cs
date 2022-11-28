using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ComponentPattern
{
    public class CameraFollower : MonoBehaviour
    {

        #region Inspector
        [SerializeField] private GameObject player;
        [SerializeField] private Vector3 offset;
        [SerializeField] private GameObject camera;
        #endregion Inspector

        #region MonoBehaviour
        private void Start()
        {
            offset = camera.transform.position - player.transform.position;
        }

        private void LateUpdate()
        {
            camera.transform.position = player.transform.position + offset;
        }
        #endregion MonoBehaviour

    }
}
