using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class ResultManager : MonoBehaviour
{
    [SerializeField]
    RectTransform clearCanvasRect;
    [SerializeField]
    RectTransform gameOverCanvasRect;

    [SerializeField]
    TextMeshProUGUI clearScoreTxt;
    [SerializeField]
    TextMeshProUGUI gameOverTxt;

    float moveBeforePosY = 1024;

    void Start()
    {
        bool gameClear = true;
        int score = 00000;

        if (gameClear)
        {
            clearCanvasRect.gameObject.SetActive(true);
            gameOverCanvasRect.gameObject.SetActive(false);

            clearCanvasRect.DOAnchorPosY(moveBeforePosY, 0f);
            clearCanvasRect.DOAnchorPosY(0, 1f).SetEase(Ease.OutBounce);
            clearScoreTxt.text = $"{score}";
        }
        else
        {
            gameOverCanvasRect.gameObject.SetActive(true);
            clearCanvasRect.gameObject.SetActive(false);

            gameOverCanvasRect.DOAnchorPosY(moveBeforePosY, 0f);
            gameOverCanvasRect.DOAnchorPosY(0, 1f).SetEase(Ease.OutBounce);
            gameOverTxt.text = $"{score}";
        }
    }
}