using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Characters
{
    public class Mando : Character
    {
        new void Start()
        {
            base.Start();
            Debug.Log("Mando's Start() works");
            characterLine = $"This is the way, {AppManager.UserName}.";
            UpdateInfo();
        }

        public override void UpdateInfo()
        {
            this.CharacterName = "Din Djarin";
            this.Affinity = "Light Side";
            this.Species = "Human";
            this.Homeworld = "Unknown";
            this.Born = "Unknown";
            this.Died = "Unknown";
            base.UpdateInfo();
        }
    }
}