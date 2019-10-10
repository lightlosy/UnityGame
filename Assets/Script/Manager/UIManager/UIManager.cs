using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : Singleton<UIManager> {
    private Dictionary<string, GameObject> _assetsTable = new Dictionary<string, GameObject>();
    public UIManager(){}

    public void open(string path, GameObject canvas = null){
        GameObject viewNode = null;
        GameObject parent = canvas;
        if(!parent){
            parent = GameObject.Find("Canvas");
            if(!parent){
                Debug.LogError("***** 没有找到Canvas节点 *****");
                return;
            }
        }
        if(this._assetsTable.ContainsKey(path)){
            viewNode = this._assetsTable[path];
        }else{
            GameObject asset = Manager.assets.LoadPrefab(path);
            if(!asset){
                return;
            }
            viewNode = GameObject.Instantiate(asset);
            this._assetsTable.Add(path, viewNode);
        }
        viewNode.transform.SetParent(parent.transform, false);
        viewNode.SetActive(true);
    }

    public void close(string path){
        GameObject viewNode = this._assetsTable[path];
        if(viewNode){
            viewNode.SetActive(false);
        }
    }
}
