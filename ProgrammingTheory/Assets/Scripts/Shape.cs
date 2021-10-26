using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Shape : MonoBehaviour
{
    public TextMeshProUGUI textToDisplay;
    private string shapeName = "Shape";
    
    //Example of ENCAPSULATION
    public string ShapeName
    {
        get
        {
            return shapeName;
        }
        set
        {
            shapeName = value;
        }
    }

    int scoreToGive = 5;

    //Example of ENCAPSULATION
    public int ScoreToGive
    {
        get
        {
            return scoreToGive;
        }
        set
        {
            scoreToGive = value;
        }
    }

    private void Awake()
    {
        textToDisplay = GameObject.Find("GameLog").GetComponent<TextMeshProUGUI>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            DisplayText();
            BumpScore();
        }
        else if (collision.gameObject.tag == "Ground")
        {
            Destroy(gameObject);
        }
    }
    //ABSTRACTION
    public virtual void DisplayText()
    {
        textToDisplay.text = "Player caught: " + shapeName + " and received " + scoreToGive + " score";
    }

    //ABSTRACTION
    private void BumpScore()
    {
        GameManager.instance.IncreaseScore(scoreToGive);
    }
}
