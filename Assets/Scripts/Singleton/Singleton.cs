using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SingletonPattern
{
    public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        #region Instance
        public static T instance { get; set; }
        #endregion Instance

        #region MonoBehaviour
        protected virtual void Awake()
        {
            if (instance == null)
            {
                instance = (T)FindObjectOfType(typeof(T));
                // DontDestroyOnLoad(this.gameObject);  //it will be used when when we don't want to destroy during sceneload
            }
            else
            {
                Destroy(gameObject);
            }
        }
        #endregion MonoBehaviour
    }
}
