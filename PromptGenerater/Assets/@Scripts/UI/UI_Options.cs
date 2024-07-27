using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class UI_Options : UI_Base
{
    public UI_Option Option_01;
    public UI_Option Option_02;
    public UI_Option Option_03;
    public UI_Option Option_04;
    public UI_Option Option_05;
    public UI_Option Option_06;
    public UI_Option Option_07;
    public UI_Option Option_08;



    public override bool Init()
    {
        if (base.Init() == false)
            return false;

        Option_01 = GameObject.Find("Option_01").GetComponent<UI_Option>();
        Option_02 = GameObject.Find("Option_02").GetComponent<UI_Option>();
        Option_03 = GameObject.Find("Option_03").GetComponent<UI_Option>();
        Option_04 = GameObject.Find("Option_04").GetComponent<UI_Option>();
        Option_05 = GameObject.Find("Option_05").GetComponent<UI_Option>();
        Option_06 = GameObject.Find("Option_06").GetComponent<UI_Option>();
        Option_07 = GameObject.Find("Option_07").GetComponent<UI_Option>();
        Option_08 = GameObject.Find("Option_08").GetComponent<UI_Option>();

        return true;
    }
}
