using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Characters
{
    public class MonCala : Character
    {
        new void Start()
        {
            base.Start();
            Debug.Log("Admiral Ackbar's Start() works");
            characterLine = $"It's a trap, {AppManager.UserName}!";
            UpdateInfo();
        }

        public override void UpdateInfo()
        {
            this.CharacterName = "Admiral Ackbar";
            this.Affinity = "Light Side";
            this.Species = "Mon Calamari";
            this.Homeworld = "Mon Cala";
            this.Born = "Unknown";
            this.Died = "34 ABY";
            base.UpdateInfo();
        }
    }
}