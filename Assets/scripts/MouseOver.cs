using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOver : MonoBehaviour
{
    void OnMouseOver()
    {

        this.transform.localScale = new Vector3(4, 5.6f, 2);
        Debug.Log("We're on");

    }
    void OnMouseExit()
    {

        this.transform.localScale = new Vector3(2, 2.8f, 1);
        Debug.Log("out");

    }

}
