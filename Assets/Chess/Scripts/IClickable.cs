
namespace Assets.Chess.Scripts
{
    public interface IClickable 
    {
        //public void OnMouseDown(); with this function there no need of ClickManager, but it rob us from expandablity. 
        public void OnMouseLeftClick();
    }
}