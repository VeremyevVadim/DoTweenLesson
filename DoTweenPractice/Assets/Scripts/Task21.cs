using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Task21 : MonoBehaviour
{
    [SerializeField] private Transform[] circles;

    public void OnClickEvent()
    {
        Sequence sequence = DOTween.Sequence();

        var distance = 15f;
        var duration = 0.5f;
        var position = circles[0].position;
        sequence.Append(circles[1].DOMove(position + Vector3.right * distance, duration));
        sequence.Join(circles[2].DOMove(position + Vector3.right * distance * 2, duration));
        sequence.Append(circles[1].DOMove(position - Vector3.right * distance, duration));
        sequence.Join(circles[2].DOMove(position - Vector3.right * distance * 2, duration));
        sequence.Append(circles[1].DOMove(position, duration));
        sequence.Join(circles[2].DOMove(position, duration));
        sequence.OnComplete(OnClickEvent);
    }
}
