using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public float timeStart = 10;
    public Text textBox;
    [SerializeField] GameObject gameDoneMenu;
    public bool gameDone = false;
    public Score script;
    // Use this for initialization
    void Start()
    {
        textBox.text = "Time : " + timeStart.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
        timeStart -= Time.deltaTime;
        textBox.text = "Time : " + Mathf.Round(timeStart).ToString();
        if (Mathf.RoundToInt(timeStart) == 0)
        {
            gameDone = true;
            gameDoneMenu.SetActive(true);
            Time.timeScale = 0f;
        }else if (script.gameOver == true)
        {
            Time.timeScale = 0f;
        }
        //  else
        // {
        //     gameDone = false;
        //     gameDoneMenu.SetActive(false);
        //     Time.timeScale = 1f;
        // }
    }
}