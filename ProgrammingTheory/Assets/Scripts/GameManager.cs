using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int score;
    public static GameManager instance;
    public GameObject[] shapes;
    private float posY = 15;
    private float posZ = 0;
    private float posX;
    private int shapeIndex;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnShapes", 2.0f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Another example of ABSTRACTIOn with custom methods
    void SpawnShapes()
    {
        Instantiate(shapes[RandomShapeIndex()], new Vector3(RandomXPos(), posY, posZ), Quaternion.identity);
    }

    public void IncreaseScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

    float RandomXPos()
    {
        posX = Random.Range(-8, 8);
        return posX;
    }

    int RandomShapeIndex()
    {
        shapeIndex = Random.Range(0, 3);
        return shapeIndex;
    }
}
