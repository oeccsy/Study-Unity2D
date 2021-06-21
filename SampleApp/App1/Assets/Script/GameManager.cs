using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TalkManager talkManager;
    public Text talkText;
    public int talkIndex;

    public GameObject scanObject;
    public bool isAction =false ;
    public GameObject talkPanel;
    

    public void Action(GameObject scanObj)
    {

        scanObject = scanObj;
        ObjectData objData = scanObject.GetComponent<ObjectData>();
        Talk(objData.id, objData.isNpc);        //id, isnpc 정보로 text에 적절한 값 저장
        talkPanel.SetActive(isAction);          //isAction값에 따라 말풍선 On/Off

    }

    void Talk(int id, bool isNpc)
    {
        string talkData = talkManager.GetTalk(id, talkIndex);

        if(talkData == null)    //talkData이 null값이면 말풍선 Off
        {
            isAction = false;
            talkIndex = 0;
            return;
        }

        if(isNpc)
        {
            talkText.text = talkData;
        }
        else
        {
            talkText.text = talkData;

        }

        isAction = true;
        talkIndex++;
    }
}
