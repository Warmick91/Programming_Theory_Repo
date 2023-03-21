using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Characters
{
    public class Vader : Character
    {
        // Start is called before the first frame update
        new void Start()
        {
            base.Start();
            Debug.Log("Vader's Start() works");
            UpdateInfo();
        }
        
        public override void SayLine()
        {
            Debug.Log("I am altering the deal. Pray I don't alter it any further.");
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