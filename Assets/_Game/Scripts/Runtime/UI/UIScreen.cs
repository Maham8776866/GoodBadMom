using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScreen : MonoBehaviour
{
    public GameObject MainScreen;
    public GameObject LosingScreen;
    public GameObject WinningScreen;


    public void Awake()
    {
        MainScreen.SetActive(true);

    }
    public void Start()
    {
     
        Time.timeScale = 0f;

    }

    public void onStart()
    {
        MainScreen.SetActive(false);
        WinningScreen.SetActive(false);
        LosingScreen.SetActive(false);
       
    }

    public void winning()
    {
        MainScreen.SetActive(false);
        WinningScreen.SetActive(true);
        LosingScreen.SetActive(false);
       
    }

    public void losing()
    {
        MainScreen.SetActive(false);
        WinningScreen.SetActive(false);
        LosingScreen.SetActive(true);

    }
    public void mainscreen() { 
    
        SceneManager.LoadScene(0);
    }
    public void playbtn()
    {
        MainScreen.SetActive(false);
        WinningScreen.SetActive(false);
        LosingScreen.SetActive(false);
        Time.timeScale = 1f;

    }
    public void stopTime()
    {
        Time.timeScale = 0f;
    }

    public void startTime()
    {
        Time.timeScale = 1f;
     
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(0);

        Time.timeScale = 1f;

    }

    public void screen()
    {
        MainScreen.SetActive(false);
    }
    /* public GameObject MainScreen;
     public GameObject GamePlayScreen;
     public GameObject WinScreen;


     public void Start()
     {
         MainScreen.SetActive(true);
         GamePlayScreen.SetActive(false);
         WinScreen.SetActive(false);

     }


     public void OnStart()
     {
         MainScreen.SetActive(false);
         GamePlayScreen.SetActive(true);
         StartTime();
     }

     public void OnExit()
     {

         GamePlayScreen.SetActive(false);
         MainScreen.SetActive(true);


     }

     public void Winning()
     {
         GamePlayScreen.SetActive(false);
         WinScreen.SetActive(true);

     }

     public void StopTime()
     {
         Time.timeScale = 0f;
     }
     public void StartTime()
     {
         Time.timeScale = 1f;

     }

     public void RestartScene()
     {
         SceneManager.LoadScene(0);


     }
 */


}
