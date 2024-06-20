using System;
using UnityEngine;

public class Helper
{
      public static bool StartGame
    {
        get => PlayerPrefs.GetInt(nameof(StartGame)) == 1;
        set => PlayerPrefs.SetInt(nameof(StartGame), value == true ? 1 : 0);
    }
    public static bool GameOver
    {
        get => PlayerPrefs.GetInt(nameof(GameOver)) == 1;
        set => PlayerPrefs.SetInt(nameof(GameOver), value == true ? 1 : 0);
    }   
}