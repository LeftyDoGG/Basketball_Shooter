using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject effectOb;
    private int currentScore;
    public Text scoreText;
  

    void Start()
    {
        effectOb.SetActive(false);
        currentScore = 0;

    }
    void Update()
    {
        scoreText.text = "Score:" + currentScore;
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Bas")
        {
            effectOb.SetActive(true);
            currentScore += 1;
        }
 
    }

   
}
