using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Characters
{
    public class Grogu : Character
    {
        // Start is called before the first frame update
        new void Start()
        {
            base.Start();
            Debug.Log("Grogu's Start() works");
            characterLine = $"Baba guguwawa gugu, dada{AppManager.UserName}!";
            UpdateInfo();
        }

        public override void UpdateInfo()
        {
            this.CharacterName = "Grogu";
            this.Affinity = "Light Side";
            this.Species = "Unknown";
            this.Homeworld = "Coruscant (presumably)";
            this.Born = "41 BBY";
            this.Died = "N/A";
            base.UpdateInfo();
        }
    }
}