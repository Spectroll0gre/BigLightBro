using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class TitleText : MonoBehaviour
{
    public TMP_Text textComponent;
    public string message;
    public float letterDelay = 0.1f;
    
    public void Start()
    {
        StartTyping();
    }

    public void StartTyping()
    {
        StartCoroutine(TypeTextCoroutine());
    }

    IEnumerator TypeTextCoroutine()
    {
        string displayedText = "";
        for (int i = 0; i < message.Length; i++)
        {
            displayedText += message[i];
            textComponent.text = displayedText;
            yield return new WaitForSeconds(letterDelay);
        }
    }
}