using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CARD;
using HANDCONTENT;
using DECKCONTENT;



public class EVENT : MonoBehaviour
{
    public DECKCONTENT dk;
    public HANDCONTENT hd;

    public EVENT(DECKCONTENT deck, HANDCONTENT hand)
    {
        dk = deck;
        hd = hand;
    }

    public void drawCard()
    {
        CARD cd = dk.draw();
        cd.flipCard();
        hd.draw(cd);

    }
}



