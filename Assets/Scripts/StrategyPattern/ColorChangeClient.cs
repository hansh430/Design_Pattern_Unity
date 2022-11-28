using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrategyPattern
{
    public class ColorChangeClient : MonoBehaviour
    {
        #region Public variables
        public GameObject cube;
        public static ColorChangeClient instance;
        #endregion Public variables

        #region MonoBehaviour
        void Awake()
        {
            instance = this;
        }
        #endregion MonoBehaviour

        #region public metods

        public void RedColor()
        {
            //for red color
            IColorStratergy cs = new RedStrategy();
            ColorChange colorChange = new ColorChange(cs);
            colorChange.ShowColor();
        }
        public void BlueColor()
        {
            //for blue color
            IColorStratergy cs = new BlueStrategy();
            ColorChange colorChange = new ColorChange(cs);
            colorChange.ShowColor();
        }

        public void GreenColor()
        {
            //for Green color
            IColorStratergy cs = new GreenStrategy();
            ColorChange colorChange = new ColorChange(cs);
            colorChange.ShowColor();
        }
        #endregion public metods
    }
}
