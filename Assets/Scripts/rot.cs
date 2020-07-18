using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rot : MonoBehaviour
{

    protected bool rotate = false;
    public float x, y, z;
    public Quaternion org_rot; 
    float speed = 0.25f;

    public void OnMouseDown()
    {
  
        rotate = true;

    }

    public void stop_rotate()
    {
        rotate = false;
        transform.rotation = Quaternion.Slerp(transform.rotation, org_rot, Time.time * speed);
    }

    public void Update()
    {
        if (rotate)
        {
            transform.Rotate(new Vector3(x, y, z) * Time.deltaTime);
        }
        
    }
}
