using UnityEngine;

using TMPro;
public class DialogueLines : MonoBehaviour
{
    [SerializeField] string[] dialogueLines;
    [SerializeField] TMP_Text dialoguText;

    int currentLine = 0;

    public void NextDialogue()
    {
        currentLine++;
        dialoguText.text = dialogueLines[currentLine];
    }
}
