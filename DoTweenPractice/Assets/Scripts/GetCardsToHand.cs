using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class GetCardsToHand : MonoBehaviour
{
    [SerializeField] private Transform[] cards;
    [SerializeField] private int numberOfCards;
    
    [SerializeField] private Transform hand;

    private float offset = 20f;
   
    public void Animate()
    {
        Vector3 firstCardPosition = hand.position - new Vector3(offset * numberOfCards / 2, 0f, 0f);
        Vector3 offsetVector = new Vector3(offset, 0f, 0f);
        Sequence sequence = DOTween.Sequence();
        for (int i = 0; i < numberOfCards; i++)
        {
            sequence.Append(cards[i].DOMove(firstCardPosition + offsetVector * i , 1f));
        }
        
        for (int i = 0; i < numberOfCards; i++)
        {
            Vector3 cardStartPosition = cards[i].position;
            sequence.Append(cards[i].DOMove(firstCardPosition + offsetVector * i + Vector3.up * 30f , 0.3f));
            sequence.Append(cards[i].DOMove(firstCardPosition + offsetVector * i, 0.3f));
        }
    }
}
