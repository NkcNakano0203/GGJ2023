using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;
using UnityEngine.EventSystems;

public class ResultCanvasController : MonoBehaviour
{
    [SerializeField]
    RectTransform canvasRect;

    [SerializeField]
    TextMeshProUGUI clearScoreTxt;

    [SerializeField]
    EventSystem eventSystem;

    [SerializeField]
    Button selectButton;

    float moveBeforePosY = 1024;

    public void OnStart(int score)
    {
        eventSystem.SetSelectedGameObject(selectButton.gameObject);
        clearScoreTxt.text = $"{score}";
        Vector3 beforePos = new Vector3(0, moveBeforePosY, 0);
        canvasRect.DOAnchorPos(beforePos, 0f);
        canvasRect.DOAnchorPosY(0, 1.5f).SetEase(Ease.OutElastic);
    }
}