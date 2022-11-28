using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MediaterPattern
{
    public class User : MonoBehaviour
    {
        #region private variable
        private string name;
        #endregion private variable

        #region public methods
        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public User(string name)
        {
            this.name = name;
        }

        public void sendMessage(string message)
        {
            ChatRoomMediater.Instance.ShowMessage(this, message);
        }
        #endregion public methods
    }
}
