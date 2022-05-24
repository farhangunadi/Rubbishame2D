using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text MyScoreText;
    public Text EndScoreGameOver;
    public Text EndScoreGameDone;
    private int scoreNum;

    public int health = 3;
    [SerializeField] GameObject gameOverMenu;
    [SerializeField] public GameObject[] healthBar;
    public bool gameOver = false;
    public int counter = 2;
    // Start is called before the first frame update
    void Start()
    {
        scoreNum = 0;
        MyScoreText.text = "Score : " + scoreNum;
        // arrayCounter = healthBar.Length - 1;
    }

    private void OnTriggerEnter2D(Collider2D trash)
    {
        if (trash.tag == "Anorganic") //kondisi sampah sesuai
        {
            scoreNum++;
            Destroy(trash.gameObject);
            MyScoreText.text = "Score : " + scoreNum;
        }
        else if (trash.tag == "Organic") //kondisi sampah tidak sesuai
        {
            // scoreNum--;
            Destroy(trash.gameObject);
            health--;
            healthBar[counter--].SetActive(false);
            // MyScoreText.text = "Score : " + scoreNum;

        }
        EndScoreGameDone.text = "Score : " + scoreNum;
        EndScoreGameOver.text = "Score : " + scoreNum;
    }

    void Update(){
        if (health == 0)
        {
            gameOver = true;
            gameOverMenu.SetActive(true);
            Time.timeScale = 0f;
        } 
        // else {
        //     gameOver = false;
        //     gameOverMenu.SetActive(false);
        //     Time.timeScale = 1f;
        // }
    }
}