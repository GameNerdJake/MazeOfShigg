using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI UrnText;

    // Start is called before the first frame update
    void Start()
    {
        UrnText = GetComponent<TextMeshProUGUI>();

    }

    public void UpdateUrnText (PlayerInventory playerInventory)
    {
        UrnText.text = playerInventory.NumberOfUrns.ToString();
    }

}
