using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Characters;

public class ButtonManager : MonoBehaviour
{
    Button backButton;
    Button sayLineButton;

    // Characters buttons
    Button vaderButton;
    Button ahsokaButton;
    Button groguButton;
    Button ackbarButton;
    Button mandoButton;
    Button bokatanButton;
    Button jarjarButton;
    Button heraButton;
    Button kiadiButton;
    Button droidButton;
    Button caraButton;
    Button stormtrooperButton;
    Button obiwanButton;


    GameObject infoPanel;
    public GameObject darkSideBubble { get; set; }
    public GameObject bubbleText { get; set; }


    Vector3 showcasePosition = new Vector3(-1.4f, -0.05f, -19.3f);
    Vector3 showcaseRotation = new Vector3(0, -30, 0);
    GameObject currentCharacter;

    // Start is called before the first frame update
    void Start()
    {
        infoPanel = GameObject.Find("InfoPanel");
        infoPanel.SetActive(false);

        darkSideBubble = GameObject.Find("DarkSideBubble");
        darkSideBubble.SetActive(false);

        bubbleText = GameObject.Find("BubbleText");
        bubbleText.SetActive(false);

        backButton = GameObject.Find("BackButton").GetComponent<Button>();
        backButton.onClick.AddListener(GoBackToMenu);

        sayLineButton = GameObject.Find("LineButton").GetComponent<Button>();
        sayLineButton.onClick.AddListener(() => RequestLine());

        vaderButton = GameObject.Find("VaderButton").GetComponent<Button>();
        vaderButton.name = "vader";
        vaderButton.onClick.AddListener(() => LoadCharacter("vader"));

        ahsokaButton = GameObject.Find("AhsokaButton").GetComponent<Button>();
        ahsokaButton.name = "ahsoka";
        ahsokaButton.onClick.AddListener(() => LoadCharacter("ahsoka"));

        groguButton = GameObject.Find("GroguButton").GetComponent<Button>();
        groguButton.name = "grogu";
        groguButton.onClick.AddListener(() => LoadCharacter("grogu"));

        ackbarButton = GameObject.Find("AckbarButton").GetComponent<Button>();
        ackbarButton.name = "ackbar";
        ackbarButton.onClick.AddListener(() => LoadCharacter("ackbar"));

        mandoButton = GameObject.Find("MandoButton").GetComponent<Button>();
        mandoButton.name = "mando";
        mandoButton.onClick.AddListener(() => LoadCharacter("mando"));

        bokatanButton = GameObject.Find("BoKatanButton").GetComponent<Button>();
        bokatanButton.name = "bokatan";
        bokatanButton.onClick.AddListener(() => LoadCharacter("bokatan"));

        jarjarButton = GameObject.Find("JarJarButton").GetComponent<Button>();
        jarjarButton.name = "jarjar";
        jarjarButton.onClick.AddListener(() => LoadCharacter("jarjar"));

        heraButton = GameObject.Find("HeraButton").GetComponent<Button>();
        heraButton.name = "hera";
        heraButton.onClick.AddListener(() => LoadCharacter("hera"));

        kiadiButton = GameObject.Find("KiAdiButton").GetComponent<Button>();
        kiadiButton.name = "kiadi";
        kiadiButton.onClick.AddListener(() => LoadCharacter("kiadi"));

        droidButton = GameObject.Find("DroidButton").GetComponent<Button>();
        droidButton.name = "droid";
        droidButton.onClick.AddListener(() => LoadCharacter("droid"));

        caraButton = GameObject.Find("CaraButton").GetComponent<Button>();
        caraButton.name = "cara";
        caraButton.onClick.AddListener(() => LoadCharacter("cara"));

        stormtrooperButton = GameObject.Find("StormtrooperButton").GetComponent<Button>();
        stormtrooperButton.name = "stormtrooper";
        stormtrooperButton.onClick.AddListener(() => LoadCharacter("stormtrooper"));

        obiwanButton = GameObject.Find("ObiwanButton").GetComponent<Button>();
        obiwanButton.name = "obiwan";
        obiwanButton.onClick.AddListener(() => LoadCharacter("obiwan"));
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

    void GoBackToMenu()
    {
        AppManager.Instance.LoadTitleScene();
    }

    // Make the character say a line
    void RequestLine()
    {
        if (currentCharacter != null)
        {
            Character characterComponent = currentCharacter.GetComponent<Character>();
            if (characterComponent != null)
            {
                StartCoroutine(characterComponent.SayLine());
            }
            else
            {
                Debug.LogWarning("The instantiated object does not have a Character component.");
            }
        }
        else
        {
            Debug.LogWarning("No character is instantiated");
        }

    }
}
