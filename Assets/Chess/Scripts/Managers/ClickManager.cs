using UnityEngine;
using Assets.Chess.Scripts.Interfaces;
using Assets.Chess.Scripts.Utilities;

namespace Assets.Chess.Scripts.Managers

{
    public class ClickManager : GenericSingleton<ClickManager>
    {
        public void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Vector2 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                RaycastHit2D hit = Physics2D.Raycast(clickPosition, Vector2.zero);

                if (hit.collider != null)
                {
                    IClickable clickable = hit.collider.gameObject.GetComponent<IClickable>();
                    if (clickable != null)
                    {
                        clickable.OnMouseLeftClick();
                    }
                }
            }
        }
    }
}