using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Land4Manager : MonoBehaviour
{
    //public Text nameText;
    public Text land4dialogueText;

    public Animator animator;

    private Queue<string> sentences;
    
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue <string>();   
    }

    public void StartLand4Dialogue( Land4Dialogue land4dialogue)
    {
        animator.SetBool("IsOpen", true);

        //Debug.Log("Starting conversation with " + landdialogue.name);
        //nameText.text = landdialogue.name;

        sentences.Clear();

        foreach (string sentence in land4dialogue.sentences)
             {
                  sentences.Enqueue(sentence);
             }
              DisplayNextSentence();            
    }
        public void DisplayNextSentence()
           {
              if (sentences.Count == 0)
                 {
                    EndDialogue();
                    return;
                 }
                 string sentence = sentences.Dequeue();
                StopAllCoroutines();
                StartCoroutine(TypeSentence(sentence));
                //Debug.Log(sentence);
                //landdialogueText.text = sentence;
           }
        IEnumerator TypeSentence (string sentence)
    {
        land4dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            land4dialogueText.text += letter;
            yield return null;
        }
    }
                void EndDialogue()
        {
            //Debug.Log("End of conversation"); 
            animator.SetBool("IsOpen", false);
        }
    }
