using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting;
using UnityEngine;

namespace Data
{
    #region TableData


    [Serializable]
    public class TableData
    {
        public int Number;
        public string Name;
    }

    [Serializable]
    public class TableDataLoader : ILoader<int, TableData>
    {
        public List<TableData> tables = new List<TableData>();

        public Dictionary<int, TableData> MakeDict()
        {
            Dictionary<int, TableData> dict = new Dictionary<int, TableData>();
            foreach (TableData table in tables)
                dict.Add(table.Number, table);
            return dict;
        }
    }
    #endregion

    #region TablesData


    [Serializable]
    public class TableSetData
    {
        public int Number;
        public string Name;
        public int Count;
        public string Scentence_Head;
        public string Scentence_Tail;
    }

    [Serializable]
    public class TableSetDataLoader : ILoader<int, TableSetData>
    {
        public List<TableSetData> tableSets = new List<TableSetData>();

        public Dictionary<int, TableSetData> MakeDict()
        {
            Dictionary<int, TableSetData> dict = new Dictionary<int, TableSetData>();
            foreach (TableSetData tableSet in tableSets)
                dict.Add(tableSet.Number, tableSet);
            return dict;
        }
    }
    #endregion

    #region Env
    [Serializable]
    public class EnvData
    {
        public int DataId;
        public string DescriptionTextID;
        public string PrefabLabel;
        public float MaxHp;
        public int ResourceAmount;
        public float RegenTime;
        public List<String> SkeletonDataIDs = new List<String>();
        public int DropItemId;
    }

    [Serializable]
    public class EnvDataLoader : ILoader<int, EnvData>
    {
        public List<EnvData> envs = new List<EnvData>();
        public Dictionary<int, EnvData> MakeDict()
        {
            Dictionary<int, EnvData> dict = new Dictionary<int, EnvData>();
            foreach (EnvData env in envs)
                dict.Add(env.DataId, env);
            return dict;
        }
    }
    #endregion
}