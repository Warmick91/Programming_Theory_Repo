using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Characters
{
    public class JarJar : Character
    {
        new void Start()
        {
            base.Start();
            Debug.Log("Jar Jar's Start() works");
            characterLine = $"Meesa called Jar Jar Binks, {AppManager.UserName}!";
            UpdateInfo();
        }

        public override void UpdateInfo()
        {
            this.CharacterName = "Jar Jar Binks";
            this.Affinity = "Light Side";
            this.Species = "Gungan";
            this.Homeworld = "Naboo";
            this.Born = "52 BBY";
            this.Died = "Unknown";
            base.UpdateInfo();
        }
    }
}