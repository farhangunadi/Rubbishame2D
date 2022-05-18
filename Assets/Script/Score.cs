using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text MyScoreText;
    private int scoreNum;
    // Start is called before the first frame update
    void Start()
    {
        scoreNum = 0;
        MyScoreText.text = "Score : " + scoreNum;
    }

    private void OnTriggerEnter2D(Collider2D trash)
    {
        if (trash.tag == "Anorganic")
        {
            scoreNum++;
            Destroy(trash.gameObject);
            MyScoreText.text = "Score : " + scoreNum;
        }
        else if (trash.tag == "Organic")
        {
            scoreNum--;
            Destroy(trash.gameObject);
            MyScoreText.text = "Score : " + scoreNum;

        }
    }
}