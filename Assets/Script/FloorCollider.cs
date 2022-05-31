using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FloorCollider : MonoBehaviour
{

    public Score script;
    public Score2 script2;
    // Start is called before the first frame update
    void Start()
    {
        // script.scoreNum = 0;
        // script.MyScoreText.text = "Score : " + script.scoreNum;
    }

    private void OnTriggerEnter2D(Collider2D trash)
    {
        if (SceneManager.GetActiveScene().name == "Game1" || SceneManager.GetActiveScene().name == "Game2")
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
        } else if (SceneManager.GetActiveScene().name == "Game3" || SceneManager.GetActiveScene().name == "Game4")
        {
            if (trash.tag == "Organic") //kondisi sampah sesuai
            {
                script2.health--;
                script2.healthBar[script2.counter--].SetActive(false);
                Destroy(trash.gameObject);
                // script2.MyScoreText.text = "Score : " + script2.scoreNum;
            }
            else if (trash.tag == "Anorganic") //kondisi sampah tidak sesuai
            {
                // scoreNum--;
                Destroy(trash.gameObject);
                // MyScoreText.text = "Score : " + scoreNum;

            }
            // EndScore.text = "Score : " + scoreNum;
        }
        
    }
}