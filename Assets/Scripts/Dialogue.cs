using System.Collections.Generic;
using UnityEngine;
 
[CreateAssetMenu(menuName = "New Dialogue", fileName = "New Dialogue")]
public class Dialogue : ScriptableObject {

    [SerializeField] string dialogueText;
 
    public string DialogueText {
        get {
            return dialogueText;
        }
    }
}