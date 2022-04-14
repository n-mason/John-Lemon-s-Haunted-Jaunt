# John-Lemon-s-Haunted-Jaunt

The Player Character Parts 1 and 2 - Harry Smith

The Camera, Ending the Game, Audio - Nathaniel Mason

Enemies Parts 1 and 2 - Chris Cortes

Particle Effect and Trigger (Nathaniel Mason and Harry Smith): Added sweat particles that fall off the player. These will continue to fall automatically as the player walks around.

Dot Product Usage (Nathaniel Mason and Harry Smith): Used the dot product to adjust the speed at which the sweat particles fall in relation to the closest enemy. There is not a direct relationship between the distance to a ghost and the speed of particles, but the dot product does cause some variation in the speed of sweat particles as the player's distance to the nearest ghost changes. (Sometimes the sweat particles will move further out from the player due to an increase in speed.)

Liner Interpolation Usage (Chris Cortes): Used linear interpolation to generate a random color that is between two randomly generated colors. This effect can be seen in the ghosts that patrol in the game. The color in each moving ghost will change every few seconds.
