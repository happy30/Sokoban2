using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace Sokoban.LevelEditor
{
    public class LevelEditor : MonoBehaviour {

        public EditorUITile currentSelectedTile;

        void Update()
        {
            // TODO: Add touch support
            if (Input.GetMouseButton(0))
            {
                if (currentSelectedTile)
                {
                    RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
                    if (hit)
                    {
                        hit.collider.GetComponent<EditorUITile>().Id = currentSelectedTile.Id;
                        hit.collider.GetComponent<Image>().sprite = currentSelectedTile.sprite;
                    }
                }
            }
        }
    }
}