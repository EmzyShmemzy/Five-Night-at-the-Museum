using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeycardBehavior : InteractableObject
{

public override void Interact(PlayerController player)
    {
        LevelManager.clearConditionSatisfied = true; 
        Destroy(gameObject);
    }
    override public string HoverTextMnK()
    {
        return "[F] to Collect Keycard";
    }
    public override string HoverTextController()
    {
        return "(Y) to Collect Keycard";
    }
}
