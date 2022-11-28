using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MediaterPattern
{
    public class ChatRoomMediater : MonoBehaviour
    {

        #region Inspector
        [SerializeField] private Text firstUserName;
        [SerializeField] private Text secondUserName;
        [SerializeField] private Text firstUserMsg;
        [SerializeField] private Text secondUserMsg;
        #endregion Inspector
        /// <summary>
        /// Singleton
        /// </summary>
        public static ChatRoomMediater Instance;

        #region MonoBehaviour
        void Awake()
        {
            Instance = this;
        }
        #endregion MonoBehaviour

        #region Public method
        /// <summary>
        /// Method to show message
        /// </summary>
        public void ShowMessage(User user, string message)
        {

            if (user.getName() == firstUserName.text)
            {
                firstUserMsg.text = message;
            }
            else if (user.getName() == secondUserName.text)
            {
                secondUserMsg.text = message;
            }

        }
        #endregion Public method
    }
}
