using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;


public class BonusBtnAction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        int count = 0;
        for (int i = 0; i < 7; i++)
        {
            if (GameManager.instance.spot_clear[i] == 1)
                count++;

        }
        if (count == 7)
            gameObject.SetActive(true);
    }

    // Update is called once per frame
    public void playGame()
    {
        SceneManager.LoadScene("Hidden");
    }
}
