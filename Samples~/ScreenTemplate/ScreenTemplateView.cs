using Rossoforge.UI.Controls.Buttons;
using Rossoforge.UI.Screens.ScreenBase;

namespace Rossoforge.UI.Screens.ScreenTemplate
{
    public class ScreenTemplateView : ScreenView<ScreenTemplateView, ScreenTemplatePresenter>,
        IButtonClickListener<ScreenTemplateButtonPlay>
    {
        protected override void Awake()
        {
            base.Awake();
            Presenter = new ScreenTemplatePresenter(this);
        }

        public void OnClick(ButtonEventArg<ScreenTemplateButtonPlay> eventArg)
        {
            UnityEngine.Debug.LogWarning("Play button clicked!");
            Presenter.PlayGame();
        }
    }
}