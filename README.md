# TF2 Weapon Specific Crosshairs by HbiVnm
TF2WSC (Team Fortress 2 Weapon Specific Crosshairs) is a client-side solution to automating the installation and customization of crosshairs in Team Fortress 2.

Preview image of first beta version:
![Preview image of TF2WSC.](https://i.imgur.com/rH8tulZ.png)

## What does TF2WSC specifically do?
When installing a config through TF2WSC, a new folder in `tf\custom` called `TF2WeaponSpecificCrosshairs` will be created. This folder will contain crosshair materials and script files necessary for your chosen weapon specific crosshairs.

## Download
Check out the releases and download [here](https://github.com/hbivnm/TF2WeaponSpecificCrosshairs/releases).

## Tutorial
**NOTE:** If you already have an old custom crosshair folder in `tf\custom` rename it to `TF2WeaponSpecificCrosshairs`

1. Download the latest release found [here](https://github.com/hbivnm/TF2WeaponSpecificCrosshairs/releases).
2. Extract the folder named `TF2WeaponSpecificCrosshairs` to a directory of your liking.
3. Run TF2WSC and customize your crosshair config.
4. Hit Install/Update.
5. Set `cl_crosshair_file ""` in Team Fortress 2.

**NOTE:** Malwarebytes will report the executable as `MachineLearning/Anomalous.100%`, you will have to manually exclude the `TF2WeaponSpecificCrosshairs` folder to be able to use TF2WSC alongside Malwayrebytes. A more detailed explanation to this issue can be found [here](https://forums.malwarebytes.com/topic/271784-machinelearninganomalous100-all-my-c-projects/) explained by a Staff member on Malwarebytes forum.

## Planned features
- [ ] Add a "Help" button.
- [ ] Add current version label.
~~- [ ] Rename "Add to all" button.~~
- [x] TF2 Path input field saved inbetween sessions (currently resets to default `C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2`).
- [ ] Show/Hide console (state saved inbetween session).
- [ ] Read current config button.
- [ ] Add "Update TF2WSC" button for when update is available from repo.
- [x] Suggestion by Pijukazz: Add a button for adding a crosshair ONLY to selected class ("Add to *CLASS*").
- [ ] Suggestion by Pijukazz: Add no explosion.
- [x] Suggestion by Kanga: Buttons for "Add to all PRIMARY/SECONDARY/MELEE.
- [ ] Suggestion by depi: Double-clicking a weapon in the ListView should select it as "current weapon". (Not to self: add class listviewentry)
- [x] Make console read-only (thanks depi LOL)
### **Maybe** planned features
- [ ] Read from selected config.
- [ ] Progress bar.
- [ ] Easier to read/understand state of installation/update.
- [ ] Suggestion by Kanga: Add hitsounds and killsounds.

## Help / FAQ
**Q:** How do I add my own crosshairs to TF2WSC?

**A:** You can add your own crosshairs by copying the `.vmt`- and `.vft`-file to `\resources\materials` in TF2WSC. Once placed inside reload the crosshair list by clicking the arrows located in the top right corner.
***
**Q:** How do I change color of the crosshairs?

**A:** This is done through in-game commands `cl_crosshair_red`, `cl_crosshair_green` and `cl_crosshair_blue`.
***
**Q:** How do I change the size of the crosshairs?

**A:** This is done through in-game commands `cl_crosshair_scale`.
***

# Original idea
Credit where it's due, the original idea of weapon specific crosshairs in Team Fortress 2 (as far as I know) comes from a [teamfortress.tv thread](https://www.teamfortress.tv/30866/guide-weapon-specific-custom-crosshairs) by [joshuawn](https://www.teamfortress.tv/user/joshuawn).

# Icons (Fugue Icons 3.5.6)
Most icons used was provided by [Yusuke Kamiyamane](http://p.yusukekamiyamane.com/). Licensed under a [Creative Commons Attribution 3.0 License](https://creativecommons.org/licenses/by/3.0/).
