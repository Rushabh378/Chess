
namespace Assets.Chess.Scripts
{
    public interface IInteractable 
    {
        //public void OnMouseDown(); with this function there no need of ClickManager but its rob us from expandablity. 
        public void OnMouseLeftClick();
    }
}