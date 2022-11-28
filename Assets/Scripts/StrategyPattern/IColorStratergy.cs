using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrategyPattern
{
    #region Interface
    public interface IColorStratergy
    {
       void ChangeColor();
    }
    #endregion Interface

    #region Statergies
    //'ConcreteStrategyA' class
    public class RedStrategy : IColorStratergy
    {
        public void ChangeColor()
        {
            // Implement color strategy
            ColorChangeClient.instance.cube.GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }
    //'ConcreteStrategyB' class
    public class BlueStrategy : IColorStratergy
    {
        public void ChangeColor()
        {
            // Implement color strategy
            ColorChangeClient.instance.cube.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
    }

    //'ConcreteStrategyC' class
    public class GreenStrategy : IColorStratergy
    {
        public void ChangeColor()
        {
            // Implement color strategy
            ColorChangeClient.instance.cube.GetComponent<MeshRenderer>().material.color = Color.green;
        }
    }
    #endregion Statergies

    #region Context Class
    /// <summary>
    /// 'Context' class-it uses strategies
    /// </summary>
    public class ColorChange
    {
        private IColorStratergy _colorStrategy;

        public ColorChange(IColorStratergy colorStrategy)
        {
            _colorStrategy = colorStrategy;
        }

        public void ShowColor()
        {
            _colorStrategy.ChangeColor();
        }
    }
    #endregion Context Class
}
