using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leversc : MonoBehaviour
{
    public GameObject lever;
    public GameObject lever2;
    public GameObject lever3;
    public GameObject lever4;
    public GameObject lever5;
    public int value;

    private void Update()
    {
        denetim();
        if (value == -15)
        {
            //1.kapý açýlýr ilk3 yukarý son2 aþþaðý
        }

        if (value == 5)
        {
            //2.kapý açýlýr 1 2 4 aþþaðý 3 5 yukarý
        }

        if (value == 15)
        {
            //3.kapý açýlýr 1 5 aþþaðý 2 3 4 yukarý
        }

        if (value == -25)
        {
            //4.kapý açýlýr 1 2 3 4 aþþaðý 5 yukarý
        }

        if (value == -45)
        {
            //5. kapý açýlýr 1 2 4 5 aþþaðý 3 yukarý
        }


    }
    void denetim()
    {
        if (lever.transform.position.y < 4)
        {
            value = value - 5;
        }
        if (lever.transform.position.y > 4)
        {
            value = value + 5;

        }

        if (lever2.transform.position.y < 4)
        {
            value = value - 10;
        }
        if (lever2.transform.position.y > 4)
        {
            value = value + 10;
        }

        if (lever3.transform.position.y < 4)
        {
            value = value - 15;
        }
        if (lever3.transform.position.y > 4)
        {
            value = value + 15;
        }


        if (lever4.transform.position.y < 4)
        {
            value = value - 20;
        }
        if (lever4.transform.position.y > 4)
        {
            value = value + 20;
        }

        if (lever5.transform.position.y < 4)
        {
            value = value - 25;
        }
        if (lever5.transform.position.y > 4)
        {
            value = value + 25;
        }
    }
}
