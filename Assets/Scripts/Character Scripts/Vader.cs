using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Characters
{
    public class Vader : Character
    {

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public override void SayLine()
        {
            Debug.Log("I am altering the deal. Pray I don't alter it any further.");
        }

        public override void UpdateInfo()
        {

        }
    }
}