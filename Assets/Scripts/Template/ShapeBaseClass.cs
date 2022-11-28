using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TemplatePattern
{
    /// <summary>
    ///'AbstractClass' abstract class
    /// </summary>
    public abstract class ShapeBaseClass : MonoBehaviour
    {

        #region Public Methods
        /// <summary>
        ///   // default step
        /// </summary>
        public void Jump(GameObject obj)
        {
            Rigidbody rb;
            rb = obj.GetComponent<Rigidbody>();
            rb.AddForce(new Vector3(0f, 500f, 0f));
        }

        /// <summary>
        /// /// steps that will be overidden by subclass
        /// </summary>
        public abstract void ShapeColor();

        /// <summary>
        ///   // default step
        /// </summary>
        public void ShowEffect(GameObject obj)
        {
            obj.transform.localScale = new Vector3(transform.localScale.x + 0.1f, transform.localScale.y + 0.1f, transform.localScale.z + 0.1f);
        }

        /// <summary>
        /// //Template Method
        /// </summary>
        public void ShapeDetail(GameObject obj)
        {
            this.Jump(obj);
            this.ShapeColor();
            this.ShowEffect(obj);
        }
        #endregion Public Methods
    }
}
