using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ray : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        addPhysicsRaycaster();
    }


    // Update is called once per frame
    void addPhysicsRaycaster()
    {
        PhysicsRaycaster physicsRaycaster = GameObject.FindObjectOfType<PhysicsRaycaster>();

        if(physicsRaycaster == null)
        {
            Camera.main.gameObject.AddComponent<PhysicsRaycaster>();
        }
        
    }
}
