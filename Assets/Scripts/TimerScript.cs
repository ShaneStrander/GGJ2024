using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    public float TimeLeft;

    public Text timerText;

    public GameObject BreakText;
    public GameObject DoneText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (TimeLeft > 0)
        {
            TimeLeft -= Time.deltaTime;
            updateTimer(TimeLeft);
        }
        else
        {
            TimeLeft = 0;
            BreakText.SetActive(false);
            DoneText.SetActive(true);
            Invoke("NextLevel", 2.0f);
    }

        void updateTimer(float currentTime)
        {
            currentTime += 1;

            float seconds = Mathf.FloorToInt(currentTime % 60);

            timerText.text = string.Format("{0:00}", seconds);
        }
    }
    public void NextLevel()
    {
        SceneManager.LoadScene("Terminal");
    }
}
