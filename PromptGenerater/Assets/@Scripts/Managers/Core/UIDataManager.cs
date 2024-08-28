using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class UIDataManager
{
    #region Parameters
    private string START = "/imagine prompt:";
    private string COMMA = ", ";

    private int COUNT_OPTION = 8;

    private string Head_setting_Version = " --";
    private string Head_setting_Ratio = " --ar ";
    private string Head_setting_Stylize = " --s ";
    private string Head_Reference_Sref = " --sref ";
    private string Head_Reference_Cref = " --cref ";

    private string Reference_Sref;
    private string Reference_Cref;

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


    #endregion

    public UI_Setting Setting;
    //public UI_Preset Preset;
    public UI_Options Options;
    public UI_Generate Generate;
    public UI_References References;

    public void Init()
    {
        Setting = GameObject.Find("UI_Setting").GetComponent<UI_Setting>();
        //Preset = GameObject.Find("UI_Preset").GetComponent<UI_Preset>();
        Options = GameObject.Find("UI_Options").GetComponent<UI_Options>();
        Generate = GameObject.Find("UI_Generate").GetComponent<UI_Generate>();
        References = GameObject.Find("UI_References").GetComponent<UI_References>();
    }

    public void Refresh()
    {
        setting_Version = Setting.GetCurrentVersion();
        setting_Ratio = Setting.GetCurrentRatio();
        setting_Stylize = Setting.GetCurrentStylize();

        Reference_Sref = References.GetSref();
        Reference_Cref = References.GetCref();

        SetOptions();

        SetFinalSentence();

        SetSentence();
    }

    public void SetFinalSentence()
    {
        finalSentence = START +

                        Option_Sentence_Head_01 + " " + Option_01 + " " + Option_Sentence_Tail_01 + " " + 
                        Option_Sentence_Head_02 + " " + Option_02 + " " + Option_Sentence_Tail_02 + " " + 
                        Option_Sentence_Head_03 + " " + Option_03 + " " + Option_Sentence_Tail_03 + " " + 
                        Option_Sentence_Head_04 + " " + Option_04 + " " + Option_Sentence_Tail_04 + " " + 
                        Option_Sentence_Head_05 + " " + Option_05 + " " + Option_Sentence_Tail_05 + " " + 
                        Option_Sentence_Head_06 + " " + Option_06 + " " + Option_Sentence_Tail_06 + " " + 
                        Option_Sentence_Head_07 + " " + Option_07 + " " + Option_Sentence_Tail_07 + " " + 
                        Option_Sentence_Head_08 + " " + Option_08 + " " + Option_Sentence_Tail_08 + " " +

                        Head_setting_Version + setting_Version +
                        Head_setting_Ratio + setting_Ratio +
                        Head_setting_Stylize + setting_Stylize +

                        Head_Reference_Sref + Reference_Sref +
                        Head_Reference_Cref + Reference_Cref;
    }

    public string GetFinalSentence()
    {
        return finalSentence;
    }

    public void SetOptions()
    {
        Options.SetOptionSentences();

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

    public void Shuffle()
    {
        Options.Option_01.ShuffleDropdown(Options.Option_01.Dropdown_AttributeOfTable);
        Options.Option_02.ShuffleDropdown(Options.Option_02.Dropdown_AttributeOfTable);
        Options.Option_03.ShuffleDropdown(Options.Option_03.Dropdown_AttributeOfTable);
        Options.Option_04.ShuffleDropdown(Options.Option_04.Dropdown_AttributeOfTable);
        Options.Option_05.ShuffleDropdown(Options.Option_05.Dropdown_AttributeOfTable);
        Options.Option_06.ShuffleDropdown(Options.Option_06.Dropdown_AttributeOfTable);
        Options.Option_07.ShuffleDropdown(Options.Option_07.Dropdown_AttributeOfTable);
        Options.Option_08.ShuffleDropdown(Options.Option_08.Dropdown_AttributeOfTable);

        //Setting.ShuffleDropdown(Setting.dropdwon_Ratio);
        //Setting.ShuffleDropdown(Setting.dropdwon_Stylize);
    }

}
