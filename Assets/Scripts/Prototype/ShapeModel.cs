using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrototypePattern
{
    [CreateAssetMenu(fileName = "Car Model")]
    public class ShapeModel : ScriptableObject
    {
        public string shapeColor;
        public string dimension;
        public string shapeName;
    }
}

