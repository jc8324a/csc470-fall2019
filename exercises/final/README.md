Immortal Pit Fighting
A detailed plan for the game. This will involve describing all of the following components:
	Gameplay description (what is your “core mechanic”)
			First Person melee fighting
			LAN Multiplayer
			Small “pit fighting” arena
			Use mouse pointer to choose direction of attack
			Throw small dismembered parts at enemy with one hand
			Throw larger dismembered parts at enemy with two hands
	Input
			Mouse for aiming
			Left click for left hand object use
			Right click for right hand object use
			Q and E for turn left and right while using mouse for other actions
			WASD for moving
			Shift for kick
			Space for jump
			F to pick up body parts
	Visual style
			Simple, minimal polygons
			Sandy ground that can turn redder with blood
			Wooden boundary that will have basic shape model spectators that jump up and down as well as cheer when a player is killed
			Stretch Goals
				(Basic blood  particles on hit, basic spark particles on block, basic sand particles on hit ground, and basic wood chunks on hit)
				(Slow motion will have greying visual effect)
	Audio style
			Royalty free Viking or Celtic music
	Interface sketches
			Health
			Sword slicing UI (A little circle in the center which constrains the cursor, recognizes the direction offset, and translates it into angle of slice)
			Limb system outline if implemented
	Story/theme description
			Maybe Viking or Celtic themed
Three feature set targets:
	1.	the “low-bar “of you will create (this should still be a “complete game”)
			Single player with some slice-based goal.  Maybe defend against projectiles. 
	2.	a target that you expect to get done
			Multiplayer versus deathmatch
	3.	a desired high-bar if things go exceptionally well. Plan these out carefully, so that you can definitely achieve the first goal, and likely hit the second
			Powerups? Game modifiers (Super Speed) (Size increase or decrease after death or kill) (More players)
			More Interactions
			Slow motion mode (Well timed dodges or block: dodging or blocking player has 1 second to choose a retaliation strike position and the other player has to block from which side they think the attack will come) but this is a stretch goal
			Dodge mode (feet stay planted. Mouse moves on one plane, WASD moves forward, backward and side to side.)
			Armor System
			Limb System 
				Player made up of head, body, 2 arms, 2 legs
				Head
					Vital Point
					If cut through or off, player is killed
				Body
					Vital Point
					If cut through, player is killed
				Arm
					Non Vital Point
					If cut through or off, player is unable to use that arm
				Leg
					Non Vital Point
					If cut through or off, player will move slower and hop instead of walk
					If kicking is implemented, lose ability to kick

A timeline of what you need to accomplish and by when to complete your game on time. Look at the personal schedules, your classes and other projects, and plan accordingly.
	Nov 18. Slicing working runtime
	Nov 21. Models of Characters done
	Nov 25. Other Models done
	Nov 28. Movement and Interaction Scripts written
	Dec 2. Sound, Particles, other minor features
	Dec 5. Title Screen
	Dec 9. Multiplayer implementation
	Dec 12. Fine tune and turn in

