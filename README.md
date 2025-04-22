# Custom Sub Menu
A collection of mods for P4G Steam from multiple creators centred around the use of the sub menu. (Also on [GameBanana](https://gamebanana.com/mods/470352)!)

## Supported Languages
This mod fully supports the following languages:
- English
- Spanish (translation by @Artur16211)

As long as you have version 2.9.2 or later of [Persona Essentials](https://github.com/Sewer56/p5rpc.modloader) the correct files for should automatically be loaded based on your in game language settings (e.g. in Steam). If your language is not directly supported, English files will try to be used, how well this works may vary based on the language.

### Adding additional languages
If you are interested in adding support for another language have a look at the `FEmulator\L10N\es` folder and copy its structure, replacing `es` with the appropriate langugae id from the [Localisation Framework documentation](https://github.com/AnimatedSwine37/Reloaded.Universal.Localisation.Framework?tab=readme-ov-file#supported-languages). 

The msg files should be straight forward to translate, they are just plain text files that you can edit with any text editor (e.g. notepad).

The `MSG.TBL` file needs to be hex edited using [010 Editor](https://www.sweetscape.com/010editor/) (free trial) with the p4g_tbl template from the [010 Templates Repo](https://github.com/tge-was-taken/010-Editor-Templates). The following skill names need to be changed:
- 619 - "Off"
- 620 - "On"
- 621 - "" (empty string)
- 622 - "+"

"On" and "Off" are used to indicate whether each option is turned on or not when configuring the parts of custom sub menu you want to use. "+" and "" are used by find a friend to indicate whether a social link is ready to rank up.

If you need any assistance please feel free to reach out to me (@animatedswine on discord) or [make an issue](https://github.com/AnimatedSwine37/p4g64.customSubMenu/issues) on this repo. I'd love to support as many languages as possible!

## Features
### Quick Travel Plus
by [Tekka](https://gamebanana.com/members/1739579) and [ShrineFox](https://gamebanana.com/members/1568750)

When enabled, this mod expands the fast travel menus in both the sub menu and overworld map with additional locations. This means less time wasted getting from A to B!
![hRK3ZcO](https://github.com/AnimatedSwine37/p4g64.customSubMenu/assets/24914353/5da3a0bc-6dd7-4757-9b0b-631545394a3a)
![uqyA8WI](https://github.com/AnimatedSwine37/p4g64.customSubMenu/assets/24914353/8571b922-88ef-4d7c-8839-fda16faf7969)

### Find A Friend
by [AnimatedSwine37](https://gamebanana.com/members/1742760)

When enabled, this mod adds a new "Spend time with..." entry to the sub menu if one of your Social Links is available that day. From here you can select their name to fast travel travel directly to them.
![Wf4ghQD](https://github.com/AnimatedSwine37/p4g64.customSubMenu/assets/24914353/31e1f3d8-4ad8-4f07-96d9-5ef886bdd9d2)

### Mobile Calendar
by [ShrineFox](https://gamebanana.com/members/1568750)

When enabled, a new *"View calendar"* entry is added to the sub menu that allows you to check the in-game calendar from anywhere.
![RO2rZsD](https://github.com/AnimatedSwine37/p4g64.customSubMenu/assets/24914353/ed60088c-e5df-4631-bc17-6ed7861f125e)

### Save Anywhere
by [Tupelov](https://gamebanana.com/members/1739633)

When enabled, a new "Save" entry is added to the sub menu that allows you to save your game from anywhere - even dungeons!
![fR0uR9z](https://github.com/AnimatedSwine37/p4g64.customSubMenu/assets/24914353/fcdd7f9d-8e92-41c7-8d55-7e8ac43e4fc2)

### Call the Fox
by [Tekka](https://gamebanana.com/members/1739579)

A quality of life tweak. When enabled, a new *"Call the Fox"* entry is added to the sub menu (under "Strategize") that allows you to summon the Fox from anywhere in a dungeon to use their healing service.

Enabling this mod is designed to improve dungeon pacing since you no longer have to leave and come back. To balance this ability however, using the service from the menu option costs 1 Goho-M in addition to the monetary cost you would have to pay normally (configurable).
![RzeQhI8](https://github.com/AnimatedSwine37/p4g64.customSubMenu/assets/24914353/ca62d2b8-c86f-4595-a187-19e0a32ebe3d)
![N2qQt6m](https://github.com/AnimatedSwine37/p4g64.customSubMenu/assets/24914353/ac8184a0-5010-4a67-86cd-1d06e039463b)

### Floor Select
by [Tekka](https://gamebanana.com/members/1739579)

When enabled, a new *"Select floor"* entry is added to the sub menu <ins>if</ins> (and <ins>only if</ins>) you have defeated the main boss for that dungeon and passed the deadline for it.

The idea behind this quality of life mod is to make future visits for quests and grinding much less tedious. If you haven't beaten the boss, the option won't appear - <ins>it's not a cheat</ins>.
![pYevZ7v](https://github.com/AnimatedSwine37/p4g64.customSubMenu/assets/24914353/7a4f2669-a301-48ea-ad09-b2016c61c4d0)

### Goho-M Option
by [Tekka](https://gamebanana.com/members/1739579)

When enabled, a new *"Goho-M x #"* entry is added to the sub menu. Here, the "#" represents the number of available Goho-M or Return Daikons currently available in your inventory (see screenshots below).

This mod allows you to see quickly whether you have any available items that will return you to the entrance and use them, without needing to waste time searching through your inventory.
![Fs4iHzQ](https://github.com/AnimatedSwine37/p4g64.customSubMenu/assets/24914353/fa492dad-dc31-4c43-97a1-04a2721e4a2e)

### Organize Party
by [Tekka](https://gamebanana.com/members/1739579)

When enabled, a new *"Organize party"* entry is added to the sub menu that allows you to switch active party members at any time from any floor within a dungeon. Without this quality of life mod you would need to return to the dungeon entrance to switch party members.
![R6lnwji](https://github.com/AnimatedSwine37/p4g64.customSubMenu/assets/24914353/a26e0eb5-ffd6-4e60-9c8e-da00691aafd6)

### Default Direct Commands
by [Tekka](https://gamebanana.com/members/1739579)

When enabled, new party members will automatically be set to "Direct Commands" upon joining your team (so you don't have to remember to change the setting yourself!).
![cck7sWP](https://github.com/AnimatedSwine37/p4g64.customSubMenu/assets/24914353/6c97ede6-8cd5-4a37-bc0a-fb612795ca0a)

### Reap-Balanced Encounters
by [Tekka](https://gamebanana.com/members/1739579)

When enabled, this quality of life tweak will remove the randomness from Reaper encounters.

Normally after opening 21 chests the player will begin to hear chains rattling. The 22nd chest opened will then <ins>maybe</ins> contain the Reaper in place of a normal encounter (if you're lucky) and the game will ask if you want to fight them.

If you're *unlucky* however, the counter will reset and you'll have to open another 22 chests before you get the chance to <ins>maybe</ins> encounter them all over again.

Because of the random element of this mechanic, it can be incredibly frustrating late-game to even track down the Reaper, let alone fight them.

With this mod, the 22nd chest you open will <ins>always</ins> contain the Reaper and if you don't want to face them, you can simply dismiss the prompt and move on to another floor to reset the counter.
![zi58oH2](https://github.com/AnimatedSwine37/p4g64.customSubMenu/assets/24914353/031b5ba7-0f79-4299-8c16-65385aa448c6)

### Game Over Skip
by [Tekka](https://gamebanana.com/members/1739579)

When enabled, the scrolling Velvet Room scene that normally plays whenever you die will be skipped. Instead, you will be presented with the *"Retry"* / *"Return to title screen"* options immediately should you get a game over.
![JmuoqDO](https://github.com/AnimatedSwine37/p4g64.customSubMenu/assets/24914353/aba3d7b0-2a00-4db8-8fdc-1fad15c9ce13)

### Mod Menu
Developed by [Tekka](https://gamebanana.com/members/1739579), [Sierrai17](https://gamebanana.com/members/1749229), and [ShrineFox](https://gamebanana.com/members/1568750), "Mod Menu" is a powerful toolkit intended primarily for mod developers, data-miners etc.

Unlike the other sub menu mods detailed above, **"Mod Menu" is not intended for use during normal gameplay**. We recommend that you backup any save files before trying it out. <ins>Do not</ins> complain to us if you cause irreparable damage to your 90 hour save after messing around with settings you don't understand.

Features include: calling of fields and events, toggling of flags, stat editing and much more. The [Amicitia Wiki](https://amicitia.miraheze.org/wiki/Persona_4_Golden#ID_Tables) is a great resource you'll want to familiarise yourself with.
![0FwPXvn](https://github.com/AnimatedSwine37/p4g64.customSubMenu/assets/24914353/69efbe5b-77ea-48a1-a8b6-79d4d4ffd71a)
