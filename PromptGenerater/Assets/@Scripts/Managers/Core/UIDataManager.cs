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

    private string Option_01;
    private string Option_02;
    private string Option_03;
    private string Option_04;
    private string Option_05;
    private string Option_06;
    private string Option_07;
    private string Option_08;

    private string Option_Sentence_Head_01;
    private string Option_Sentence_Head_02;
    private string Option_Sentence_Head_03;
    private string Option_Sentence_Head_04;
    private string Option_Sentence_Head_05;
    private string Option_Sentence_Head_06;
    private string Option_Sentence_Head_07;
    private string Option_Sentence_Head_08;

    private string Option_Sentence_Tail_01;
    private string Option_Sentence_Tail_02;
    private string Option_Sentence_Tail_03;
    private string Option_Sentence_Tail_04;
    private string Option_Sentence_Tail_05;
    private string Option_Sentence_Tail_06;
    private string Option_Sentence_Tail_07;
    private string Option_Sentence_Tail_08;

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
        finalSentence = START +
                        options +

                        Option_Sentence_Head_01 + " " + Option_01 + " " + Option_Sentence_Tail_01 +
                        Option_Sentence_Head_02 + " " + Option_02 + " " + Option_Sentence_Tail_02 +
                        Option_Sentence_Head_03 + " " + Option_03 + " " + Option_Sentence_Tail_03 +
                        Option_Sentence_Head_04 + " " + Option_04 + " " + Option_Sentence_Tail_04 +
                        Option_Sentence_Head_05 + " " + Option_05 + " " + Option_Sentence_Tail_05 +
                        Option_Sentence_Head_06 + " " + Option_06 + " " + Option_Sentence_Tail_06 +
                        Option_Sentence_Head_07 + " " + Option_07 + " " + Option_Sentence_Tail_07 +
                        Option_Sentence_Head_08 + " " + Option_08 + " " + Option_Sentence_Tail_08 +

                        setting_A + setting_Version +
                        setting_B + setting_Ratio +
                        setting_C + setting_Stylize;
    }

    public string GetFinalSentence()
    {
        return finalSentence;
    }

    public void Refresh()
    {
        setting_Version = Setting.GetCurrentVersion();
        setting_Ratio = Setting.GetCurrentRatio();
        setting_Stylize = Setting.GetCurrentStylize();

        SetOptions();

        SetFinalSentence();

        SetSentence();
    }

    public void SetOptions()
    {
        Options.SetSentences();

        Option_01 = Options.Option_01.GetAttributeOfTable();
        Option_02 = Options.Option_02.GetAttributeOfTable();
        Option_03 = Options.Option_03.GetAttributeOfTable();
        Option_04 = Options.Option_04.GetAttributeOfTable();
        Option_05 = Options.Option_05.GetAttributeOfTable();
        Option_06 = Options.Option_06.GetAttributeOfTable();
        Option_07 = Options.Option_07.GetAttributeOfTable();
        Option_08 = Options.Option_08.GetAttributeOfTable();

        Option_Sentence_Head_01 = Options.Option_01.GetTableNameSentenceHead();
        Option_Sentence_Head_02 = Options.Option_02.GetTableNameSentenceHead();
        Option_Sentence_Head_03 = Options.Option_03.GetTableNameSentenceHead();
        Option_Sentence_Head_04 = Options.Option_04.GetTableNameSentenceHead();
        Option_Sentence_Head_05 = Options.Option_05.GetTableNameSentenceHead();
        Option_Sentence_Head_06 = Options.Option_06.GetTableNameSentenceHead();
        Option_Sentence_Head_07 = Options.Option_07.GetTableNameSentenceHead();
        Option_Sentence_Head_08 = Options.Option_08.GetTableNameSentenceHead();

        Option_Sentence_Tail_01 = Options.Option_01.GetTableNameSentenceTail();
        Option_Sentence_Tail_02 = Options.Option_02.GetTableNameSentenceTail();
        Option_Sentence_Tail_03 = Options.Option_03.GetTableNameSentenceTail();
        Option_Sentence_Tail_04 = Options.Option_04.GetTableNameSentenceTail();
        Option_Sentence_Tail_05 = Options.Option_05.GetTableNameSentenceTail();
        Option_Sentence_Tail_06 = Options.Option_06.GetTableNameSentenceTail();
        Option_Sentence_Tail_07 = Options.Option_07.GetTableNameSentenceTail();
        Option_Sentence_Tail_08 = Options.Option_08.GetTableNameSentenceTail();
    }

    public void SetSentence()
    {
        Generate.SetSentence();
    }

}
