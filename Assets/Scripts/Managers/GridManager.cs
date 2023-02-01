using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public static GridManager Instance;
    [SerializeField] private int _width, _height;
    [SerializeField] private Tile _spaceTile, _asteroidTile;
    [SerializeField] private Transform _cam;
    private Dictionary<Vector2, Tile> _tiles;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        GenerateGrid();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Generates randomized biome gridtiles
    public void GenerateGrid()
    {
        _tiles = new Dictionary<Vector2, Tile>();
     for(int x = 0; x < _width; x++)
        {
            for(int y = 0; y < _height; y++)
            {
                var randomTile = Random.Range(0,6) == 3 ? _asteroidTile : _spaceTile;
                var spawnedTile = Instantiate(randomTile, new Vector3(x, y), Quaternion.identity);
                spawnedTile.name = $"Tile {x} : {y}";

                spawnedTile.Init(x,y);

                _tiles[new Vector2(x,y)] = spawnedTile;
            }
        }
        _cam.transform.position = new Vector3((float)_width / 2 - 0.5f, (float)_height / 2 - 0.5f, -10);

        GameManager.GameManagerInstance.ChangeGameState(GameState.SpawnHazards);
    }

    public Tile GetTileAtPosition(Vector2 pos)
    {
        if(_tiles.TryGetValue(pos, out var tile)){
            return tile;
        }
        else
        {
            return null;
        }
    }
}
