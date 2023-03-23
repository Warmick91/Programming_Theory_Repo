using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Characters
{
    public class BoKatan : Character
    {
        new void Start()
        {
            base.Start();
            Debug.Log("Bo-Katan's Start() works");
            characterLine = $"For Mandalore, {AppManager.UserName}!";
            UpdateInfo();
        }

        public override void UpdateInfo()
        {
            this.CharacterName = "Bo-Katan Kryze";
            this.Affinity = "Light Side";
            this.Species = "Human";
            this.Homeworld = "Mandalore";
            this.Born = "Unknown";
            this.Died = "Unknown";
            base.UpdateInfo();
        }
    }
}


