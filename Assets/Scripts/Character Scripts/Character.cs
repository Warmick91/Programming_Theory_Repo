using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Characters
{
    public abstract class Character : MonoBehaviour
    {
        // Info variables
        public string CharacterName { get; protected set; }
        public string Affinity { get; protected set; }
        public string Species { get; protected set; }
        public string Homeworld { get; protected set; }
        public string Born { get; protected set; }
        public string Died { get; protected set; }

        // 


        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public abstract void SayLine();

        public abstract void UpdateInfo();
    }
}