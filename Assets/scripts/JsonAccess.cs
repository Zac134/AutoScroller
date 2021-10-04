using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonAccess : MonoBehaviour
{
    public GameObject books;

    void Start()
    {
        Application.OpenURL("https://app.rakuten.co.jp/services/api/BooksTotal/Search/20170404?format=json&keyword=%E3%83%93%E3%82%B8%E3%83%8D%E3%82%B9&booksGenreId=000&applicationId=1014804688685496747");

    }



}
