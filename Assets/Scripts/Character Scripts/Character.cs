using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Characters
{
    public abstract class Character : MonoBehaviour
    {
        // Info variables
        public string CharacterName { get ; protected set; }
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

        // Line to be quoted
        protected string characterLine;

        //Rotator variables
        public Quaternion initialRotation;
        private float turn;
        public float mouseSensitivity = 400f;

        // Finds all required game objects
        protected void Start()
        {
            Debug.Log("Character's Start() works");
            initialRotation = transform.localRotation;

            nameField = GameObject.Find("Name").GetComponent<TextMeshProUGUI>();
            affinityField = GameObject.Find("ForceAffinity").GetComponent<TextMeshProUGUI>();
            speciesField = GameObject.Find("Species").GetComponent<TextMeshProUGUI>();
            homeworldField = GameObject.Find("Homeworld").GetComponent<TextMeshProUGUI>();
            bornField = GameObject.Find("Born").GetComponent<TextMeshProUGUI>();
            diedField = GameObject.Find("Died").GetComponent<TextMeshProUGUI>();
        }

        void Update()
        {
            RotateCharacterOnClick();
        }

        void RotateCharacterOnClick()
        {
            if (Input.GetMouseButton(0))
            {
                turn += Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
                transform.localRotation = initialRotation * Quaternion.Euler(0, -turn, 0);
            }
        }

        void OnMouseDown()
        {
            turn += Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
            transform.localRotation = initialRotation * Quaternion.Euler(0, -turn, 0);
        }

        public IEnumerator SayLine()
        {
            ButtonManager buttonManager = GameObject.Find("ButtonManager").GetComponent<ButtonManager>();
            Debug.Log("ButtonManager object found and assigned");
            TextMeshProUGUI bubbleTextUGUI = buttonManager.bubbleText.GetComponent<TextMeshProUGUI>();
            Debug.Log("BubbleText's TMProUGUI found and assigned");
            bubbleTextUGUI.text = characterLine;

            buttonManager.darkSideBubble.SetActive(true);
            buttonManager.bubbleText.SetActive(true);

            yield return new WaitForSeconds(3);

            buttonManager.darkSideBubble.SetActive(false);
            buttonManager.bubbleText.SetActive(false);

        }

        // Resets the fields' values for the next character's info
        private void ResetInfo()
        {
            nameField.text = "Name: ";
            affinityField.text = "Force Affinity: ";
            speciesField.text = "Species: ";
            homeworldField.text = "Homeworld: ";
            bornField.text = "Born: ";
            diedField.text = "Died: ";
        }

        // Concatenates the info of the next character to the default fields' values set in ResetInfo();
        public virtual void UpdateInfo()
        {
            ResetInfo();
            nameField.text += CharacterName;
            affinityField.text += Affinity;
            speciesField.text += Species;
            homeworldField.text += Homeworld;
            bornField.text += Born;
            diedField.text += Died;
        }

    }
}