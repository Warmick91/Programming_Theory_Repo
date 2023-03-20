using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MenuUI : MonoBehaviour
{
    Button startButton;

    void Awake()
    {
        startButton = GameObject.Find("Start Button").GetComponent<Button>();
        startButton.onClick.AddListener(OnStartButtonClicked);
    }

    void OnStartButtonClicked()
    {
        AppManager.Instance.LoadMainScene();
    }
}
