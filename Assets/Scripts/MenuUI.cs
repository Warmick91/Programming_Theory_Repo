using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class MenuUI : MonoBehaviour
{
    Button startButton;
    TMP_InputField nameInput;

    void Awake()
    {
        nameInput = GameObject.Find("Name Input").GetComponentInChildren<TMP_InputField>();

        startButton = GameObject.Find("Start Button").GetComponent<Button>();
        startButton.onClick.AddListener(OnStartButtonClicked);
    }

    void OnStartButtonClicked()
    {
        if (nameInput.text.Equals(""))
        {
            Debug.Log("Enter your name first!");
            return;
        }
        AppManager.Instance.SaveUserName(nameInput.text);

        AppManager.Instance.LoadMainScene();
    }
}
