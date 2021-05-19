using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;


public class SelectScene : MonoBehaviour
{
    public Sprite nonClear, clear;
    // ECC  MUSEUM  LARGE   MIDDLE  LIBRARY POSCO   GSM
    // 0    1       2       3       4       5       6   
    void Start()
    {
        string curr_name = this.gameObject.name;
        int index = 0;
        switch (curr_name)
        {
            case "ecc":
                index = 0;
                break;
            case "big":
                index = 2;
                break;
            case "gsm":
                index = 6;
                break;
            case "lib":
                index = 4;
                break;
            case "museum":
                index = 1;
                break;
            case "small":
                index = 3;
                break;
            case "posco":
                index = 5;
                break;
        }

        if (GameManager.instance.spot_clear[index] == 1)
        {
            gameObject.GetComponent<Image>().sprite = clear;

        }
    }
    public void playGame()
    {
        string name = EventSystem.current.currentSelectedGameObject.name;
        UnityEngine.Debug.Log(name);
        switch (name)
        {
            case "ecc":
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                break;
            case "big":
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
                break;
            case "gsm":
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
                break;
            case "lib":
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
                break;
            case "museum":
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
                break;
            case "small":
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
                break;
            case "posco":
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7);
                break;
        }
        
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
