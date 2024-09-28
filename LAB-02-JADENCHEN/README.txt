1) When changing the "Transition Duration" parameter it affects how fast the next animation is played, 0 is fastest, and any value higher makes it slower. Makes the movement look very fake if its set too high

When changing the "Transition Offset" parameter it affects which frame is going to be played when the animation changes. The transition offset can be use to make an animation play from the beginning, middle, or end. It can transition to any point in the walking animation, making it jittery if used wrong, or smooth if done right.

The "Has Exit Time" parameter affects how much longer the animation will be played for after changing. Makes the player locked in the movement animation or the idle animation if set high.

The "Fixed Duration" parameter changes if "Transition Duration" parameter will use a percentage of the clip for the value, or use time as the value. It does not effect the movement at all.

The "Interruption Source" parameter makes a cut in the current playing animation and immediately plays the next one. It makes the movement look more snappy.

2) I edited the script to make the player stop when they collide into the player tag, adding a Boolean to determine if the play can move or not, and then setting the animator Boolean to false, making the player stand still, and put into the idle state. 