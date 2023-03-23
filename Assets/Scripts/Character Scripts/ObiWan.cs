using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Characters
{
    public class ObiWan : Character
    {
        new void Start()
        {
            base.Start();
            Debug.Log("Obi-Wan's Start() works");
            characterLine = $"Hello there, {AppManager.UserName}.";
            UpdateInfo();
        }

        public override void UpdateInfo()
        {
            this.CharacterName = "Obi-Wan Kenobi";
            this.Affinity = "Light Side";
            this.Species = "Human";
            this.Homeworld = "Stewjon";
            this.Born = "57 BBY";
            this.Died = "0 BBY";
            base.UpdateInfo();
        }
    }
}