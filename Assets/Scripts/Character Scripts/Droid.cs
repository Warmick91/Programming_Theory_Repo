using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Characters
{
    public class Droid : Character
    {
        new void Start()
        {
            base.Start();
            Debug.Log("B1 Battle Droid's Start() works");
            characterLine = $"Roger, roger, {AppManager.UserName}.";
            UpdateInfo();
        }

        public override void UpdateInfo()
        {
            this.CharacterName = "B1 Battle Droid";
            this.Affinity = "Dark Side";
            this.Species = "Droid";
            this.Homeworld = "Geonosis";
            this.Born = "N/A";
            this.Died = "N/A";
            base.UpdateInfo();
        }
    }
}