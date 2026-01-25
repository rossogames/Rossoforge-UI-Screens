using Rossoforge.UI.Screens.ScreenBase;

namespace Rossoforge.UI.Screens.ScreenTemplate
{
    public class ScreenTemplatePresenter : ScreenPresenter<ScreenTemplateView, ScreenTemplatePresenter>
    {
        public ScreenTemplatePresenter(ScreenTemplateView view) : base(view)
        {
        }

        public override void OnOpening()
        {
            base.OnOpening();
            UnityEngine.Debug.LogWarning("ScreenTemplatePresenter Opening");
        }

        public override void OnActivate()
        {
            base.OnActivate();
            UnityEngine.Debug.LogWarning("ScreenTemplatePresenter Activated");
        }

        public override void OnClosing()
        {
            base.OnClosing();
            UnityEngine.Debug.LogWarning("ScreenTemplatePresenter Closing");
        }

        public override void OnDeactivate()
        {
            base.OnDeactivate();
            UnityEngine.Debug.LogWarning("ScreenTemplatePresenter Deactivated");
        }

        public void PlayGame()
        {
            _sceneService.RestartScene();
        }
    }
}