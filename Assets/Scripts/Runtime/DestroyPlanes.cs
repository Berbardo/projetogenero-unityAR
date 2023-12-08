using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

namespace UnityEngine.XR.ARFoundation.Samples
{
    public class DestroyPlanes : MonoBehaviour
    {
        // Start is called before the first frame update
        void OnEnable()
        {
            Object[] allObjects = FindObjectsOfType(typeof(ARPlane));
            foreach(ARPlane obj in allObjects) {
                if(obj.transform.name == "Asteroid(Clone)"){
                    Destroy(obj);
                }
            }
        }
    }
}
