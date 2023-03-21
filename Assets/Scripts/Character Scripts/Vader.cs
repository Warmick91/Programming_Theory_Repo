using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Characters
{
    public class Vader : Character
    {
        // Start is called before the first frame update
        new void Start()
        {
            base.Start();
            Debug.Log("Vader's Start() works");
            characterLine = "I am altering the deal. Pray I don't alter it any further.";
            UpdateInfo();
        }

        public override void SayLine()
        {
            // Finding the button manager should be moved to the parent class
            ButtonManager buttonManager = GameObject.Find("ButtonManager").GetComponent<ButtonManager>();
            buttonManager.darkSideBubble.SetActive(true);
            buttonManager.bubbleText.SetActive(true);

            TextMeshProUGUI bubbleText = GameObject.Find("BubbleText").GetComponent<TextMeshProUGUI>();
            bubbleText.text = characterLine;
        }

        public override void UpdateInfo()
        {
            this.CharacterName = "Darth Vader";
            this.Affinity = "Dark Side";
            this.Species = "Human";
            this.Homeworld = "Tatooine";
            this.Born = "41 BBY";
            this.Died = "4 ABY";
            base.UpdateInfo();
        }
    }
}