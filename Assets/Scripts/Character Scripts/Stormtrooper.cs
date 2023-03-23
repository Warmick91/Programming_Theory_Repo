using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Characters
{
    public class Stormtrooper : Character
    {
        new void Start()
        {
            base.Start();
            Debug.Log("Stormtrooper's Start() works");
            characterLine = $"Move along, {AppManager.UserName}.";
            UpdateInfo();
        }

        public override void UpdateInfo()
        {
            this.CharacterName = "Stormtrooper";
            this.Affinity = "Dark Side";
            this.Species = "Human";
            this.Homeworld = "Various";
            this.Born = "N/A";
            this.Died = "N/A";
            base.UpdateInfo();
        }
    }
}