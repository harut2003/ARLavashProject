using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIGame : MonoBehaviour
{
    public GameObject BlueImage;
    public GameObject Text;
    public static UIGame instance;
    public static Text hint;
    public Text Score;
    public static int scr = 0;
    public static bool isFirst = false;
    private void Awake()
    {
        instance = this;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        hint = Text.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (!isFirst) 
        {
            Text.SetActive(false);
            BlueImage.SetActive(false);
        }
        else
        {
            Text.SetActive(true);
            BlueImage.SetActive(true);
        }
        Score.text = scr.ToString();
    }
}
