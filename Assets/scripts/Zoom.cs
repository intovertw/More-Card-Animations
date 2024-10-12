using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zoom : MonoBehaviour
{
    public Button button;
    public GameObject player;
    bool zoomed = false;

    private void Start()
    {
        button.onClick.AddListener(Click);
    }

    private void Click()
    {
        Sequence cardSequence = DOTween.Sequence();
        Debug.Log("Click!");
        if (zoomed == false)
        {
            cardSequence.Append(player.transform.DOScale(new Vector3(0, 1, 0), 0.5f).SetEase(Ease.InSine));
        }
        else
        {
            cardSequence.Append(player.transform.DOScale(new Vector3(0.508f, 1, 0.381f), 0.5f).SetEase(Ease.OutSine));
        }
        zoomed = !zoomed;
    }
}
