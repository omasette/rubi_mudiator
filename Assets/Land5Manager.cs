using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Land5Manager : MonoBehaviour
{
    //public Text nameText;
    public Text land5dialogueText;

    public Animator animator;

    private Queue<string> sentences;
    
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue <string>();   
    }

    public void StartLand5Dialogue( Land5Dialogue land5dialogue)
    {
        animator.SetBool("IsOpen", true);

        //Debug.Log("Starting conversation with " + landdialogue.name);
        //nameText.text = land5dialogue.name;

        sentences.Clear();

        foreach (string sentence in land5dialogue.sentences)
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
        land5dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            land5dialogueText.text += letter;
            yield return null;
        }
    }
                void EndDialogue()
        {
            //Debug.Log("End of conversation"); 
            animator.SetBool("IsOpen", false);
        }
    }
