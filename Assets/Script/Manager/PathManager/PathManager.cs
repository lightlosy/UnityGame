using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathManager : Singleton<PathManager>
{
    /** ------------------预制件路径-------------------- */
    /** 主界面预制件 */
    public string getMainUIPrefab(){
        return "Prefabs/Game/MainUI/MainUIView";
    }
    
    public string getMainUIGamePrefab(){
        return "Prefabs/Game/MainUI/MainUIGame";
    }

    /** ------------------场景路径-------------------- */
    public string getGameHomeScene(){
        return "GameHomeScene";
    }
    public string getGameMainScene()
    {
        return "GameMainScene";
    }
}
