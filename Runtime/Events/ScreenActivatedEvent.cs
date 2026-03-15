using Rossoforge.Core.Events;
using Rossoforge.Core.UI.Screens;

namespace Rossoforge.UI.Screens.Events
{
    public readonly struct ScreenActivatedEvent : IEvent
    {
        public readonly IScreenView ScreenView;

        public ScreenActivatedEvent(IScreenView screenView)
        {
            ScreenView = screenView;
        }
    }
}
