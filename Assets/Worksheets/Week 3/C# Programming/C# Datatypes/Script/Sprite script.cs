using System.Collections;
using System.Collections.Generic;
using UnityEngine;






namespace GADVDataTypes
{
    public class Spritescript : MonoBehaviour
    {
        private Transform spriteTransform;
        private string scale = "2.0a";

        void Start()
        {
            spriteTransform = GetComponent<Transform>();

            // Convert the string to float
            float scaleValue = float.Parse(scale);

            spriteTransform.localScale = new Vector3(scaleValue, scaleValue, 1f);
        }
    }
}
