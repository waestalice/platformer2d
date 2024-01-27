using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollectableDiamond : ItemCollectableBase
{
    protected override void OnCollect()
    {
        base.OnCollect();
        ItemManager.Instance.AddDiamonds();
    }
}
