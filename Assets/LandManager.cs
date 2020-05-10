using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LandManager : MonoBehaviour
{
    //public Text nameText;
    public Text landdialogueText;

    public Animator animator;

    private Queue<string> sentences;
    
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue <string>();   
    }

    public void StartLandDialogue( LandDialogue landdialogue)
    {
        animator.SetBool("IsOpen", true);

        //Debug.Log("Starting conversation with " + landdialogue.name);
        //nameText.text = landdialogue.name;

        sentences.Clear();

        foreach (string sentence in landdialogue.sentences)
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
        landdialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            landdialogueText.text += letter;
            yield return null;
        }
    }
                void EndDialogue()
        {
            //Debug.Log("End of conversation"); 
            animator.SetBool("IsOpen", false);
        }
    }
