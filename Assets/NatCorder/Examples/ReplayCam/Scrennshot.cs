using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using NatSuite;
using NatSuite.Sharing;

public class Scrennshot : MonoBehaviour
{
    private Texture2D texture;
    private int CurrentScreenshot { get => PlayerPrefs.GetInt("ScreenShot"); set => PlayerPrefs.SetInt("ScreenShot", value); }
    public RawImage rawtex;
    private void Start()
    {
        var folder = Directory.CreateDirectory(Application.persistentDataPath + "Screenshot"); // returns a DirectoryInfo object
        Debug.Log(Application.persistentDataPath);
        //var file = File.Create("path/to/your/file"); // returns a FileInfo object
    }
    private void Update()
    {
     
    }

    public void Screenn()
    {
        StartCoroutine(TakeScreenshot());
    }


    IEnumerator TakeScreenshot()
    {
        yield return new WaitForEndOfFrame();
        texture = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
        texture.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0, false);
        texture.Apply();
        yield return new WaitForEndOfFrame();
        rawtex.texture = texture;
        var payload = new SavePayload();
        payload.AddImage(texture);
        payload.Commit();
    }
}
