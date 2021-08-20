using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kadai: MonoBehaviour
{
    void Start()
    {
        var str = AddText("追加しました");
        Debug.Log(str);
    }

    private string AddText(string tsxt)
    {
        return "テキストを、" + tsxt;
    }
}
