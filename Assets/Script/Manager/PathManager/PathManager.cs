using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Resource目录下的路径
 */
public class PathManager : Singleton<PathManager>
{
    /** 主界面预制件 */
    public string getMainUIPrefab(){
        return "Prefabs/Game/MainUI/MainUIView";
    }
    
    public string getMainUIGamePrefab(){
        return "Prefabs/Game/MainUI/MainUIGame";
    }
}
