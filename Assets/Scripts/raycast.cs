using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast : MonoBehaviour
{
    RaycastHit rayhit;
   
    public float range;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        open();
    }

    void open()
    {
       if (Physics.Raycast(this.transform.position, transform.TransformDirection(Vector3.forward), out rayhit, range))
        {
            Debug.DrawRay(this.transform.position, transform.TransformDirection(Vector3.forward) * rayhit.distance, Color.green);
            Debug.Log(rayhit.transform.name);
        }


    }
}
