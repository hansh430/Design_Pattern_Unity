using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SingletonPattern
{
    public class Play : MonoBehaviour
    {
        #region MonoBehaviour
        void Update()
        {
            if (Input.GetButtonDown("Jump"))
            {
                SpaceCounter.instance.IncreaseScore();
            }
        }
        #endregion MonoBehaviour
    }
}
