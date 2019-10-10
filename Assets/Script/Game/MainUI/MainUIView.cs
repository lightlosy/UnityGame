using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum PageIndex
{
    noting = 0,
    weapon,
    game,
    chest,
}
public class MainUIView : MVCS
{
    // Start is called before the first frame update
    public List<Button> btnList = new List<Button>();
    public List<Sprite> spArr = new List<Sprite>();

    private PageIndex _preIndex = PageIndex.noting;
    private PageIndex _curIndex = PageIndex.noting;

    void Start()
    {
        this.showPage(PageIndex.game);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void onBtnClick(int index)
    {
        this.showPage((PageIndex)index);
    }

    public void showPage(PageIndex index)
    {
        if (this._curIndex != index)
        {
            this._preIndex = this._curIndex;
            this._curIndex = index;
            int preSpIndex = ((int)this._preIndex - 1) * 2;
            int curSpIndex = ((int)this._curIndex - 1) * 2 + 1;
            if (preSpIndex >= 0)
            {
                Button preBtn = this.btnList[(int)this._preIndex - 1];
                preBtn.GetComponent<Image>().sprite = this.spArr[preSpIndex];
            }
            if (curSpIndex >= 0)
            {
                Button curBtn = this.btnList[(int)this._curIndex - 1];
                curBtn.GetComponent<Image>().sprite = this.spArr[curSpIndex];
            }
        }
        // string 
        switch((PageIndex)index){
            case PageIndex.game: {
                Manager.ui.open(Manager.path.getMainUIGamePrefab());
                break;
            }
        }
    }
}
