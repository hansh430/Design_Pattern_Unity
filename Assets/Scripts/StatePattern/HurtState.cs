using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern
{
    /// <summary>
    /// ConcreteStateB
    /// </summary>
    public class HurtState : State
    {
        #region overridden method
        public void ExecuteCommand(Player player)
        {
            Player.Instance.stateTxt.color = Color.yellow;
            Player.Instance.stateTxt.text = "HurtState";
        }
        #endregion overridden method
    }
}