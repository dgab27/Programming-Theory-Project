using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Shape : MonoBehaviour
{
    private string shapeName = "Shape";

    public string Name
    {
        get
        {
            return shapeName;
        }
        set
        {
            name = value;
        }
    }

    int scoreToGive = 5;

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
    public TextMeshProUGUI textToDisplay;
    
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
        }
        else if (collision.gameObject.tag == "Ground")
        {
            Destroy(gameObject);
        }
    }

    private void DisplayText()
    {
        textToDisplay.text = "Player caught: " + shapeName + " and received " + scoreToGive + " score";
    }

}
