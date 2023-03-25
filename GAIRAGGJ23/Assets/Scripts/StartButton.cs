using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    Button button;

    //TODO:ゲーム本編のシーン名に変える
    const string GameSceneName = "";

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(GameStart);
    }

    private void GameStart()
    {
        SceneManager.LoadScene(GameSceneName);
    }
}