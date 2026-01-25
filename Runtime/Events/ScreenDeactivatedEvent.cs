using Rossoforge.Core.Events;
using Rossoforge.Core.UI.Screens;

namespace Rossoforge.UI.Screens.Events
{
    public readonly struct ScreenDeactivatedEvent : IEvent
    {
        public readonly IScreenView ScreenView;

        public ScreenDeactivatedEvent(IScreenView screenView)
        {
            ScreenView = screenView;
        }
    }
}
