using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TonirScript : MonoBehaviour
{
    public GameObject handLavash;
    public GameObject handReadyLavash;
    public GameObject tonirLavash;
    Animator animator;
    public GameObject canvas;
    public GameObject rafata;
    public GameObject chochlavashtexture;
    public static TonirScript instance;
    public Animator tonirlavash;
    public Texture cook;
    public Texture ready;
    public Texture burn;
    public GameObject[] gnder;
    public GameObject[] canvasColor;
    public static bool Cook;
    public static bool Ready;
    public static bool Burn;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        animator = canvas.GetComponent<Animator>();
        rafata.SetActive(false);
        canvas.SetActive(false);
    }

    void Update()
    {
        if (canvas.activeSelf)
        {
            if (animator.GetCurrentAnimatorStateInfo(0).IsName("Cook"))
            {
                UIGame.hint.fontSize = 52;
                UIGame.hint.text = "Այստեղ պետք է ուշադիր լինես ժամանակացույցին, որպեսզի չվառես խմորը";
                tonirLavash.GetComponent<Renderer>().material.mainTexture = cook;
            }
            else if (animator.GetCurrentAnimatorStateInfo(0).IsName("Ready"))
            {
                tonirLavash.GetComponent<Renderer>().material.mainTexture = ready;
            }
            else if (animator.GetCurrentAnimatorStateInfo(0).IsName("Burn"))
            {
                tonirLavash.GetComponent<Renderer>().material.mainTexture = burn;
            }
            else if (animator.GetCurrentAnimatorStateInfo(0).IsName("End"))
            {
                UIGame.hint.fontSize = 52;
                UIGame.hint.text = "Դու ամբողջությամբ վառեցիր խմորը, և միավոր չես ստանում, կրկին գունդ վերցրու";
                rafata.SetActive(false);
                canvas.SetActive(false);
                for (int i = 0; i < gnder.Length; i++)
                {
                    gnder[i].SetActive(true);
                }
            }
        }


    }
    private void OnMouseDown()
    {
        for (int i = 0; i < canvasColor.Length; i++)
        {
            canvasColor[i].SetActive(false);
        }
        if (handLavash.activeSelf && Vector3.Distance(handLavash.transform.position, transform.position) <= 20)
        {
            rafata.SetActive(true);
            tonirlavash.SetBool("bool", true);
            handLavash.SetActive(false);
            tonirLavash.SetActive(true);
            canvas.SetActive(true);
            animator.SetTrigger("Trigger");

        }
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Cook") || animator.GetCurrentAnimatorStateInfo(0).IsName("Ready") ||
            animator.GetCurrentAnimatorStateInfo(0).IsName("Burn"))
        {
            UIGame.hint.fontSize = 60;
            UIGame.hint.text = "Հիմա գնանք, լավաշը դիր ճոճանակին և իմացիր հավաքածդ միավորը";
        }
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Cook"))
        {
            
            rafata.SetActive(false);
            tonirLavash.SetActive(false);
            animator.Play("idle");
            canvas.SetActive(false);
            /*            handReadyLavash.GetComponent<MeshRenderer>().material.color = new Color(0.9103773f, 0.7342831f, 0.5522651f, 1);
            */
            handReadyLavash.SetActive(true);
            handReadyLavash.GetComponent<Renderer>().material.mainTexture = cook;
            chochlavashtexture.GetComponent<Renderer>().material.mainTexture = cook;
            Cook = true;
            Burn = false;
            Ready = false;
            
        }
        else if (animator.GetCurrentAnimatorStateInfo(0).IsName("Ready"))
        {
            rafata.SetActive(false);
            tonirLavash.SetActive(false);
            animator.Play("idle");
            canvas.SetActive(false);/*
            handReadyLavash.GetComponent<MeshRenderer>().material.color = new Color(0.82075f, 0.46857f, 0.10453f, 1);*/
            handReadyLavash.SetActive(true);
            handReadyLavash.GetComponent<Renderer>().material.mainTexture = ready;
            chochlavashtexture.GetComponent<Renderer>().material.mainTexture = ready;
            Ready = true;
            Cook = false;
            Burn = false;

        }
        else if (animator.GetCurrentAnimatorStateInfo(0).IsName("Burn"))
        {
            rafata.SetActive(false);
            tonirLavash.SetActive(false);
            animator.Play("idle");
            canvas.SetActive(false);
            /*            handReadyLavash.GetComponent<MeshRenderer>().material.color = new Color(0.48113f, 0.28106f, 0.065949f, 1);
            */
            handReadyLavash.SetActive(true);
            handReadyLavash.GetComponent<Renderer>().material.mainTexture = burn;
            chochlavashtexture.GetComponent<Renderer>().material.mainTexture = burn;
            Burn = true;
            Cook = false;
            Ready = false;
        }

    }
}