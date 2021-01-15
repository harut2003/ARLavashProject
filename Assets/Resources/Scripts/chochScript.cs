using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chochScript : MonoBehaviour
{
    public GameObject chochLavash;
    public GameObject handLavash;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseDown()
    {
        if (handLavash.activeSelf)
        {
            chochLavash.SetActive(true);
            handLavash.SetActive(false);
            
            if (TonirScript.Cook)
            {
                UIGame.scr += 50;
                UIGame.hint.fontSize = 47;
                UIGame.hint.text = "Դու հում թողեցիր խմորը և ստանում ես 50 միավոր!!\nԿարող ես վաճառել այն սեղմելով կարմիր կոճակը";
            }
            else if (TonirScript.Ready)
            {
                Debug.Log("mtela");
                UIGame.scr += 100;
                UIGame.hint.fontSize = 47;
                UIGame.hint.text = "Դու ճիշտ ժամանակին հանեցիր խմորը և ստանում ես 100 միավոր!! \nԿարող ես վաճառել այն սեղմելով կարմիր կոճակը";
            }
            else if (TonirScript.Burn)
            {
                UIGame.scr += 50;
                UIGame.hint.fontSize = 46;
                UIGame.hint.text = "Դու մասամբ վառեցիր խմորը և ստանում ես 50 միավոր!!\nԿարող ես վաճառել այն սեղմելով կարմիր կոճակը";
            }
        }
    }
}
