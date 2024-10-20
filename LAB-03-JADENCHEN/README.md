# LAB 03 JADEN CHEN

1) For the animations to give the playerObject more character, I set the animations speed to 0.8f and the pathing speed to 2.5f. These values worked the best after experimenting because I looked for if the character's foot was sliding on the floor, and these values seemed to work the best to prevent it from looking like it was sliding.

2) I added an additional 2 characters to my scene and had them traverse their own paths, left, middle, and right, at different starting positions. Each of these paths had an empty GameObject as the target transform. For the player to face the dragon while attacking, I referenced a GameObject Transform in the script that was placed inside the dragon.

```C#
[SerializeField] private Transform boss;
```

When the player enters the boss trigger and the _isWalking bool is set to false, the code snippet below will be executed.

```C#
transform.LookAt(boss);
```
Then the player will be looking towards the boss as they are attacking it
