using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fly : MonoBehaviour
{
    public Button button;
    public GameObject player;
    bool moved = false;

    private void Start()
    {
        button.onClick.AddListener(Click);
    }

    private void Click()
    {
        Sequence cardSequence = DOTween.Sequence();
        Debug.Log("Click!");
        if(moved == false)
        {
            cardSequence.Append(player.transform.DOMoveX(2, 0.5f).SetEase(Ease.InBack));
        }
        else
        {
            cardSequence.Append(player.transform.DOMoveX(0.5f, 0.5f).SetEase(Ease.OutBack));
        }
        moved = !moved;
        
    }
}
