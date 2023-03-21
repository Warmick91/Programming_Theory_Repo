using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    Button backButton;
    Button vaderButton;
    Button ahsokaButton;
    GameObject infoPanel;

    Vector3 showcasePosition = new Vector3(-1.4f, -0.05f, -19.3f);
    Vector3 showcaseRotation = new Vector3(0, -30, 0);
    GameObject currentCharacter;

    // Start is called before the first frame update
    void Start()
    {
        infoPanel = GameObject.Find("InfoPanel");
        if (currentCharacter == null)
        {
            infoPanel.SetActive(false);
        }

        backButton = GameObject.Find("BackButton").GetComponent<Button>();
        backButton.onClick.AddListener(GoBackToMenu);

        vaderButton = GameObject.Find("VaderButton").GetComponent<Button>();
        vaderButton.name = "vader";
        vaderButton.onClick.AddListener(() => LoadCharacter("vader"));

        ahsokaButton = GameObject.Find("AhsokaButton").GetComponent<Button>();
        ahsokaButton.name = "ahsoka";
        ahsokaButton.onClick.AddListener(() => LoadCharacter("ahsoka"));
    }

    // Loads a new character after a button is clicked
    void LoadCharacter(string buttonIdName)
    {
        if (currentCharacter != null) Destroy(currentCharacter);

        switch (buttonIdName)
        {
            case "ahsoka":
                currentCharacter = GameObject.Instantiate(AppManager.Instance.Characters()[0], showcasePosition, AppManager.Instance.Characters()[0].transform.rotation);
                break;
            case "vader":
                currentCharacter = GameObject.Instantiate(AppManager.Instance.Characters()[12], showcasePosition, AppManager.Instance.Characters()[12].transform.rotation);
                break;
            default:
                Debug.Log("No character chosen for instantiation");
                break;
        }
        infoPanel.SetActive(true);
    }

    // Update is called once per frame
    void GoBackToMenu()
    {
        AppManager.Instance.LoadTitleScene();
    }
}
