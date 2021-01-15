using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grtnakLavash : MonoBehaviour
{
    Animator grtn_anim;
    public GameObject gund;
    public GameObject table;
    Animator gund_anim;
    public Animator table_anim;
    static int countClick;
    
    private void OnMouseDown()
    {
        
        countClick++;
        /*gund_anim.SetBool("gund50", false);
        table_anim.SetBool("GundClick", false);
        gund_anim.SetBool("gund75", false);
        grtn_anim.SetBool("GrtnakClicked", false);
        grtn_anim.SetBool("GrtnakSecondClick", false);
        grtn_anim.SetBool("GrtnakThirdClick", false);*/
        table_anim.SetBool("first", false);
        table_anim.SetBool("second", false);
        table_anim.SetBool("third", false);
        if (countClick == 1)
        {
            table_anim.SetBool("first", true);
        }
        else if(countClick == 2)
        {
            /*gund_anim.SetBool("gund50", true);
            grtn_anim.SetBool("GrtnakClicked", false);
            grtn_anim.SetBool("GrtnakSecondClick", true);*/
            table_anim.SetBool("second", true);
            

        }
        else if(countClick == 3)
        {
            /*Debug.Log("3rd ifi mej");*/
            /*gund_anim.SetBool("gund75", true);
            grtn_anim.SetBool("GrtnakThirdClick", true);*/
            table_anim.SetBool("third", true);
            countClick = 0;
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    void Update()
    {
        gameObject.GetComponent<BoxCollider>().enabled = false;
        if (table_anim.GetCurrentAnimatorStateInfo(0).IsName("idle") || 
            table_anim.GetCurrentAnimatorStateInfo(0).IsName("firstidle") ||
            table_anim.GetCurrentAnimatorStateInfo(0).IsName("secondidle"))
        {
            if (gund.activeSelf)
            {
                gameObject.GetComponent<BoxCollider>().enabled = true;
            }
        }
        if (table_anim.GetCurrentAnimatorStateInfo(0).IsName("firstidle"))
        {
            UIGame.hint.text = "Եվս մեկ անգամ սեղմիր";
        }
        if (table_anim.GetCurrentAnimatorStateInfo(0).IsName("secondidle"))
        {
            UIGame.hint.text = "Գունդը լավ բացված չէ, կրկին փորձիր";
        }
        if (table_anim.GetCurrentAnimatorStateInfo(0).IsName("thirdidle"))
        {
            UIGame.hint.text = "ԱՊՐԵՍ!!!\nՀիմա սեղմիր գնդի վրա";
        }
        if (table_anim.GetCurrentAnimatorStateInfo(0).IsName("rafatidle"))
        {
            UIGame.hint.text = "Վերցնենք ռաֆատան և գնանք սեղմենք թոնիրին";
        }
    }
}
