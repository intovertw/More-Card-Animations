using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pulse : MonoBehaviour
{
    public Button button;
    public GameObject player;

    private void Start()
    {
        button.onClick.AddListener(Click);
    }

    private void Click()
    {
        Sequence cardSequence = DOTween.Sequence();
        Debug.Log("Click!");
        cardSequence.Append(player.transform.DOScale(new Vector3(0.4064f, 1, 0.3048f), 0.3f).SetEase(Ease.OutSine));
        cardSequence.Append(player.transform.DOScale(new Vector3(0.508f, 1, 0.381f), 0.3f).SetEase(Ease.OutSine));
    }
}
