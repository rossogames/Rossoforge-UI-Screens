# Rosso Games

<table>
  <tr>
    <td><img src="https://github.com/rossogames/Rossoforge-UI-Popups/blob/main/logo.png?raw=true" alt="Rossoforge" width="64"/></td>
    <td><h2>Rossoforge - UI - Screens</h2></td>
  </tr>
</table>

**Rossoforge-UI-Screens** is a lightweight UI architecture package for Unity that provides a Screen-based MVC pattern for full-scene UI flows. It integrates with scene transition systems via events and is designed to be modular, reusable, and easy to extend in production projects.

#
**Version:** Unity 6 or higher

**Tutorial:** [Pending...]

**Dependencies:**
* Unity.TextMeshPro
* [Rossoforge-Core](https://github.com/rossogames/Rossoforge-Core.git)
* [Rossoforge-Events](https://github.com/rossogames/Rossoforge-Events.git)
* [Rossoforge-Scenes](https://github.com/rossogames/Rossoforge-Scenes.git)
* [Rossoforge-UI-Controls](https://github.com/rossogames/Rossoforge-UI-Controls.git)

#
```csharp
// Setup (requires Rossoforge-Services)
ServiceLocator.SetLocator(new DefaultServiceLocator());

var eventService = new EventService();
var poolService = new PoolService();
var uiService = new UIService(eventService, poolService);

ServiceLocator.Register<IEventService>(eventService);
ServiceLocator.Register<IPoolService>(poolService);
ServiceLocator.Register<IUIService>(uiService);
ServiceLocator.Initialize();

// 1. Using without addressables
[SerializeField]
private PooledGameobjectData popupReference;

_uiService.OpenPopup<PopupTemplateView>(popupReference);
await _uiService.OpenPopupUntilClosed<PopupTemplateView>(popupReference);

// 2. Using with addressables
[SerializeField]
private PooledObjectAsyncData popupReference;

await _uiService.OpenPopup<PopupTemplateView>(popupReference);
await _uiService.OpenPopupUntilClosed<PopupTemplateView>(popupReference);
```
#
This package is part of the **Rossoforge** suite, designed to streamline and enhance Unity development workflows.

Developed by Agustin Rosso
https://www.linkedin.com/in/rossoagustin/
