using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace StatePattern
{
    public class Player : MonoBehaviour
    {

        #region Other variables
        public static Player Instance;   //Instance of this class
        public Text stateTxt;            // text of State
        State currentState;              //Instance of State Interface
        #endregion Other variables

        #region MonoBehaviour
        void Awake()
        {
            Instance = this;
        }
        #endregion MonoBehaviour

        #region Public methods
        public Player()
        {
            this.currentState = new HealthyState();
        }

        public void Bullethit(int bullets)
        {

            if (bullets < 5)
                this.currentState = new HealthyState();
            if (bullets >= 5 && bullets < 10)
                this.currentState = new HurtState();
            if (bullets >= 10)
                this.currentState = new DeadState();

            currentState.ExecuteCommand(this);
        }
        #endregion Public methods
    }
}
