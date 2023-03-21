using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

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

        // Fields variables
        private TextMeshProUGUI nameField;
        private TextMeshProUGUI affinityField;
        private TextMeshProUGUI speciesField;
        private TextMeshProUGUI homeworldField;
        private TextMeshProUGUI bornField;
        private TextMeshProUGUI diedField;


        // Start is called before the first frame update
        protected void Start()
        {
            Debug.Log("Character's Start() works");
            nameField = GameObject.Find("Name").GetComponent<TextMeshProUGUI>();
            affinityField = GameObject.Find("ForceAffinity").GetComponent<TextMeshProUGUI>();
            speciesField = GameObject.Find("Species").GetComponent<TextMeshProUGUI>();
            homeworldField = GameObject.Find("Homeworld").GetComponent<TextMeshProUGUI>();
            bornField = GameObject.Find("Born").GetComponent<TextMeshProUGUI>();
            diedField = GameObject.Find("Died").GetComponent<TextMeshProUGUI>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        public abstract void SayLine();

        public virtual void UpdateInfo()
        {
            nameField.text = nameField.text + CharacterName;
            affinityField.text = nameField.text + Affinity;
        }
    }
}