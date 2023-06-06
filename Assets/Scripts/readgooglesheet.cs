using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class readgooglesheet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator GetSheetData()
    {
        UnityWebRequest www = UnityWebRequest.Get("");
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log("ERROR:" + www.error);
        }
        else
        {
            string json = www.downloadHandler.text;
           
        }
    }
}
