using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnumTest : MonoBehaviour
{
    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    public Season season;
    private void Start()
    {
        Season nowSeason = season;
        var nextSeasonIndex = ((int)nowSeason + 1) % 4;
        Season nextSeason = (Season)Enum.ToObject(typeof(Season), nextSeasonIndex % 4);
        Debug.Log("今の季節は" + season + "," + "次の季節は" + (nextSeason) + "です");
    }
}
