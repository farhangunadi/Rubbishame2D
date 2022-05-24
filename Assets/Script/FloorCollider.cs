using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloorCollider : MonoBehaviour
{

    public Score script;
    // Start is called before the first frame update
    void Start()
    {
        // script.scoreNum = 0;
        // script.MyScoreText.text = "Score : " + script.scoreNum;
    }

    private void OnTriggerEnter2D(Collider2D trash)
    {
        if (trash.tag == "Anorganic") //kondisi sampah sesuai
        {
            script.health--;
            script.healthBar[script.counter--].SetActive(false);
            Destroy(trash.gameObject);
            // script.MyScoreText.text = "Score : " + script.scoreNum;
        }
        else if (trash.tag == "Organic") //kondisi sampah tidak sesuai
        {
            // scoreNum--;
            Destroy(trash.gameObject);
            // MyScoreText.text = "Score : " + scoreNum;

        }
        // EndScore.text = "Score : " + scoreNum;
    }
}