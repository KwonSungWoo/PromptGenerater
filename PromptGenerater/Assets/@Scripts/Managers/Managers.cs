using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class Managers : MonoBehaviour
{
    private static Managers s_instance;
    private static Managers instance { get { Init(); return s_instance; } }

    #region Contents
    private GameManager _game = new GameManager();
    private ObjectManager _object = new ObjectManager();

    public static GameManager Game              { get { return instance?._game; } }
    public static ObjectManager Object          { get { return instance?._object; } }
    #endregion

    #region Core
    private DataManager     _data       = new DataManager();
    private PoolManager     _pool       = new PoolManager();
    private ResourceManager _resource   = new ResourceManager();
    private SceneManagerEX  _scene      = new SceneManagerEX();
    private SoundManager    _sound      = new SoundManager();
    private UIManager       _ui         = new UIManager();
    private UIDataManager   _uiData     = new UIDataManager();

    public static DataManager      Data        { get { return instance?._data    ; } }
    public static PoolManager      Pool        { get { return instance?._pool    ; } }
    public static ResourceManager  Resource    { get { return instance?._resource; } }
    public static SceneManagerEX   Scene       { get { return instance?._scene   ; } }
    public static SoundManager     Sound       { get { return instance?._sound   ; } }
    public static UIManager        UI          { get { return instance?._ui      ; } }
    public static UIDataManager    UIData      { get { return instance?._uiData  ; } }
    #endregion


    public static void Init()
    {
        if (s_instance == null)
        {
            GameObject go = GameObject.Find("@Managers");
            if(go == null)
            {
                go = new GameObject { name = "@Managers" };
                go.AddComponent<Managers>();
            }

            DontDestroyOnLoad(go);

            s_instance = go.GetComponent<Managers>();
        }
    }

}
