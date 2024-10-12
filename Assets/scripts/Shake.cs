using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shake : MonoBehaviour
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
        cardSequence.Append(player.transform.DOPunchPosition(new Vector3(player.transform.position.x, 0, 0), 1f, 10, 0.01f));
        cardSequence.Append(player.transform.DOMoveX(0.5f, 0.1f));
    }
}
