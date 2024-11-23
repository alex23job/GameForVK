using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Text txtScore;
    [SerializeField] private Text txtAvatar;
    [SerializeField] private Text txtDebug;

    private int score = 0;
    public int Score { get { return score; } }
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
        txtScore.text = $"Очки : {score}";
    }

    public void ViewAvatar(string name)
    {
        txtAvatar.text = name;
    }

    public void ViewDebug(string zn)
    {
        txtDebug.text = zn;
    }
}
