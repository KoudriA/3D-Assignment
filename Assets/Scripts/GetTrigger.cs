using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetTrigger : MonoBehaviour
{
    public int Score;

    void start()
    {
        Score = 3;
        Debug.Log(Score);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger: " + other.gameObject.name);
        Score += 1;
        Debug.Log(Score);
    }
}
