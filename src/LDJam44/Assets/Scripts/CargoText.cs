﻿
using TMPro;

class CargoText : VerboseMonoBehaviour
{
    private TextMeshProUGUI text;

    private void Start()
    {
        text = VerboseGetComponent<TextMeshProUGUI>();
        text.text = VerboseFindObjectOfType<GameState>().PlayerData.Products.Length.ToString();
    }
}