RegScan (Series 1.0.1) - Black Splendens
======= 
A Registry Scanner by PhantomLabs

RegScan Site: http://jia0020.github.io/RegScan/ <br>
Issues: http://issue.phantomlabs.me/ <br>
Wiki: http://github.com/jia0020/RegScan/wiki | Note: This will be moved to a new site

Builds
-------
AppVeyor Status: [![Build status](https://ci.appveyor.com/api/projects/status/iwvd7ke4vhqvanrd?svg=true)](https://ci.appveyor.com/project/jia0020/regscan)


Current Update Notes
-------
- RegScan scans in WindowsStore
- RegScan scans in DisableChangePassword
- Grabs latest policy (GPUpdate)
- Runs with Administrative Privallages (HighestPossible)

General Usage Notes
-------
- RegScan is to be used as a background program. Scanning for changes in the Registry (regedit.exe) on targeted registry keys. It scans the following keys:
```
    - HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\WindowsStore\\WindowsStore (INT)
    - HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System\\DisableChangePassword (DWORD)
```
- RegScan is also used to block changing of the Local Administrator (.\administrator) Password
- RegScan is also used to grab latest policies through GPUpdate, Note: A connection to the Domain is required for this feature

Planned Features/Debugging (Notes for Developers)
------
- current build version is stable. YAY!
- need to find a way to block Administrator Password, registry?
- license Registry Status


Installation
-------
- install with Source
- Install with commerical *.exe (downloadable within next major update)

License
-------
This Program is licensed under the Apache Version 2.0 License. See LICENSE for more details.
Also Protected with EULA license.

Future Versions
------

| Version Code     | Version Number | Dev Version  | Release Date | Origin Of Version Code                  |
|------------------|----------------|--------------|--------------|-----------------------------------------|
| Black Titanium   | 1.0.0.(build)  | (Alpha 1.0a) | August '14   | Element                                 |
| Black Splendens* | 1.0.1.(build)  | (Alpha 1.1a) | Oct/Nov '14  | Betta splendens (Siamese Fighting Fish) |
| Brown Porosus    | 1.1.0.(build)  | (Alpha 2.0a) | January '15  | Crocodylus porosus (Saltwater Croc)     |
| Silver Mento     | 1.1.1.(build)  | (Alpha 2.1a) | Mar/Jun '15  | Catoprion mento (Wimple Pirnha)         |

*Indicates Current Version
