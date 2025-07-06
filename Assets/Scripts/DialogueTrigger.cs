using UnityEngine;
 
public class DialogueTrigger : MonoBehaviour, IInteractable {
 
    [SerializeField] DialogueManager dialogueManager;
    [SerializeField] Dialogue dialogue;
 
    public string GetDescription() {
        return "Talk";
    }
 
    public void Interact() {
        dialogueManager.BeginDialogue(dialogue);
    }
}