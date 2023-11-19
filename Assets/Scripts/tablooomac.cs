using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tablooomac : MonoBehaviour
{

    public GameObject cam1;
    public GameObject cam2;
    public GameObject player; public GameObject player2;
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
            StartCoroutine(tablo2());
        }
    }
    IEnumerator tablo()
    {
        cam1.SetActive(true);

        yield return new WaitForSeconds(2.5f);
        tb.canPlay = true;
        yield return new WaitForSeconds(2.5f);
        tb.canPlay = false;
        player.transform.position = new Vector3(263.7f, 15.4f, 341.5f); player2.transform.position = new Vector3(263.7f, 15.4f, 341.5f);

        tb.isTeleport = true;
        cam1.SetActive(false);


        yield return new WaitForSeconds(2.5f);
        tb.isTeleport = false;
        player.transform.position = new Vector3(285.0276f, 20.41f, 372.0618f);

    }
    IEnumerator tablo2()
    {
        cam2.SetActive(true);

        yield return new WaitForSeconds(2.5f);
        tb.canPlay = true;
        yield return new WaitForSeconds(2.5f);
        tb.canPlay = false;
        player.transform.position = new Vector3(263.7f, 15.4f, 341.5f); player2.transform.position = new Vector3(263.7f, 15.4f, 341.5f);

        tb.isTeleport = true;
        cam2.SetActive(false);


        yield return new WaitForSeconds(2.5f);
        tb.isTeleport = false;
        player.transform.position = new Vector3(285.0276f, 20.41f, 372.0618f);

    }
}
