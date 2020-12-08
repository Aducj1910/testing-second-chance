using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestDialogue : MonoBehaviour
{

    [SerializeField]public string sentence;
    public Text dialogueText;

    public void SendSignal()
    {
       dialogueText.text = sentence;
    }
    public void RevertSignal()
    {
        dialogueText.text = "";
    }
}
