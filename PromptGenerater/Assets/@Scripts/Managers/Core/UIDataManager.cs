using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Progress;

public class UIDataManager
{
    private string START = "/imagine prompt:";
    private string COMMA = ", ";

    private string FULLBODY = " Full body ";
    private string SOCKET_pose = "  ";
    private string CHARACTER = " Character ";

    private int COUNT_OPTION = 8;
    private string options = " ";

    private string setting_A = " --";
    private string setting_B = " --ar ";
    private string setting_C = " --s ";

    private string setting_Version;
    private string setting_Ratio;
    private string setting_Stylize;

    private string current_Preset = "Character Generate Mode";

    private string finalSentence = "is null";
    private string poseSentence = "is null";

    public UI_Setting Setting;
    //public UI_Preset Preset;
    public UI_Options Options;
    public UI_Generate Generate;

    public void Init()
    {
        Setting = GameObject.Find("UI_Setting").GetComponent<UI_Setting>();
        //Preset = GameObject.Find("UI_Preset").GetComponent<UI_Preset>();
        Options = GameObject.Find("UI_Options").GetComponent<UI_Options>();
        Generate = GameObject.Find("UI_Generate").GetComponent<UI_Generate>();
    }

    public void SetFinalSentence()
    {
        Refresh();

        finalSentence = START +
                        options +

                        setting_A + setting_Version +
                        setting_B + setting_Ratio +
                        setting_C + setting_Stylize;

        SetSentence();
    }

    public string GetFinalSentence()
    {
        return finalSentence;
    }

    private void Refresh()
    {
        setting_Version = Setting.GetCurrentVersion();
        setting_Ratio = Setting.GetCurrentRatio();
        setting_Stylize = Setting.GetCurrentStylize();
    }

    private void SetSentence()
    {
        Generate.SetSentence();
    }

}
