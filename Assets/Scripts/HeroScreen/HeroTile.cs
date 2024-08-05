using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HeroTile : MonoBehaviour
{
    [Tooltip("Text field for the hero's name")]
    [SerializeField] private TextMeshProUGUI _nameText;

    [Tooltip("Image for the hero's avatar")]
    [SerializeField] private Image _avatarImage;

    [Tooltip("Text field for the hero's level")]
    [SerializeField] private TextMeshProUGUI _levelText;

    [Tooltip("Text field for the hero's XP")]
    [SerializeField] private TextMeshProUGUI _xpText;

    [Tooltip("Slider for the hero's XP progress")]
    [SerializeField] private Slider _xpSlider;

    // Set the hero data on the tile
    public void SetHeroData(HeroProgressData hero)
    {
        _nameText.text = hero.Name;
        _avatarImage.sprite = hero.Avatar;
        _levelText.text = $"{hero.Level}";
        _xpText.text = $"{hero.LevelXpCurrent}/{hero.LevelXpMax}";
        _xpSlider.maxValue = hero.LevelXpMax;
        _xpSlider.value = hero.LevelXpCurrent;
    }
}
