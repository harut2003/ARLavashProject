using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toast : MonoBehaviour
{
    public GameObject handToast;
    
    
    void Start()
    {
        
    }

void Update()
    {

    }
    private void OnMouseDown()
    {
        if (Vector3.Distance(handToast.transform.position, transform.position) <= 10 && handToast.activeSelf == false)
        {
            UIGame.hint.text = "հիմա գնանք՝ գրտնակելու գունդը";
            gameObject.SetActive(false);
            handToast.SetActive(true);
        }
    }

    public void replaytoast_func()
    {
        Debug.Log("TURN_toast true");
        gameObject.SetActive(true);
        handToast.SetActive(false);
    }
    
}