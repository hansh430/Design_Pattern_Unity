using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern
{
    #region Interface
    public interface State
    {
        void ExecuteCommand(Player player);
    }
    #endregion Interface
}