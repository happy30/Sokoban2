using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace Sokoban.LevelEditor
{
    public class EditorMap : MonoBehaviour
    {
        const int MAP_WIDTH = 16;
        const int MAP_HEIGHT = 16;

        const int TILE_SIZE = 1;
        const float TILE_OFFSET = -7.5f;

        public GameObject baseTile;
        public GameObject editorTile;

        public Sprite[] tiles;

        BaseTile[,] map;

        Transform tileContainer;

        public void Awake()
        {
            map = new BaseTile[MAP_WIDTH, MAP_HEIGHT];

            tileContainer = GameObject.FindGameObjectWithTag("EditorTileContainer").transform;

            // create map
            for (int x = 0; x < MAP_WIDTH; x++)
            {
                for (int y = 0; y < MAP_HEIGHT; y++)
                {
                    GameObject tile = (GameObject)Instantiate(baseTile, transform);

                    tile.transform.position = new Vector2(TILE_OFFSET + x * TILE_SIZE, -TILE_OFFSET - y * TILE_SIZE);

                    map[x, y] = tile.GetComponent<BaseTile>();
                }
            }

            for(int i = 0; i < tiles.Length; i++)
            {
                GameObject tile = (GameObject)Instantiate(editorTile, tileContainer);
                tile.GetComponent<Image>().sprite = tiles[i];
            }
        }
    }
}