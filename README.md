GAppADD
========

## What is it?

This is a program that I wrote to make my life easier when adding AD users to the server of a client that my company services. EHTP HR used to send an Excel sheet of the new users and details on how to create them, in turn having me manually open the files and do a batch of 20+ users by hand. In order to remedy this I made it easier for them by making a Google Docs questionaire sheet that linked in to a spreadsheet.

This program connects to the Google Apps account and displays all spreadsheets, then fetches data from the Google servers and connects to the AD server via SSH private key auth. This also eliminates the need for you to manually use LMI to connect and have everything be done by hand. 

## Cool! How do I use it?

### Requirements

You'll need:

* .NET 4.0+
* GData for C#: https://developers.google.com/gdata/client-cs
* Visual Studio
* Git

### Please note, some thoughts (and an optimistic to-do list)

1. Import all the libraries if imports are broken and compile.
2. Column definitions are hardcoded since I only used this for one client, however, this should fit the needs of most, if not all users. 
3. Make a Google Docs/Drive questionnaire form and tie it to a spreadsheet, then open it up in the software. 
4. Add some sort of header in the sheet so that the program could verify that it's for this purpose or make some sort of filtering in the filename list (I knew what I needed and didn't care).

## This is sweet! Can I use it?

Of course! You are allowed to modify and redistribute this code as long as you use it fairly. I hope you learn from this and share it. Knowledge is power. Also, no commercial usage, please!

This software is bound by the [Creative Commons Attribution-NonCommercial-ShareAlike 3.0 Unported License](http://creativecommons.org/licenses/by-nc-sa/3.0/).
