using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Globalization;

public class Dialogue : MonoBehaviour
{

    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;

    private int index;
    void Start()
    {
        textComponent.text = string.Empty;
        StartDialogue();
        
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            NextLine();
        }
        else if (textComponent.text == lines[index])
        {
            StopAllCoroutines();
            textComponent.text = lines[index];
         
        }
        
    }

    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());

    }

    IEnumerator TypeLine()
    {

        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        if (index < lines.Length -1)
        {

            if (textComponent.text == lines[index])
            {

                index++;
                textComponent.text = string.Empty;
                StartCoroutine(TypeLine());

            }

            else {

                StopAllCoroutines();
                textComponent.text = lines[index];

            }


        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
