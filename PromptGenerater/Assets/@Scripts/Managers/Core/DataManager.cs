using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ILoader<key, value>
{
    Dictionary<key, value> MakeDict();
}

public class DataManager
{

    public Dictionary<int, Data.TableData> AnimalDic { get; private set; } = new Dictionary<int, Data.TableData>();
    public Dictionary<int, Data.TableData> RatioDic { get; private set; } = new Dictionary<int, Data.TableData>();
    public Dictionary<int, Data.TableData> StylizeDic { get; private set; } = new Dictionary<int, Data.TableData>();
    public Dictionary<int, Data.TableData> VersionDic { get; private set; } = new Dictionary<int, Data.TableData>();
    //public Dictionary<int, Data.EnvData> EnvDic { get; private set; } = new Dictionary<int, Data.EnvData>();

    public void Init()
    {
        AnimalDic = LoadJson<Data.TableDataLoader, int, Data.TableData>("AnimalData").MakeDict();
        RatioDic = LoadJson<Data.TableDataLoader, int, Data.TableData>("RatioData").MakeDict();
        StylizeDic = LoadJson<Data.TableDataLoader, int, Data.TableData>("StylizeData").MakeDict();
        VersionDic = LoadJson<Data.TableDataLoader, int, Data.TableData>("VersionData").MakeDict();
        //EnvDic = LoadJson<Data.EnvDataLoader, int, Data.EnvData>("EnvData").MakeDict();
    }

    private Loader LoadJson<Loader, Key, Value>(string path) where Loader : ILoader<Key, Value>
    {
        TextAsset textAsset = Managers.Resource.Load<TextAsset>(path);
        return JsonConvert.DeserializeObject<Loader>(textAsset.text);
    }
}
