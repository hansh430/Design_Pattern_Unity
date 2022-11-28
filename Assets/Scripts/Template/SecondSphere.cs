﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TemplatePattern
{

    public class SecondSphere : ShapeBaseClass
    {
        #region Inspector
        [SerializeField] private Text ShapeDesc;
        #endregion Inspector

        #region Overridden Method
        public override void ShapeColor()
        {
            ShapeDesc.text = "This is Red Sphere";
        }
        #endregion Overridden Method

        #region MonoBehaviour
        /// <summary>
        /// Raycast for Click Events
        /// </summary>
        void FixedUpdate()
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                if (Input.GetMouseButtonDown(0) && hit.collider.tag == "red")
                {
                    ShapeDetail(this.gameObject);
                }
            }
        }
        #endregion MonoBehaviour
    }
}
