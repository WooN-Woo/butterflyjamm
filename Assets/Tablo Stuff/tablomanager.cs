using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tablomanager : MonoBehaviour
{

    public GameObject cam1;
    public GameObject cam2;
    public GameObject player;public GameObject player2;
    tabloAnim tb;
   
    private void Awake()
    {
        tb = Object.FindObjectOfType<tabloAnim>();
    }
     
   
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "colider" && Input.GetKeyDown(KeyCode.E))
        {
          
                StartCoroutine(tablo());
            
        }
    }
    IEnumerator tablo()
    {
        cam1.SetActive(true);
        
        yield return new WaitForSeconds(2.5f);
        tb.canPlay = true;
        yield return new WaitForSeconds(2.5f);
        tb.canPlay = false;
        player.transform.position = new Vector3(476, 2, 771);  player2.transform.position = new Vector3(476, 2, 771);
     
        tb.isTeleport = true;
        cam1.SetActive(false);
       
        yield return new WaitForSeconds(2.5f);
        tb.isTeleport = false;


    }


}
