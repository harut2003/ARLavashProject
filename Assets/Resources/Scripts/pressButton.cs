using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressButton : MonoBehaviour
{
    public Animator animator;
    public GameObject readyLavash;
    public GameObject gund1;
    public GameObject gund2;
    public GameObject gund3;
    public GameObject gund4;


    void Start()
    {

    }

    void Update()
    {
        if (gund1.activeSelf && gund2.activeSelf && gund3.activeSelf && gund4.activeSelf)
        {
            gund1.GetComponent<SphereCollider>().enabled = true;
            gund2.GetComponent<SphereCollider>().enabled = true;
            gund3.GetComponent<SphereCollider>().enabled = true;
            gund4.GetComponent<SphereCollider>().enabled = true;
        }
        else
        {
            gund1.GetComponent<SphereCollider>().enabled = false;
            gund2.GetComponent<SphereCollider>().enabled = false;
            gund3.GetComponent<SphereCollider>().enabled = false;
            gund4.GetComponent<SphereCollider>().enabled = false;
        }
    }
    private void OnMouseDown()
    {
        animator.SetTrigger("trig");
        if (readyLavash.activeSelf)
        {
            UIGame.isFirst = false;
        
            readyLavash.SetActive(false);
            gund1.SetActive(true);
            gund2.SetActive(true);
            gund3.SetActive(true);
            gund4.SetActive(true);
        }
        /* * 
        else if (readyLavash.activeSelf && TonirScript.readyLavashState == "Ready")
        {
            readyLavash.SetActive(false);
            gund1.SetActive(true);
            gund2.SetActive(true);
            gund3.SetActive(true);
            gund4.SetActive(true);

        }
        else if (readyLavash.activeSelf && TonirScript.readyLavashState == "Burn")
        {
            readyLavash.SetActive(false);
            gund1.SetActive(true);
            gund2.SetActive(true);
            gund3.SetActive(true);
            gund4.SetActive(true);
        }*/
    }
}