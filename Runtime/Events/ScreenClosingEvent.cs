using Rossoforge.Core.Events;
using Rossoforge.Core.UI.Screens;

namespace Rossoforge.UI.Screens.Events
{
    public readonly struct ScreenClosingEvent : IEvent
    {
        public readonly IScreenView ScreenView;

        public ScreenClosingEvent(IScreenView screenView)
        {
            ScreenView = screenView;
        }
    }
}
