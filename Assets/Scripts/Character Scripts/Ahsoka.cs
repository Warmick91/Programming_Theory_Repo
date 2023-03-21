using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Characters
{
    public class Ahsoka : Character
    {
        // Start is called before the first frame update
        new void Start()
        {   
            base.Start();
            Debug.Log("Ahsoka's Start() works");
            UpdateInfo();
        }

        public override void SayLine()
        {
            Debug.Log("You Don't Have To Carry A Sword To Be Powerful.");
        }

        public override void UpdateInfo()
        {
            this.CharacterName = "Ahsoka Tano";
            this.Affinity = "Light Side";
            this.Species = "Togruta";
            this.Homeworld = "Shili";
            this.Born = "36 BBY";
            this.Died = "20 BBY (kinda)";
            base.UpdateInfo();
        }
    }
}
