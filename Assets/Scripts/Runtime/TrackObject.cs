using UnityEngine;
using UnityEngine.UI;

public class TrackObject : MonoBehaviour {
    
    public Vector3 relative_position;

    GameObject Obj;
    Camera mCamera;
    private RectTransform rt;
    private RawImage image;
    Vector2 pos;
    
    void Start ()
    {
        mCamera = GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<Camera> ();
        rt = GetComponent<RectTransform> ();
        // image = GetComponent<RawImage>();
        // image.enabled = false;
    }
    
    void Update ()
    {
        Obj = GameObject.FindWithTag("boneco");

        if (Obj)
        {
            pos = RectTransformUtility.WorldToScreenPoint (mCamera, Obj.transform.position - relative_position);
            rt.position = pos;
            // if (image)
            //     image.enabled = true;
        }
        else
        {
            // if (image)
            //     image.enabled = false;
            // Debug.LogError (this.gameObject.name + ": No Object Attached (TrackObject)");
        }
            
    
    }
}
