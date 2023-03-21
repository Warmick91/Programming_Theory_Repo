using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    Button backButton;
    Button vaderButton;
    Button ahsokaButton;

    Vector3 showcasePosition = new Vector3(-1.4f, -0.05f, -19.3f);
    Vector3 showcaseRotation = new Vector3(0, -30, 0);

    // Start is called before the first frame update
    void Start()
    {
        backButton = GameObject.Find("BackButton").GetComponent<Button>();
        backButton.onClick.AddListener(GoBackToMenu);

        vaderButton = GameObject.Find("VaderButton").GetComponent<Button>();
        vaderButton.name = "vader";

        ahsokaButton = GameObject.Find("AhsokaButton").GetComponent<Button>();
        ahsokaButton.name = "ahsoka";
        ahsokaButton.onClick.AddListener(() => LoadCharacter("ahsoka"));
    }

    // Update is called once per frame
    void GoBackToMenu()
    {
        AppManager.Instance.LoadTitleScene();
    }

    // Loads a new character after a button is clicked
    void LoadCharacter(string buttonIdName)
    {
        //TODO
        switch (buttonIdName)
        {   
            case "ahsoka":
                GameObject.Instantiate(AppManager.Instance.Characters()[0], showcasePosition, Quaternion.identity);
                break;
            case "vader":
                break;
            default:
                Debug.Log("No character chosen for instantiation");
                break;
        }
    }
}
