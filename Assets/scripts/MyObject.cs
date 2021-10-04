using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System.Runtime.InteropServices;


public class MyObject : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] GameObject any;

#if !UNITY_EDITOR && UNITY_WEBGL
    [DllImport("__Internal")]
    private static extern void OpenNewTab(string url);
#else

    private static void OpenNewTab(string url) => Application.OpenURL(url);

#endif

    public void OnPointerClick(PointerEventData eventData)
    {
        string json = Resources.Load<TextAsset>("楽天API").ToString();

        JsonDate jsonDate = JsonUtility.FromJson<JsonDate>(json);

        int objname = int.Parse(any.name);

        string url = jsonDate.Items[objname].Item.affiliateUrl;

        OpenNewTab(url);
    }

}
