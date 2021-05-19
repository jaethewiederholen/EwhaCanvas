using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class IntroBtnAction : MonoBehaviour
{
    public void loadPrologue()
    {
        Instantiate(Resources.Load("Prefabs/Prologue"), new Vector3(0, 0, 0), Quaternion.identity);
    }
    public void playGame()
    {
        string name = EventSystem.current.currentSelectedGameObject.name;
        UnityEngine.Debug.Log(name);
        switch (name)
        {
            case "start":
                SceneManager.LoadScene("Menu");
                break;
            case "prologue":
                loadPrologue();
                break;
         
        }

        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
