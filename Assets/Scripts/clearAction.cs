using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class clearAction : MonoBehaviour
{
    public void playGame()
    {
        string curr_name = SceneManager.GetActiveScene().name;
        switch (curr_name)
        {
            // ECC  MUSEUM  LARGE   MIDDLE  LIBRARY POSCO   GSM
            // 0    1       2       3       4       5       6   
            case "ECC":
                GameManager.instance.spot_clear[0] = 1;
                saveData();
                break;
            case "LARGE":
                GameManager.instance.spot_clear[2] = 1;
                saveData();
                break;
            case "GSM":
                GameManager.instance.spot_clear[6] = 1;
                saveData();
                break;
            case "LIBRARY":
                GameManager.instance.spot_clear[4] = 1;
                saveData();
                break;
            case "MUSEUM":
                GameManager.instance.spot_clear[1] = 1;
                saveData();
                break;
            case "MIDDLE":
                GameManager.instance.spot_clear[3] = 1;
                saveData();
                break;
            case "POSCO":
                GameManager.instance.spot_clear[5] = 1;
                saveData();
                break;
        }

        //string name = EventSystem.current.currentSelectedGameObject.name;
        //UnityEngine.Debug.Log(name);
        SceneManager.LoadScene("Menu");

    }
    void saveData()
    {
        for (int i = 0; i < 7; i++)
        {
            PlayerPrefs.SetInt("SpotClear" + i, GameManager.instance.spot_clear[i]);
        }
        PlayerPrefs.Save();
    }
}