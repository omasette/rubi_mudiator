using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public property dialogue;
    public void TriggerDialogue ()
    {
        FindObjectOfType<PropManager>().StartDialogue(dialogue);
    }

    public prop conversation;
    public void TriggerDialogue1 ()
    {
        FindObjectOfType<PropManager1>().StartDialogue1(conversation);
    }

    public LandDialogue landdialogue;
    public void TriggerLandDialogue()
    {
        FindObjectOfType<LandManager>().StartLandDialogue(landdialogue);
    }

    public Land2Dialogue land2dialogue;
    public void TriggerLand2Dialogue()
    {
        FindObjectOfType<Land2Manager>().StartLand2Dialogue(land2dialogue);
    }

    public Land3Dialogue land3dialogue;
    public void TriggerLand3Dialogue()
    {
        FindObjectOfType<Land3Manager>().StartLand3Dialogue(land3dialogue);
    }

    public Land4Dialogue land4dialogue;
    public void TriggerLand4Dialogue()
    {
        FindObjectOfType<Land4Manager>().StartLand4Dialogue(land4dialogue);
    }

    public LandIDialogue landIdialogue;
    public void TriggerLandIDialogue()
    {
        FindObjectOfType<LandIManager>().StartLandIDialogue(landIdialogue);
    }


    public Land5Dialogue land5dialogue;
    public void TriggerLand5Dialogue()
    {
        FindObjectOfType<Land5Manager>().StartLand5Dialogue(land5dialogue);
    }

    public Level2Dialogue level2dialogue;
    public void TriggerLevel2Dialogue()
    {
        FindObjectOfType<Level2Manager>().StartLevel2Dialogue(level2dialogue);
    }
}
