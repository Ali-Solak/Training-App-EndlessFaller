# Project Review

## Applicant name
Ali Solak

---

<!-- Your review goes here -->
As I had already done some arcade like games in Unity, I thought this would be faster to achieve than my predicted completion time, however
after hitting the 6+ hours mark I had implemented most aspects and stopped there. Yet I wasn't able to fix some minor issues 
and to add bonuses like unit testing, particle effects in this time frame.

<!-- Explain why you did the things that way or any snippet that is word mentioning -->
For the spawn rate I simply took the elapsed time and spawned a platform every time a specific time rate was reached,
decreased the time rate for spawns for a specific value in update.

For increasing the speed of the platforms over time, I added an acceleration value to the speed value in update.

In order to count the score I used an empty GameObject with an OnTrigger-Collider.

To start a replay I destroyed all platforms, then spawned the mainCharacter again and reenabled my Spawner.

<!-- If you had any issue and how you resolved them -->
My general issue was working with the UI and this is where I lost most of my time, as I had not spent too much time with it earlier
and I was used to a different approach from my experience with for example React/Webdev or even JavaFX. For example
I kept putting the script in the onClick area at the inspector and thus the functions were never showing up.
Apparently I had to put the GameObject there.  

I also spent too much time looking for options for saving the highscore persistently without playerPrefs.
I first wanted to use SQLite, but had initially issues with getting the plugin to work. After that I reverted to a more simple solution, to save me some time,
and saved it in a file with the BinaryFormatter and Filestream.

I also spent too much time with trying to get the pausing menu done. Time.timeScale wouldn't stop the movingPlatforms. I tried a lot of things
until I just multiplied the speed with Time.timeScale, so it would be zero while paused.

