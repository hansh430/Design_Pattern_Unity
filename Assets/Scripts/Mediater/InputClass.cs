using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MediaterPattern
{
	public class InputClass : MonoBehaviour
	{

		#region Internal variable
		private string msg;
		#endregion Internal variable

		#region Inspector
		[SerializeField]
		private GameObject firstInputField;
		[SerializeField]
		private GameObject secondInputField;
		[SerializeField]
		private Text user1;
		[SerializeField]
		private Text user2;
		#endregion Inspector

		#region Public Methods
		/// <summary>
		/// two button events for sending message typed in input field
		/// </summary>
		public void FirstUserMsg()
		{
			msg = firstInputField.GetComponent<Text>().text;
			User firstUser = new User(user1.text);
			firstUser.sendMessage(msg);
		}
		public void SecondUserMsg()
		{
			msg = secondInputField.GetComponent<Text>().text;
			User secondUser = new User(user2.text);
			secondUser.sendMessage(msg);
		}
		#endregion Public Methods
	}
}
