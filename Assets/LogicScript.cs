using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LogicScript : MonoBehaviour
{

    public Text myText;
    public int score = 0;

    [ContextMenu("Increment Score")]
    public void incrementScore() 
    {
        score++; updateScoreInUi();
    }
    public void addScore(int n) 
    {
        score+=n; updateScoreInUi();

    }
    public void setScore(int n)
    {
        score=n; updateScoreInUi();

    }
    public void updateScoreInUi() 
    {
        myText.text = score.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
