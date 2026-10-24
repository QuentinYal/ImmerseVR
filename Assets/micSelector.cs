using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class micSelector : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public int chosenDeviceIndex;

    public static UnityAction<int> onMicChange;

    void Start()
    {
        PopulateDropdown();
    }

    public void PopulateDropdown()
    {
        var options = new List<TMP_Dropdown.OptionData>();

        foreach (var mic in Microphone.devices)
        {
            TMP_Dropdown.OptionData optionData = new TMP_Dropdown.OptionData(mic);

            options.Add(optionData);
        }

        dropdown.options = options;
    }

    public void chooseMic(int optionIndex)
    {
        chosenDeviceIndex = optionIndex;
        onMicChange?.Invoke(chosenDeviceIndex);
    }
}
