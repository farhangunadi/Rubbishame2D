using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnTrash2 : MonoBehaviour
{
    [SerializeField] private GameObject[] Trash;

    private BoxCollider2D col;

    float x1, x2;
    // public Countdown script;
    void Awake()
    {
        col = GetComponent<BoxCollider2D>();

        x1 = transform.position.x - col.bounds.size.x / 2f;
        x2 = transform.position.x + col.bounds.size.x / 2f;
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnTrash(1f));
    }

    IEnumerator SpawnTrash(float time)
    {
        yield return new WaitForSecondsRealtime(time);

        Vector3 temp = transform.position;
        temp.x = Random.Range(x1, x2);
        if (SceneManager.GetActiveScene().name == "Game1")
        {
            Instantiate(Trash[Random.Range(0, Trash.Length)], temp, Quaternion.identity);

        
            StartCoroutine(SpawnTrash(Random.Range(1.5f, 2f)));
        } else if (SceneManager.GetActiveScene().name == "Game2")
        {
            Instantiate(Trash[Random.Range(0, Trash.Length)], temp, Quaternion.identity);

        
            StartCoroutine(SpawnTrash(Random.Range(1f, 1.5f)));
        }
        
    }

}
