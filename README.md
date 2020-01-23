# SelfNavigatingObject
GOAL: Create an object that can navigate and avoid collision autonomously from point A to point B
Video of project in action (as of 1/21/2020): https://www.youtube.com/watch?v=GiZ4bEqPVXE

Updated video (1/22/2020): https://www.youtube.com/watch?v=e4hwta9BTHg
  Added more lasers and made a bit of a more complex obstacle course. The added lasers allowed me to change the intensity of direction change depending on which laser comes in contact with an object. For example, a laser that is rotated at a smaller angle (straight ahead being 0 degree rotation) is coming in contact with obstacles the cube is likely to hit, so the direction change is more intense on those lasers than the others. 

Current challenges: need lasers to change object direction more forcefully when object is closer to obstacle. Need a way to handle what to do when all lasers are colliding at the same time. Currently, all lasers are assigned equally opposite forces. For example, if two acutely rotated lasers are both colliding with obstacles simultaneously, both of their forces will be applied; since their forces are equally opposite, the object will not change direction.

Long term challenges: need object to navigate towards a set destination rather than just going straight on a narrow plane. Eventually need to be able to determine shortest route to destination.
