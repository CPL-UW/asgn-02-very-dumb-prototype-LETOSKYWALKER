using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CARD : MonoBehaviour
{
    private height;
    private width;
    public back

    public CARD()
    {
        height = 32;
        width = 16;
        back = true;
    }

    public void editHeight(int h)
    {
        height = h;
        System.out.println("card height has been modified to " + h);
    }

    public void editWidth(int w)
    {
        width = w;
        System.out.println("card width has been modified to " + w);
    }

    public void flipCard()
    {
        if(back == true)
        {
            back = false;
        }
        if (back == false)
        {
            back = true;
        }
        System.out.println("card has been flipped");
    }
}
