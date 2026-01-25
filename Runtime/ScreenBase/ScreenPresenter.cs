using Rossoforge.Core.Events;
using Rossoforge.Core.UI.Screens;
using Rossoforge.Scenes.Events;
using Rossoforge.UI.Screens.Events;

namespace Rossoforge.UI.Screens.ScreenBase
{
    public abstract class ScreenPresenter<V, P> : IScreenPresenter,
        IEventListener<SceneTransitionActiveEvent>,
        IEventListener<SceneTransitionExitingEvent>,
        IEventListener<SceneTransitionInactiveEvent>
        where V : ScreenView<V, P>
        where P : ScreenPresenter<V, P>
    {
        protected readonly IEventService _eventService;

        protected V View { get; private set; }
        public ScreenState State { get; private set; }

        protected ScreenPresenter(IEventService eventService, V view)
        {
            _eventService = eventService;
            View = view;
        }

        public virtual void OnStart()
        {
            _eventService.RegisterListener<SceneTransitionActiveEvent>(this);
            _eventService.RegisterListener<SceneTransitionExitingEvent>(this);
            _eventService.RegisterListener<SceneTransitionInactiveEvent>(this);
        }
        public virtual void OnDestroy()
        {
            _eventService.UnregisterListener<SceneTransitionActiveEvent>(this);
            _eventService.UnregisterListener<SceneTransitionExitingEvent>(this);
            _eventService.UnregisterListener<SceneTransitionInactiveEvent>(this);
        }
        public virtual void OnOpening()
        {
            State = ScreenState.Opening;
            View.SetInteractable(false);
            _eventService.Raise(new ScreenOpeningEvent(View));
        }
        public virtual void OnActivate()
        {
            State = ScreenState.Active;
            View.SetInteractable(true);
            _eventService.Raise(new ScreenActivatedEvent(View));
        }
        public virtual void OnClosing()
        {
            State = ScreenState.Closing;
            View.SetInteractable(false);
            _eventService.Raise(new ScreenClosingEvent(View));
        }
        public virtual void OnDeactivate()
        {
            State = ScreenState.Inactive;
            _eventService.Raise(new ScreenDeactivatedEvent(View));
        }

        public void OnEventInvoked(SceneTransitionActiveEvent eventArg)
        {
            OnActivate();
        }
        public void OnEventInvoked(SceneTransitionExitingEvent eventArg)
        {
            OnClosing();
        }
        public void OnEventInvoked(SceneTransitionInactiveEvent eventArg)
        {
            OnDeactivate();
        }
    }
}
