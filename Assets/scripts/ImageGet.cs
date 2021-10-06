using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class ImageGet : MonoBehaviour
{
    
    Texture texture;

    [SerializeField] Material material;
    [SerializeField] GameObject obj;



    void Start()
    {
        string shader = "Legacy Shaders/Diffuse";
        material.shader = Shader.Find(shader);
        StartCoroutine(Connect());
    

    }

    private IEnumerator Connect()
    {
        string json = Resources.Load<TextAsset>("楽天API").ToString();

        JsonDate jsonDate = JsonUtility.FromJson<JsonDate>(json);

        int objname = int.Parse(obj.name);

        string url = jsonDate.Items[objname].Item.largeImageUrl;

        UnityWebRequest www = UnityWebRequestTexture.GetTexture(url);

        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }

        else
        {
            texture = ((DownloadHandlerTexture)www.downloadHandler).texture;

            material.SetTexture("_MainTex", texture);

            gameObject.GetComponent<Renderer>().material = material;

        }


    }
    

}
