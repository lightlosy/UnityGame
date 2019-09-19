using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AssetsManager : Singleton<AssetsManager>
{
    private Dictionary<string, GameObject> _assetsTable = new Dictionary<string, GameObject>();

    public GameObject LoadPrefab(string path){
        GameObject obj = null;
        if(this._assetsTable.ContainsKey(path)){
            obj = this._assetsTable[path];
        }else{
            obj = Resources.Load<GameObject>(path);
            if(!obj){
                Debug.LogError("***** 没有找到资源:Reources/" + path + " *****");
                return null;
            }
            this._assetsTable.Add(path, obj);
        }
        return obj;
    }
}
