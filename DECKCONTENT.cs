using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using CARD;

public class DECKCONTENT : MonoBehaviour
{
    private Stack<CARD> deck;
    
    public DECKCONTENT(Stack<CARD> dk)
    {
        deck = dk;
    }

    public CARD draw()
    {
        return deck.Pop();
    }
}
