using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

enum PageIndex
{
    weapon = 1,
    game,
    chest,
}
public class MainUIView : MVCS
{
    // Start is called before the first frame update
    public List<Button> btnList = new List<Button>();
    public List<Sprite> spArr = new List<Sprite>();

    private int _preIndex = 0;
    private int _curIndex = 0;

    void Start()
    {
        this.ShowPage((int)PageIndex.game);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnBtnClick(int index)
    {
        this.ShowPage(index);
    }

    public void ShowPage(int index)
    {
        if (this._curIndex != index)
        {
            this._preIndex = this._curIndex;
            this._curIndex = index;
            int preSpIndex = (this._preIndex - 1) * 2;
            int curSpIndex = (this._curIndex - 1) * 2 + 1;
            if (preSpIndex >= 0)
            {
                Button preBtn = this.btnList[this._preIndex - 1];
                preBtn.GetComponent<Image>().sprite = this.spArr[preSpIndex];
            }
            if (curSpIndex >= 0)
            {
                Button curBtn = this.btnList[this._curIndex - 1];
                curBtn.GetComponent<Image>().sprite = this.spArr[curSpIndex];
            }
        }
        Manager.ui.open(Manager.path.getMainUIGamePrefab());
    }
}
