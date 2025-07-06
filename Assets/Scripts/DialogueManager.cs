using UnityEngine;
using TMPro;
using System.Collections;
using System.Text;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{

    [SerializeField]
    GameObject dialoguePanel;

    [SerializeField]
    TextMeshProUGUI dialogueText;

    [SerializeField]
    Button closeButton;

    public void BeginDialogue(Dialogue dialogue)
    {

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        dialoguePanel.SetActive(true);

        AnimateText(dialogue);
    }

    void AnimateText(Dialogue dialogue)
    {
        IEnumerator TypeText(string text)
        {
            StringBuilder textToShow = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                textToShow.Append(text[i]);
                dialogueText.text = textToShow.ToString();

                yield return new WaitForSeconds(1f / 20f);
            }
        }

        StartCoroutine(TypeText(dialogue.DialogueText));
    }

    public void CloseDialogue()
    {
        dialoguePanel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Start()
    {
        closeButton.onClick.AddListener(CloseDialogue);
        dialoguePanel.SetActive(false);
    }



}
