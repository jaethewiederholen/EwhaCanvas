using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;


public class SelectMenu : MonoBehaviour
{
    public void playGame()
    {
        string name = EventSystem.current.currentSelectedGameObject.name;
        UnityEngine.Debug.Log(name);
        switch (name)
        {
            case "eccBtn":
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                break;
            case "bigBtn":
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
                break;
            case "gsmBtn":
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
                break;
            case "libBtn":
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
                break;
            case "museumBtn":
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
                break;
            case "smallBtn":
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
                break;
            case "poscoBtn":
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7);
                break;
        }

        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
