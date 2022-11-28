using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern
{
    /// <summary>
    /// ConcreteStateC
    /// </summary>
    public class DeadState : State
    {
        #region overridden method
        public void ExecuteCommand(Player player)
        {
            Player.Instance.stateTxt.color = Color.red;
            Player.Instance.stateTxt.text = "Dead";
        }
        #endregion overridden method
    }
}