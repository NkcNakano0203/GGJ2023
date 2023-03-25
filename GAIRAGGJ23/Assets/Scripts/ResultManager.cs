using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultManager : MonoBehaviour
{
    [SerializeField]
    ResultCanvasController clearCanvas;
    [SerializeField]
    ResultCanvasController gameOverCanvas;

    void Start()
    {
        //TODO:�X�R�A�ƃN���A����𑼃N���X����Ⴄ
        bool gameClear = true;
        int score = 99999;

        clearCanvas.gameObject.SetActive(gameClear);
        gameOverCanvas.gameObject.SetActive(!gameClear);

        if (gameClear)
        {
            clearCanvas.OnStart(score);
        }
        else
        {
            gameOverCanvas.OnStart(score);
        }
    }
}