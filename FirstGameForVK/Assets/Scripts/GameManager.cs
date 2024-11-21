using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Text txtScore;

    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int n)
    {
        score += n;
        ViewScore();
    }

    private void ViewScore()
    {
        txtScore.text = $"���� : {score}";
    }
}
