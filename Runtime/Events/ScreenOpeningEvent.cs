using Rossoforge.Core.Events;
using Rossoforge.Core.UI.Screens;

namespace Rossoforge.UI.Screens.Events
{
    public readonly struct ScreenOpeningEvent : IEvent
    {
        public readonly IScreenView ScreenView;

        public ScreenOpeningEvent(IScreenView screenView)
        {
            ScreenView = screenView;
        }
    }
}
