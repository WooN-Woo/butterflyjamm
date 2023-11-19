using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorController : MonoBehaviour
{
    public Animator anim;
    bool canOpen;
    float time;

    private void Update()
    {
        OpenDoor();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag=="colider")
        {
            canOpen = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "colider")
        {
            canOpen = false;
        }
    }

    private void OpenDoor()
    {
        if(canOpen == true && Input.GetKeyDown(KeyCode.E))
        {
            anim.Play("opening");
            time = 3f;
        }
        
        if(time > 0)
        {
            time -= Time.deltaTime;
        }

        if(!canOpen && time < 0)
        {
            anim.Play("close");
        }
    }
}
