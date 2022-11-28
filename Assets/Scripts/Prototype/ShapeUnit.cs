using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PrototypePattern
{
	public class ShapeUnit : MonoBehaviour
	{
        #region Public Variable
        public ShapeModel carModelData;
		public Text carNameTxt;
		public Text carSpeedTxt;
		public Text carColorTxt;
		#endregion Public Variable

		#region Public Method
		public virtual void ShowData()
		{
			carNameTxt.text = "Shape Name: " + carModelData.shapeName;
			carSpeedTxt.text = "Shape Type: " + carModelData.dimension;
			carColorTxt.text = "Shape Color: " + carModelData.shapeColor;
		}
		#endregion Public Method
	}
}

