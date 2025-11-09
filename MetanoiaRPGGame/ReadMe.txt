Class Hierarchy:

System.Object
   ├── Character: Used by - FormCharacterSelection, FormGameMode, FormLevelUp
                  Purpose - Stores player stats (HP, Attack, MP, etc.) and handles XP/level-up logic.
   ├── Monster: Used by - FormMonsterSelection, FormGameMode
                Purpose - Stores monster stats (HP, Attack, Defense, XP reward).
   └── System.Windows.Forms.Form
           ├── FormMainMen: Opens CharacterSelection.
                                Purpose: Serves as the start screen (Play, Exit).
           ├── FormCharacterSelection: Creates and passes a Character object to FormMonsterSelection.
                                Purpose: Player chooses Knight, Mage, or Priest.
           ├── FormMonsterSelection: Creates and passes a Monster object to FormGameMode.
                                Purpose: Player chooses which monster to fight.
           ├── FormGameMode: Uses both Character and Monster.
                                Purpose: Handles battle logic (Attack, Special Attack, Mana, XP).
           └── FormLevelUp: Displays new stats after battle.
                                Purpose: Shows updated level and stats when XP threshold is reached.

Form Flow:

FormMainMenu
    ↓
FormCharacterSelection
    ↓
FormMonsterSelection
    ↓
FormGameMode (Battle)
    ↓
FormLevelUp (if XP threshold reached)
    ↓
Back to CharacterSelection (next round)

🧙 Credits

Developed by: Bryan M. Butel
Designed by: Erik Isaac Taduran
Other team members: Mangifico Lomibao
                  : Lj Ann Andrada
                  : Reiwen Cruz
                  : Lai Athena De Vera
Course: Computer Programming (C#)
Instructor: Sir Van Beaufort Garcia
School Year: 2025 - 2026
