# game.md

Mana-Shock is a swords & sorcery spin on the system shock lineage of games,
albeit with a smaller scope. With the goal of following in the steps of the
original system shock, avoiding RPG stats for the sake of RPG stats.

That is to say, this is an immersive sim, and expects a certain level of effort
from the player

- The game is played from the first-person perspective
  - Melee combat will be an element, but will not be the focus of the combat as
  FPS melee combat is notoriously difficult to get right

- The game can not be paused, and by default the player can not choose to load
a save (only continue where left off). Robust auto save is necessary.
Optionally the player can enable traditional saving and loading.

- Early on the player will find a companion, a faerie creature from another
world. This companion will help explain things to the player, but only at the
players request. Generally speaking the game will be hands off when it comes to
teaching the player the game.
  - There will be more of these creatures later, and probably some mild drama
  about this fella helping you out

- Codex: collect lore bits, and information provided by your companion here

- Quests / missions
  - Collect audio logs
  - No quest log, quests are implicit. The player's companion also doesn't tell
  the player what to do
  - In-game notepad and camera, while the game does not handle quests for the
  player, the game encourages the player to take pictures and notes

- Navigation
  - The player can find a compass (a permanent upgrade)
  - The player can find a flat magic paper map (a permanent upgrade)
  - The player can find a holographic magic map (a permanent upgrade)
  - The player can find spells that allows seeing through walls
  - Different levels of the castle have a distinct look, and music
  - There are signs posted around the castle, this is a castle run by a large
  staff, not an incomprehensible labyrinth (or at least it once had a large
  staff)

- Stats
  - Stat values: crippled, inept, capable, excellent, god-like
  - Strength
  - Intelligence
  - Mana capacity
  - Constitution (health)
  - Endurance
  - Mental durability
  - Speed
  - Dexterity
  - At the start of the game the player pick 2 to be 'capable' at, all other
  stats are 'inept'
  - Most likely what these stats are, and what they do will change a lot
  - Player does have 'stats' but they're not numbers that go up forever, rather
  each stat has five tiers (crippled, inept, capable, excellent, god-like)
  - Without magic augmentation it is not possible to achieve a god-like stat,
  and even then the effects are usually temporary
  - Most of the character's stats will be inept, with a few chosen stats
  elevated to capable
  - To avoid encouraging boring grind, the player can not grind a stat up, but
  must unlock it through certain quests or milestones
  - These stats can be affected by ailments like exhaustion, which can cripple
  intelligence and strength
  - Optionally players can choose to have all stats 'inept', this should be a
  fully possible play through
  - The intent of stats is that being capable in any one will open up certain
  gameplay possibilities and conveniences

- Exhaustion: There is no hunger or thirst the player must manage, but the
character does need to sleep from time to time.
  - Not sleeping with have gradually increasing de-buffs. Once exhaustion
  reaches a critical level, the player's chances to collapse drastically
  increase. If the player is in danger or under attack and collapses, this may
  kill the player. Taking damage while knocked out has a chance to wake up the
  player from the pain.
  - De-buffs include, but are not limited to: poor vision (blurry at the edge
  of view, with darkening vignette over time), failing to register sounds (some
  sounds are muffled), hallucinations, loss of strength (damage reduced, can no
  longer move heavy objects), loss of thought (magic capabilities reduced,
  puzzles are more difficult)
  - In a stressful situation, adrenaline will temporarily push aside
  exhaustion, but this effect is temporary, and running on adrenaline for
  extended period of time will injure the player
  - Managing this requires the player to secure areas and barricade a room in
  order to rest. Nothing stops the player from sleeping whenever and wherever
  they want, but a bit of bad luck can have dire consequences

- Other active effects:
  - Poison
  - Burning
  - Freezing
  - Acid
  - Parasite
  - Paralysis or partial paralysis
  - Loss of limbs and digits
  - Loss of body (spirit is separated from body, can happen when player under
  takes significant psychic damage)
  - Healing
  - Barrier
  - Mind ward (protection from psychic damage)
  - Vision impairment
  - Hearing impairment
  - Potion effects (strength, seeing through walls, super hearing, speed
  (attack and movement speed up), etc)

- Level design
  - The castle itself is very tall, the player must traverse it via portals,
  elevators, stairs, and flying aids
  - The castle is a town in of it self (not a bigger on the inside magic deal,
  its just really big)
  - The game is non-linear, in other words the player can stumble into a lot of
  pain if they are not careful
  - breaking sentries to gain control of levels, which will allow access to
  gateways

- Item persistence
  - All items dropped, placed, stored, etc are persistent
  - In this way the player can set up traps, store rooms for loot stashes
  - Corpses and destroyed props also persist
  - In the event that an item clips out of playable space, it should be
  deposited in a lost & found. The player needs to discover this.

- Creature & Entity AI
  - All creatures and entities have intentionally simple AI
  - Players should be able to learn and most importantly predict what something
  will do
  - Creatures and entities that are actively hostile to the player will chatter
  regularly to give the player feedback as to their state
  - AI respects stealth mechanics, unless the entity has super natural
  capabilities
  - There are some entities that can and will break these rules, usually
  creatures with higher levels of intellect. There should be clues given to the
  player prior to their encounter with such creatures that the danger is much
  higher. Eg note, audio logs of previous people encountering the creature.
    - It is not necessary for the game to force feed the player this
    information, if the player choose to ignore all clues, they can discover
    the challenge for them self

- Spell puzzles
  - Unlocking spells requires solving certain puzzles
  - If the player happens to know a spell from a previous play through on that
  save, they can acquire it much earlier
  - Normally a player comes across a partially completed spell, and must solve
  it / complete it
  - If the player has 'mana paper', then they can write a spell from scratch,
  with various consequences
  - Writing involves drawing various runes, and feeding mana into the mana
  paper
  - Attempting to cast the spell uses mana and consumes the 'mana paper' (this
  prevents brute forcing)
  - Players can force cast an unsolved spell, but this may lead to a successful
  new spell or backfire
    - If they are writing from scratch, they are required to force cast
  - When a spell is cast, it is etched into their spell book (good or bad)
  - If a spell is already in their spell book, the game will not allow the
  player to cast, and instead pull up the spell book and point the player to
  the existing spell
  - Technically each spell is effectively a hashcode into a library of spells,
  and anti-spells
  - There are spells that will not trigger the "puzzle solved" events, effects,
  sounds, ect, but can still be forced to cast. These are powerful anti-spells,
  and can really break the game
    - Completing the game on new game+ will reveal a new room with a completed
    anti-spell, and ramblings of a mad man discussing his forbidden area of
    research

- Timeline progression
  - When the player hits certain milestones, a timeline progression will be
  triggered
  - Progressions cause the *effects* of certain events in the world, but we
  don't actually simulate the event fully, just apply the consequences if
  possible
  - It important to remember that the player has very few restrictions, so
  timeline progressions need to be applied carefully, especially in areas where
  it is likely the player has been and changed the state of the world. Keep in
  mind that persistence of corpses, items, and state is critical to the
  gameplay, so we don't want to undo any of the player's actions (unless it is
  to prevent soft locking the player's progression)

---

Copyright CosmicBagel 2024
