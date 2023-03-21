using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

[DefaultExecutionOrder(-1)]
public class AppManager : MonoBehaviour
{
    [SerializeField] GameObject[] characters;
    public GameObject[] Characters()
    {
        return characters;
    }

    private static AppManager instance;
    public static AppManager Instance
    {
        get
        {
            return instance;
        }
    }
    private static string userName;
    public static string UserName
    {
        get
        {
            return userName;
        }
        set
        {
            userName = value;
        }
    }

    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void LoadMainScene()
    {
        SceneManager.LoadScene("MainScene");
        Debug.Log("The current username is: " + userName);
    }

    public void LoadTitleScene()
    {
        SceneManager.LoadScene("TitleScene");
    }

    public void SaveUserName(string name)
    {
        UserName = name;
    }

}
