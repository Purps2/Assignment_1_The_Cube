using UnityEngine;

public class ScoreTracker : MonoBehaviour
{
    int score;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = 1;
        Debug.Log("Score at the Start: )" + score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
