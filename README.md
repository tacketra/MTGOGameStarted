# MTGOGameStarted
Purpose
----------
This is an application that is meant to be used with the Magic: The Gathering Online application. When you are
playing in a tournament if your game starts and you don't respond within 10 minutes you are dropped from the 
tournament. I frequently want to go do other activies besides sit at the computer waiting for my match to start but
cannot due to this 10 minute rule. This application should help with this problem by texting or emailing you the second your game starts.

Setup
-------
Download a zip of this project, extract it and run the ConsoleApplication1.exe (name will eventually change) located
at "MTGOGameStarted\StartDay\ConsoleApplication1\bin\Debug\". The application should appear in the windows 7 system
tray as an M icon. Right-click that icon and click settings. Here were are going to set up our email settings. We 
need to set up a email address, a password and Outgoing SMTP mail settings. You should be able to use any email 
service that supports this but I chose to use gmail. See setup steps for gmail below
- login to your online gmail mailbox 
- From your gmail mailbox click settings 
- "forwarding and POP/IMAP" tab 
- click the "configuration instructions" hyperlink at the bottom 
- click "I want to enable IMAP" radio button
- click the "other" radio button for the client selection
- Under "Outgoing Mail (SMTP) Server - Requires TLS" it should list the host (currently smtp.gmail.com) and the port
- grab the host and port from this section
- input your email, password as well as the host and port information you just grabbed into seetings and click save
- you can change the Email to field to be your email address or your phone number. If you want to set up a phone number correctly just google and find the correct format to input your phone number, e.g. gmail to my verizon phone number the Email to field looks like 5131231234@vtext.com
  
Before using this application with an actual tournament you can test it out by joining a practice room game just
to be safe. 

Now, whenever you want to leave your computer during a tournament just start this application and you should be 
notified when your game is up. Unless of course you don't have your email synced on your phone then this application
is probably pretty useless.

Requirements
---------
This application is intended to run in windows 7, it is very possible that it would work in other versions of windows
but it has not yet been tested.


Thanks for reading, feel free to contribute!
