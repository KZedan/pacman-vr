Day 1 : 
-Decided on augmented reality children's book app running on unity with vuforia AR package
-Built simple augmented reality app of  3d polygon characters appearing when image is tracked by mobile phone camera
-Received feedback from Alice on project: worries that unity projects are hard to debug and that there might not be enough 
manual programming. She also felt our project didn't have a clear enough end-goal

Day 2 :
-beginning of day decide to pivot to VR pacman game
-split into two teams
-Kay , kareem and marvin maze team  created pacman maze environment in unity
-james and ian responsible for VR move-by-looking
-early afternoon , ian finds solution for VR move-by-looking
-kareem and jamie set up github with unity gitignore after many git conflicts and errors
-maze and move-by-looking merged
-attempted to deploy to android phone : built , ran and displayed well but did not move
-retro decided priorities

Day 3:
-beginning of day wrote down user stories on trello and decided priorities, ate marvin's late donuts
-kay had developed  golf balls that disappear on touch and trump enemy that chases player overnight
-main to-dos for the day : create UI to control game flow i.e. start game screen, work on trump ghosts/coins,
fix deployment bug from yesterday
-kareem and jamie on UI team worked out button selection/script activation from viewing for use in menus, found more stable
VR camera setup
-kay, marvin and ian on ghost team
-Kay progressed on ghost AI
-marvin and ian developed teleporter for the arena
-marvin started background music
-kay and jamie deployed to mobile, can move but introduced display bug
-kay , marvin, jamie and ian deployed marvin and ian's changes to mobile. was able to move but could walk through walls, 
big pauses, teleporters not present, performance deterioated with time. probably a result of head camera set up not working 
well
-kareem progressed towards start screen
-retro decided priorities for tomorrow : UI , points/lives/die on trump touch
-last hour had problems with git and merges, attempted to get Kay up to date eventually succeeded. recognised need to either 
alter workflow , e.g. after developing a feature, make sure to pull the latest master then add your changes before trying 
to pull request and merge your branch to tryand minimise time-costing merge conflict resolutions
-retro decided priorities for tomorrow

Day 4:
-Kay fixed display issue on android and added random sounds to the trump enemies
-Ian wrote a score counter and dropped down lay out of pacman golfballs, but his unity became unstable
-Kareem developed start scene , jamie helped with the clicking and scene transition
-jamie and kareem started on the pause menu 
-marvin started sounds and portal graphic and life system

-IMPORTANT: much of our afternoon was eaten up trying to resolve merge conflicts and trying to quarantine instability in 
the versions. Agreed that our workflow needs to change drastically. branching and merging represents too big of a time risk.
we agreed that the work flow should be: 1. pairs/individuals explore and develop changes on their own computer. when they are
confident they've built a feature well which tests well on their own computer, they record the steps they needed to do 
to build the feature and redo that steps on a designated safe , deployment laptop and if it deploys successfully, push
to master. merge conflicts and unity instability are eating up too much of our time. We might even need to rebuild the
project from scratch and quickly repeat all the steps of the things we've already worked out. the steps that would be 
very time consuming even if the steps are fully understoof would be rebuilding the maze and rebuilding ball pattern, but
perhaps since those are gameobjects they can be transferred or imported without risking transferring the instability.
