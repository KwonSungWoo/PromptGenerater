using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TMP_DropdownEX : TMP_Dropdown
{
    public Data.TableData TableData {  get; private set; }

    #region Stats
    public int DataNumber { get; set; }
    public string CurrentItemName { get; set; } = "None";
    #endregion

    public void SetInfo()
    {
        DataNumber = TableData.Number;
        CurrentItemName = TableData.Name;
    }


    public void initDropdown(Dictionary<int, Data.TableData> dict, int Default)
    {
        this.options.Clear();

        List<TMP_DropdownEX.OptionData> optionList = new List<TMP_DropdownEX.OptionData>();

        string[] arrayClass = new string[dict.Count];
        for (int i = 0; i < dict.Count; i++)
        {
            dict.TryGetValue(i, out Data.TableData value);
            arrayClass.SetValue(value, i);
        }
        

        foreach ( string srt in arrayClass)
        {
            optionList.Add(new TMP_DropdownEX.OptionData(srt));
        }

        this.AddOptions(optionList);

        this.value = Default;

        this.RefreshShownValue();
    }

}
