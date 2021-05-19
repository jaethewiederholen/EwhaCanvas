using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    /* // 싱글톤 //
     */
    public static GameManager instance = null;
    public int[] spot_clear = new int[] { 0, 0, 0, 0, 0, 0, 0 }; // intance that I want to maintain

    private void Awake()
    {

        if (instance == null) //instance가 null. 즉, 시스템상에 존재하고 있지 않을때
        {
            instance = this; 
            getData();
            DontDestroyOnLoad(gameObject); //OnLoad(씬이 로드 되었을때) 자신을 파괴하지 않고 유지
        }
        else
        {
            if (instance != this) //instance가 내가 아니라면 이미 instance가 하나 존재하고 있다는 의미
                Destroy(this.gameObject); //둘 이상 존재하면 안되는 객체이니 방금 AWake된 자신을 삭제
        }
    }


    void saveData()
    {
        for (int i = 0; i < 7; i++)
        {
            PlayerPrefs.SetInt("SpotClear" + i, spot_clear[i]);
        }
        PlayerPrefs.Save();
    }

    void getData()
    {
        for (int i = 0; i < 7; i++)
        {
            spot_clear[i] = PlayerPrefs.GetInt("SpotClear" + i);
        }
    }
}