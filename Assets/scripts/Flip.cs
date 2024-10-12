using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flip : MonoBehaviour
{
    public Button button;
    public GameObject player;
    public Material material;
    bool flipped = false;

    private void Start()
    {
        button.onClick.AddListener(Click);
    }

    private void Click()
    {
        Sequence cardSequence = DOTween.Sequence();
        Debug.Log("Click!");
        if(flipped == false)
        {
            cardSequence.Append(player.transform.DORotate(new Vector3(90, 116.5f, 0), 1f).SetEase(Ease.OutSine));
            cardSequence.Join(material.DOFade(0, 1f));
        }
        else
        {
            cardSequence.Append(player.transform.DORotate(new Vector3(90, 180, 0), 1f).SetEase(Ease.OutSine));
            cardSequence.Join(material.DOFade(1, 1f));
        }
        flipped = !flipped;
    }
}
