using UnityEngine;

namespace Assets.Chess.Scripts
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