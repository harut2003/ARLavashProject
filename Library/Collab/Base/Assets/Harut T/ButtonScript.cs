using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public GameObject Start_;
    public GameObject Score;
    public GameObject Cube;
    bool score_bool = true;
    public int score = 0;
    // Start is called before the first frame update
    private void Awake()
    {
        Score.SetActive(false);
    }
    void Start()
    {
        Score.GetComponent<Text>().text = "Score: " + score.ToString();
    }
    public void TurnOff()
    {
        Start_.SetActive(false);
        Score.SetActive(true);
        /*Score.GetComponent<Text>().text = "Score" + score.ToString();*/
    }
    
    // Update is called once per frame
    void Update()
    {
         void ForScore()
        {
            
            score++;
            Score.GetComponent<Text>().text = "Score: " + score.ToString();
            score_bool = false;
        }
        
        if (score_bool)
        {
            for (int i = 0; i < 15; i++)
            {
                ForScore();
            }
            
        }
        
        


    }
}
