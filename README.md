RegScan (v1.1a) Black Titanium
======= 
A Registry Scanner

Current Update Notes
-------
- RegScan scans in WindowsStore
- Runs with Administrative Privallages (HighestPossible)

General Usage Notes
-------
- RegScan is to be used as a background program. Scanning for changes in the Registry (regedit.exe) on targeted registry keys. It scans the following keys:
    - HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\WindowsStore\\WindowsStore (INT)
    - HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System\\DisableChangePassword (DWORD)
- RegScan is also used to block changing of the Local Administrator (.\administrator) Password



Documentation:
-------
http://phantomlabs.github.io/RegScan[br]
http://github.com/PhantomLabs/RegScan/Wiki[br]


Installation
-------
- install with Source
- Install with commerical *.exe (downloadable within next update)

License
-------
This Program is licensed under the Apache Version 2.0 License. See LICENSE for more details.
Also Protected with EULA license.

Planned Features/Debugging (Notes for Developers)
- latest version is unstable (redeveloping core)
- need to find a way to block Administrator Password, registry?
- license Registry Status




