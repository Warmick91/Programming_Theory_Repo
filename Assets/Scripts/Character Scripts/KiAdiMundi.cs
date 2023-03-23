using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Characters
{
    public class KiAdiMundi : Character
    {
        new void Start()
        {
            base.Start();
            Debug.Log("Ki-Adi-Mundi's Start() works");
            characterLine = $"The Force is strong with you, {AppManager.UserName}.";
            UpdateInfo();
        }

        public override void UpdateInfo()
        {
            this.CharacterName = "Ki-Adi-Mundi";
            this.Affinity = "Light Side";
            this.Species = "Cerean";
            this.Homeworld = "Cerea";
            this.Born = "92 BBY";
            this.Died = "19 BBY";
            base.UpdateInfo();
        }
    }
}