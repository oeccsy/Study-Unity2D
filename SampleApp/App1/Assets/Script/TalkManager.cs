using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkManager : MonoBehaviour
{
    Dictionary<int, string[]> talkData;

    void Awake()
    {
        talkData = new Dictionary<int, string[]>();
        GenerateData();
    }

    void GenerateData()
    {
        talkData.Add(0, new string[] { "안녕?", "안녕안녕 안녕??" });
        talkData.Add(1, new string[] { "안녕?", "안녕안녕 안녕??" });
        talkData.Add(2, new string[] { "좋은 날씨다." });
        talkData.Add(3, new string[] { "안좋은 날씨다." });
        talkData.Add(4, new string[] { "안녕?", "안녕안녕 안녕??" });
    }

    public string GetTalk(int id, int talkIndex)
    {
        if (talkIndex == talkData[id].Length)   //Text가 저장된 Index를 벗어나면 null값 return
            return null;

        return talkData[id][talkIndex];
    }
}
