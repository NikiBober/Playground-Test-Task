using UnityEngine;

public class HeroScreen : MonoBehaviour
{
    [Tooltip("Prefab for hero tile")]
    [SerializeField] private GameObject _heroTilePrefab;

    [Tooltip("Prefab for placeholder tile")]
    [SerializeField] private GameObject _placeholderTilePrefab;

    [Tooltip("Content container for the Scroll Rect")]
    [SerializeField] private Transform _content;

    [Tooltip("Parent object containing child objects with HeroProgressData components")]
    [SerializeField] private GameObject _heroesContainer;

    private HeroProgressData[] _heroes;


    private void Start()
    {
        _heroes = _heroesContainer.GetComponentsInChildren<HeroProgressData>();

        Init(_heroes);
    }

    public void Init(HeroProgressData[] heroes)
    {
        // Clear all existing children from the content
        foreach (Transform child in _content)
        {
            Destroy(child.gameObject);
        }

        // Create tiles for each hero in the array
        foreach (var hero in heroes)
        {
            if (hero.Unlocked)
            {
                // If the hero is unlocked, create a regular hero tile
                GameObject tile = Instantiate(_heroTilePrefab, _content);

                // Set hero data on the tile
                HeroTile heroTile = tile.GetComponent<HeroTile>();
                heroTile.SetHeroData(hero);
            }
            else
            {
                // If the hero is locked, create a placeholder tile
                Instantiate(_placeholderTilePrefab, _content);
            }
        }

        // TODO
        /*
         *  This method receives a list of heroes data objects of any amount
         *  Fill the scroll rect with Tiles in amount according to received data objects 
         *  If character is locked - show placeholder tile as it is the last one on example scene
         *  Ignore the top label with "Heroes 6/8" 
         */
    }
}
