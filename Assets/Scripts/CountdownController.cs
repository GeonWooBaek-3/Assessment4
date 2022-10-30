using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class CountdownController : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 10f;

    [SerializeField] Text countdownText;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update() 
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = "Time Limit: " +  currentTime.ToString("0");

        countdownText.color = new Color(39f/255f, 240f/255f, 150f/255f);
             
        if(currentTime <= 0)
        {
            currentTime = 0;
        }
    }
}
