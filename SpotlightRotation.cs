using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotlightRotation : MonoBehaviour
{
    public Quaternion startQuaternion;
    public float lerpTime = 1;
    public float RotateAmount = 1;
    public bool rotateConstantly;
    // Start is called before the first frame update
    void Start()
    {
        startQuaternion = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if(rotateConstantly)
        {
            transform.Rotate(Vector3.up * RotateAmount);
        }
    }
    
}
