# in-class-activities
## Devlogs
### W1
#### In-Class Activity
"Hello World!"

1. After removing the camera as one of the Cat's (Gameobject) children, the camera no longer is a "dependent" on the Cat. This means that when the cat moves, the camera will not move accordingly with the cat. This is why when running the game without the camera as a child of the cat, the camera no longer follows the cat.
2. https://acrodream1.itch.io/w1-class-activity-current

### W2
#### In-Class Activity

1. The reason that the variables r, g, and b are floats because RGB values use numbers ranging from 0.0 to 1.0. Because the variable type int cannot store decimals, the variable type float fits.
2. The _bounce variable is a int variable because each bounce from the ball increases by one. One is an integer value and there is no such thing as half or a quarter of a bounce.
3. The reason why that line of code was broken because it is impossible to cast one type of variable into another type. A double cannot be cast to a float the same way that an boolean value cannot magically turn into an integer.

### W3
#### In-Class Activity

##### Methods discussion || Table 1
1. The parameters of the GetResponse method should be declared as "int relationshipLevel" and "bool knowsSecret". The return type of the method should be "string".
2. The parameter of the SetLightDimness method should be declared as "float sanity". The return type of the method should be "void".
3. The parameter of the DidPlayerHitBeat method should be declared as "float time". The return type of the method should be "bool".


##### Components & Classes metaphor
1. Components are the body parts of a human vessel and the classes are its properties. The classes can define if the body part moves, it if has bones, if it has skin, and many more.

##### Devlog Question
1. I think the reason why the balls get brighter the more they bounce because the BallW3 script changes the brightness of the ball based on its average speed. The ball's color is multiplied by the result of "GetColorMultiplier", which can return 1.5 instead of 1.0, making the balls brighter if they pass the speed threshold.




## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 