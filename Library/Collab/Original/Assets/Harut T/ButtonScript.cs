using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public GameObject Start_;
    public GameObject Score;
    public GameObject Cube;
    public GameObject life1;
    public GameObject life2;
    public GameObject life3;
    public GameObject button_life;
    bool score_bool = true;
    bool life_bool = false;
    public int score = 0;
    public int scoree = 0;
    // Start is called before the first frame update
    private void Awake()
    {
        Score.SetActive(false);
        life1.SetActive(false);
        life2.SetActive(false);
        life3.SetActive(false);
        button_life.SetActive(false);
    }
    void Start()
    {
        Score.GetComponent<Text>().text = "Score: " + score.ToString();
    }
    public void TurnOff()
    {
        Start_.SetActive(false);
        Score.SetActive(true);
        life1.SetActive(true);
        life2.SetActive(true);
        life3.SetActive(true);
        button_life.SetActive(true);
        /*Score.GetComponent<Text>().text = "Score" + score.ToString();*/
    }
    public void ForLife()
    {
        int health = 3;
        life1.SetActive(false);
        health--;
        if (health == 2)
        {
            life2.SetActive(false);
            health--;
        }
        else if (health == 1)
        {
            life3.SetActive(false);
            health--;
            button_life.GetComponent<Text>().text = "Game over";
        }

    }
    public void ForScore()
    {

        score+= scoree;
        Score.GetComponent<Text>().text = "Score: " + score.ToString();
        score_bool = false;
    }
        
        
    // Update is called once per frame
    void Update()
    {



        




    }
}
