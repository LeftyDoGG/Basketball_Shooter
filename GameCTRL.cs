using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameCTRL : MonoBehaviour
{
    public Player player;
    public float resetTime = 5f;

    void Start()
    {
        
    }

    void Update()
    {
        if (player.holdingBas == false)
        {
            resetTime -= Time.deltaTime;
            if (resetTime <= 0)
            {
                SceneManager.LoadScene("Basketballshooter");
            }
        }
    }
}
