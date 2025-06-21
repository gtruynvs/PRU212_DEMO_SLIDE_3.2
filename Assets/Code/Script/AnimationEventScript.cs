using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEventScript : MonoBehaviour
{
    public void AnimationEventFunction(string message)
    {
        Debug.Log("Animation event triggered: " + message);
        // Perform actions or call functions based on 'message'
    }
}

