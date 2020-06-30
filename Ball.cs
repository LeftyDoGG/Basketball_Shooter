using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject effectBas;

    void Start()
    {
        effectBas.SetActive (false);

    }

    public void ActiveEffectBas()
    {
        effectBas.SetActive(true);
    }
}
