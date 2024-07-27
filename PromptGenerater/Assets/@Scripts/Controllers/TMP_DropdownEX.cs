using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TMP_DropdownEX : TMP_Dropdown
{
    public Data.TableData TableData {  get; private set; }
    private List<string> data;

    #region Stats
    public int DataNumber { get; set; }
    public string CurrentItemName { get; set; } = "None";
    #endregion

    public void SetInfo()
    {
        DataNumber = TableData.Number;
        CurrentItemName = TableData.Name;
    }


    public void initDropdown(TMP_DropdownEX dropdown, Dictionary<int, Data.TableData> dict, int Default)
    {
        dropdown.options.Clear();

        for (int i = 0; i < dict.Count; i++)
        {
            dict.TryGetValue(i, out Data.TableData value);
            data.Add(value.Name);
        }

        foreach (string str in data)
        {
            dropdown.options.Add(new TMP_DropdownEX.OptionData(str));
        }


        //List<TMP_DropdownEX.OptionData> optionList = new List<TMP_DropdownEX.OptionData>();
        //
        //
        //foreach ( string srt in arrayClass)
        //{
        //    optionList.Add(new TMP_DropdownEX.OptionData(srt));
        //}
        //
        //dropdown.AddOptions(optionList);

        dropdown.value = Default;

        this.RefreshShownValue();
    }

}
