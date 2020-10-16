using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Task1 : MonoBehaviour
{
    private Transform _targetButton;

    public void Start()
    {
        _targetButton = transform;
    }

    public void OnClick()
    {
        var duration = 0.15f;
        
        var sequence = DOTween.Sequence();

        sequence.Append(_targetButton.DOScale(Vector3.one * 0.85f, duration));
        sequence.Join(_targetButton.DORotate(new Vector3(0f, 0f, -360f), duration, RotateMode.LocalAxisAdd));
        sequence.Append(_targetButton.DOScale(Vector3.one, duration));
    }
}
