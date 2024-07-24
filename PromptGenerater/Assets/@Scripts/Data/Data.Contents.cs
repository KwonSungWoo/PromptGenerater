using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting;
using UnityEngine;

namespace Data
{
    #region CreatureData


    [Serializable]
    public class TableData
    {
        public int Number;
        public string Name;
        public int Favorites;
        public int Dislike;
        public int Appearances;
        public int Used;
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