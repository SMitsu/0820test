using System.Collections.Generic;
using UnityEngine;
using System;

public class kadai5 : MonoBehaviour
{
    public enum Days
    {
        Monday,
        Tueday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    public Days days;
    private void Start()
    {
        Days nowDays = days;
        var nextDaysIndex = (5 - (int)nowDays);
        switch (days)
        {
            case Days.Monday:
            case Days.Tueday:
            case Days.Wednesday:
            case Days.Thursday:
            case Days.Friday:
                Debug.Log("平日です！休日まであと" + nextDaysIndex);
                break;
            default:
                Debug.Log("休日です");
                break;
        }
    }
}
