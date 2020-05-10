using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LandIManager : MonoBehaviour
{
    //public Text nameText;
    public Text landIdialogueText;

    public Animator animator;

    private Queue<string> sentences;
    
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue <string>();   
    }

    public void StartLandIDialogue( LandIDialogue landIdialogue)
    {
        animator.SetBool("IsOpen", true);

        //Debug.Log("Starting conversation with " + landdialogue.name);
        //nameText.text = landdialogue.name;

        sentences.Clear();

        foreach (string sentence in landIdialogue.sentences)
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
        landIdialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            landIdialogueText.text += letter;
            yield return null;
        }
    }
                void EndDialogue()
        {
            //Debug.Log("End of conversation"); 
            animator.SetBool("IsOpen", false);
        }
    }
