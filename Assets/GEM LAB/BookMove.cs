using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BookMove : MonoBehaviour
{
    public GameObject bookshelve;
    public TextMesh text1;
    public TextMesh text2;



    public void Movement()
    {
        bookshelve.transform.position = new Vector3(10, 0, 5);
        text1.gameObject.SetActive(false);
        text2.gameObject.SetActive(true);

    }
}
