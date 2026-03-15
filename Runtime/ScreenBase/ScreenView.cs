using Rossoforge.Core.UI.Screens;
using Rossoforge.Utils.Logger;
using UnityEngine;

namespace Rossoforge.UI.Screens.ScreenBase
{
    [RequireComponent(typeof(CanvasGroup))]
    public abstract class ScreenView<V, P> : MonoBehaviour, IScreenView
        where V : ScreenView<V, P>
        where P : ScreenPresenter<V, P>
    {
        private CanvasGroup _canvasGroup;

        protected P Presenter { get; set; }

        protected virtual void Awake()
        {
            _canvasGroup = GetComponent<CanvasGroup>();
        }
        protected virtual void Start()
        {
            if (Presenter == null)
                RossoLogger.Error($"{GetType().Name} did not initialize its Presenter.");

            Presenter.OnStart();
        }
        private void OnDestroy()
        {
            Presenter.OnDestroy();
        }

        public void SetInteractable(bool interactable)
        {
            if (_canvasGroup != null)
                _canvasGroup.interactable = interactable;
        }
    }
}
