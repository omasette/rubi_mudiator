using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level2Manager : MonoBehaviour
{
    //public Text nameText;
    public Text level2dialogueText;

    public Animator animator;

    private Queue<string> sentences;
    
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue <string>();   
    }

    public void StartLevel2Dialogue( Level2Dialogue level2dialogue)
    {
        animator.SetBool("IsOpen", true);

        //Debug.Log("Starting conversation with " + landdialogue.name);
        //nameText.text = land5dialogue.name;

        sentences.Clear();

        foreach (string sentence in level2dialogue.sentences)
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
        level2dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            level2dialogueText.text += letter;
            yield return null;
        }
    }
                void EndDialogue()
        {
            //Debug.Log("End of conversation"); 
            animator.SetBool("IsOpen", false);
        }
    }
