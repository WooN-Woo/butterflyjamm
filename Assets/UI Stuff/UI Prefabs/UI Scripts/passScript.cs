using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class passScript : MonoBehaviour
{
    public bool isPassNeed;
    public InputField PassInput;
    public string Password = "otsbir";
    public GameObject InputStuff;


    private void Update()
    {
        passManager();
    }

    public void passManager()
    {
        if(isPassNeed == true)
        {
            InputStuff.SetActive(true);
            string userInput = PassInput.text;
            
            if(userInput == Password)
            {
                Debug.Log("�");
                
            }
            else
            {
                //San�r�m Yanl�� Girdim Sesi Gelsin cart curt
                Debug.Log("zortlatt�");
            }

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                isPassNeed= false;
            }

        }
        else
        {
            InputStuff.SetActive(false);
        }
    }

}
