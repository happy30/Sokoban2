using UnityEngine;
using System.Collections;

namespace Sokoban.LevelEditor
{
    public class EditorUITile : MonoBehaviour
    {
        /// <summary>
        /// Id of the XML to be sent to the xml.
        /// </summary> 
        public int Id;

        /// <summary>
        /// Gets called when you press one of the tiles.
        /// </summary>
        public void OnSelect()
        {
            // TODO: Set Selected ID in manager to this.Id
        }
    }
}