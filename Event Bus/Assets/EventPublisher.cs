using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventPublisher : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            EventBus.TriggerEvent("Shoot");
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            EventBus.TriggerEvent("Launch");
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            EventBus.TriggerEvent("makeSentient");
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            EventBus.TriggerEvent("Game");
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            EventBus.TriggerEvent("Hack");
        }
    }
}
