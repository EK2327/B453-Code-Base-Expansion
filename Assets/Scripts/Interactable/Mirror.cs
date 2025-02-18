using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror : Interactable
{
    public override void DoInteract(Vector3 direction)
    {
        if (!isTriggered)
        {
            isTriggered = true;
            MyEvents.MirrorTouched.Invoke();
            Destroy(gameObject);
        }
    }
}
