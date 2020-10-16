using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Task22 : MonoBehaviour
{
    [SerializeField] private Transform[] rects;
    
    public void OnClickEvent()
    {
        Sequence sequence = DOTween.Sequence();

        var smallScale = new Vector3(1f, 0.6f, 1f);
        var duration = 0.25f;

        foreach (var rect in rects)
        {
            sequence.Append(rect.DOScale(smallScale, duration));
        }
        
        foreach (var rect in rects)
        {
            sequence.Append(rect.DOScale(Vector3.one, duration));
        }
        
        sequence.OnComplete(OnClickEvent);
    }
}
