using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern
{
    /// <summary>
    /// ConcreteStateA
    /// </summary>
    public class HealthyState : State
    {
        #region overridden method
        public void ExecuteCommand(Player player)
        {
            Player.Instance.stateTxt.color = Color.green;
            Player.Instance.stateTxt.text = "Healthy";
        }
        #endregion overridden method
    }
}