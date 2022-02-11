using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HANDCONTENT : MonoBehaviour
{
    private List<CARD> deck;

    public void draw(CARD c)
    {
        deck.Add(c);
    }
}
