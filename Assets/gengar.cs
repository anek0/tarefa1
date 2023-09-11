using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gengar : MonoBehaviour
{
   bool right = true;
    public float limitR, limitL;
    // Start is called before the first frame update
    void Start()
{}

void Update()
    {
     if (right)
     {
        transform.position += new Vector3(0.09f, 0,0);
        if (transform.position.x > limitR)
        {
            right= false;
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
     }
     else
     {
       transform.position -= new Vector3(0.09f, 0, 0);
       if (transform.position.x < limitL)
       {
          right = true;
          transform.rotation= Quaternion.Euler(0, 0, 0);
       }
     }
    }
}