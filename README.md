# <img src="https://github.com/NextFaze/ManUp/raw/master/icon.png" width="40"> ManUp for Unity

Adds a server side check for a mandatory app update and server-side configuration options to your Unity application.

Useful things you can do with ManUp:

- Prevent users from using the app during server-side maintenance 🚧
- Remotely disable your app (killswitch) 🛑
- Disable specific features in the app from the server 🙅‍♂️
- Recommend (or require) that users update to a specific version or higher ⏬

## Installation

The preferred method is via Package Manager pointing to this git repo:

```pod
pod 'ManUp'
```

## Usage

ManUp will download a ManUp configuration file (json) that is hosted on a server of your choice. This file will have the current app store version, the minimum version, and a URL to the app store or app website.

```json
{
  "ios": {
    "url": "https://itunes.apple.com/app/id0000000?mt=8",
    "latest": "2.0",
    "minimum": "1.1",
    "enabled": true
  }
}
```

Running ManUp will download this file and compare it to the installed app's version to determine if there is an update available (`latest`), or if there is a mandatory update required (`minimum`).

#### Usage

There is a premade Prefab with the basics, or you can customise your own. Please see the Example scene and set up for more details.

You can also add any keys and values to the json file, which will be accessible like so:

```csharp
var jsonNode = NextFaze.ManUp.Instance.SettingForKey(key); // Will return null if missing

string s = jsonNode?.Value;  // String value
int i = jsonNode?.AsInt;     // Int value etc
```

This can be used however you see fit, for example to enable/disable app features.
