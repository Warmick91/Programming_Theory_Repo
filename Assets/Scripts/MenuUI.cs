using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class MenuUI : MonoBehaviour
{
    Button startButton;
    TextMeshPro nameInput;

    void Awake()
    {
        nameInput = GameObject.Find("Name Input").GetComponentInChildren<TextMeshPro>();

        startButton = GameObject.Find("Start Button").GetComponent<Button>();
        startButton.onClick.AddListener(OnStartButtonClicked);
    }

    void OnStartButtonClicked()
    {
        if (nameInput == null)
        {
            Debug.Log("DUPA");
            return;
        }
        AppManager.Instance.SaveUserName(nameInput.text);
        AppManager.Instance.LoadMainScene();
    }
}
