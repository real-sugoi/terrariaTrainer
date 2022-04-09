# terrariaTrainer

CURRENTLY ONLY MAKES PLAYER INVINCIBLE UNLESS 1-SHOT
WILL PROBABLY ONLY WORK ON WINDOWS

Steps to set up:

1. Download VAMemory.dll from online https://vivid-abstractions.net/logical/programming/vamemory-c-memory-class-net-3-5/ and put all files in the same directory
2. In CMD navigate to the directory and type `dotnet run`
3. Find the base value for player health in Cheat Engine by doing the following:

3.1 - use scans to find the player health value in memory

3.2 - right click -> Find out what writes to this address

3.3 - take damage, look at the instruction until you find something like this: sub[edx+000003e4]

3.4 - on the bottom part of the window find the value of edx or whichever register it is using

3.5 type in cmd "0x" and then the value of that register

3.6 congrats you have officially used the worst terraria cheat ever and your health should constantly be resetting to max
