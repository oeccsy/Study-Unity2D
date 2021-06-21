using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkManager : MonoBehaviour
{
    Dictionary<int, string[]> talkData;
    Dictionary<int, Sprite> portraitData;

    public Sprite[] portraitArr;

    void Awake()
    {
        talkData = new Dictionary<int, string[]>();
        portraitData = new Dictionary<int, Sprite>();
        GenerateData();
    }

    void GenerateData() //"text:portraitIndex"
    {
        talkData.Add(10, new string[] { "안녕?:0", "안녕안녕 안녕??:1" });
        talkData.Add(20, new string[] { "안녕?:0", "안녕안녕 안녕??:1" });
        talkData.Add(30, new string[] { "좋은 날씨다.:0" });
        talkData.Add(40, new string[] { "안좋은 날씨다.:0" });
        talkData.Add(50, new string[] { "그저 그런 날씨다.:0" });

        portraitData.Add(10+0, portraitArr[0]);
        portraitData.Add(10+1, portraitArr[1]);
        portraitData.Add(20+0, portraitArr[0]);
        portraitData.Add(20+1, portraitArr[1]);
        portraitData.Add(30, portraitArr[2]);
        portraitData.Add(40, portraitArr[3]);
        portraitData.Add(50, portraitArr[4]);
    }

    public string GetTalk(int id, int talkIndex)
    {
        if (talkIndex == talkData[id].Length)   //Text가 저장된 Index를 벗어나면 null값 return
            return null;

        return talkData[id][talkIndex];
    }

    public Sprite GetPortrait(int id, int portraitIndex)
    {
        return portraitData[id + portraitIndex];
    }
}
