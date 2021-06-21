using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TalkManager talkManager;
    public Text talkText;
    public int talkIndex = 0;
    public Image portraitImg;

    public GameObject scanObject;
    public bool isAction =false ;
    public GameObject talkPanel;
    

    public void Action(GameObject scanObj)
    {
        scanObject = scanObj;
        ObjectData objData = scanObject.GetComponent<ObjectData>();
        Talk(objData.id);                       //id 정보로 text에 적절한 값 저장
        talkPanel.SetActive(isAction);          //isAction값에 따라 말풍선 On/Off
    }
    
    void Talk(int id)
    {
        string talkData = talkManager.GetTalk(id, talkIndex);

        if(talkData == null)    //talkData이 null값이면 말풍선 Off
        {
            isAction = false;
            talkIndex = 0;
            return;
        }

        talkText.text = talkData.Split(':')[0];     //talkData를 :를 기준으로 구분한 문자열 배열의 0번째 Index를 가져온다.
        Debug.Log(Convert.ToInt32(talkData.Split(':')[1]));
        portraitImg.sprite = talkManager.GetPortrait(id, Convert.ToInt32(talkData.Split(':')[1]));

        isAction = true;
        talkIndex++;
    }
}
