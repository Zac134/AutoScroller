using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class urlGet : MonoBehaviour
{
    [SerializeField] GameObject cube;

    void Start()
    {
        
        string json = Resources.Load<TextAsset>("楽天API").ToString();

        JsonDate jsonDate = JsonUtility.FromJson<JsonDate>(json);

        JsonUtility.FromJsonOverwrite(json, jsonDate);

    }
    void OnCollisionEnter(Collision collision)
    {
        string json = Resources.Load<TextAsset>("楽天API").ToString();
        JsonDate jsonDate = JsonUtility.FromJson<JsonDate>(json);

        Application.OpenURL(jsonDate.Items[0].Item.affiliateUrl);
        

        Debug.Log("mouse is over");

    }




}

