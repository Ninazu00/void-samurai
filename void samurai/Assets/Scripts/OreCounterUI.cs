using UnityEngine;
using TMPro;

public class OreCounterUI : MonoBehaviour
{
    public TextMeshProUGUI countText;

    void Update()
    {
        countText.text = PlayerStats.score.ToString();
    }
}