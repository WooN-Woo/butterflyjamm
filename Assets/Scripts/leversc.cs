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
            //1.kap� a��l�r ilk3 yukar� son2 a��a��
        }

        if (value == 5)
        {
            //2.kap� a��l�r 1 2 4 a��a�� 3 5 yukar�
        }

        if (value == 15)
        {
            //3.kap� a��l�r 1 5 a��a�� 2 3 4 yukar�
        }

        if (value == -25)
        {
            //4.kap� a��l�r 1 2 3 4 a��a�� 5 yukar�
        }

        if (value == -45)
        {
            //5. kap� a��l�r 1 2 4 5 a��a�� 3 yukar�
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
