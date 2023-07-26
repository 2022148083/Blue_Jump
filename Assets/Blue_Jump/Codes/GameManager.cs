using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    static public bool playerDie = false;   

    public float pipeTime = 2f;
    public float pipeMin = -1f;
    public float pipeMax = 1f;

    public GameObject pipePrefab;

    static public int score = 0;
    public Text ScoreText;

    void Start()
    {
        StartCoroutine(PipeStart());
    }

    void Update()
    {
        ScoreText.text = score.ToString();
    }

    IEnumerator PipeStart()
    {
        do
        {
            Instantiate(pipePrefab,
                new Vector3(3.5f, Random.Range(pipeMin, pipeMax), 0),
                Quaternion.Euler(new Vector3(0, 0, 0)));

            yield return new WaitForSeconds(pipeTime);
        } while (!playerDie);
    }
  
}
