using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Characters
{
    public class Hera : Character
    {
        new void Start()
        {
            base.Start();
            Debug.Log("Hera's Start() works");
            characterLine = $"May the Force be with you, {AppManager.UserName}.";
            UpdateInfo();
        }

        public override void UpdateInfo()
        {
            this.CharacterName = "Hera Syndulla";
            this.Affinity = "Light Side";
            this.Species = "Twi'lek";
            this.Homeworld = "Ryloth";
            this.Born = "Unknown";
            this.Died = "Unknown";
            base.UpdateInfo();
        }
    }
}