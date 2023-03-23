using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Characters
{
    public class CaraDune : Character
    {
        new void Start()
        {
            base.Start();
            Debug.Log("Cara Dune's Start() works");
            characterLine = $"I've seen worse, {AppManager.UserName}.";
            UpdateInfo();
        }

        public override void UpdateInfo()
        {
            this.CharacterName = "Cara Dune";
            this.Affinity = "Light Side";
            this.Species = "Human";
            this.Homeworld = "Alderaan";
            this.Born = "Unknown";
            this.Died = "Unknown";
            base.UpdateInfo();
        }
    }
}