using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
 
public class PlayerInteraction : MonoBehaviour {
 
    public Camera mainCam;
    public float interactionDistance = 2f;
 
    public GameObject interactionUI;
    public TextMeshProUGUI interactionText;
 
 
    private void Update() {
        InteractionRay();
    }
 
    void InteractionRay() {
        Ray ray = mainCam.ViewportPointToRay(Vector3.one/2f);
        RaycastHit hit;
 
        bool hitSomething = false;
 
        if (Physics.Raycast(ray, out hit, interactionDistance)) {
            IInteractable interactable = hit.collider.GetComponent<IInteractable>();
 
            if (interactable != null) {
                hitSomething = true;
                interactionText.text = interactable.GetDescription();
 
                if (Input.GetKeyDown(KeyCode.E)) {
                    interactable.Interact();
                }
            }
        }
 
        interactionUI.SetActive(hitSomething);
    }
}
