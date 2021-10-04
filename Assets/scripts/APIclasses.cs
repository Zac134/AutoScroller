using UnityEngine;


[System.Serializable]
public class JsonDate
{
    public ITEMS[] Items;

}

[System.Serializable]
public class ITEMS
{
    public ITEM Item;
}


[System.Serializable]
public class ITEM
{
    public string title;
    public int itemPrice;
    public string affiliateUrl;
    public string itemCaption;
    public string largeImageUrl;
}


public class APIclasses : MonoBehaviour
{


    /*void Start()
    {
        string json = Resources.Load<TextAsset>("楽天API").ToString();

        JsonDate jsonDate = JsonUtility.FromJson<JsonDate>(json);

        JsonUtility.FromJsonOverwrite(json, jsonDate);

        int i = 0;
        int o = 0;
        int p = 0;
        int l = 0;


        foreach (var item in jsonDate.Items)
        {


            Debug.Log("タイトル:" + jsonDate.Items[i++].Item.title);
            Debug.Log(jsonDate.Items[l++].Item.itemCaption);
            Debug.Log("価格:" + jsonDate.Items[o++].Item.itemPrice);
            Debug.Log("URL:" + jsonDate.Items[p++].Item.affiliateUrl);

        }





    }*/


}



