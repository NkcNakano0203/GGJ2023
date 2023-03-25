using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExitButton : MonoBehaviour
{
    Button button;
    const string TitleScene = "TitleScene";

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(Exit);
    }

    private void Exit()
    {
        SceneManager.LoadScene(TitleScene);
    }
}