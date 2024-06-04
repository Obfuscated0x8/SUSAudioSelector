![Build](https://github.com/Obfuscated0x8/SUSAudioSelector/workflows/MSBuild/badge.svg)
![Release](https://github.com/Obfuscated0x8/SUSAudioSelector/workflows/Release/badge.svg)

# SUSAudioSelector

This program is intended to quickly and easily map audio files to Sliding Universal Score (`.sus`) files for rhythm games. It allows you to select either a single folder containing all of a particular song's resources (jacket, audio file, .sus charts, etc.) or a folder of song folders if you have bulk edits to make.

If you have many versions of the audio (such as covers) you can quickly preview them in the app by clicking them in the Covers list. Once you've found the correct audio file, you can click the buttons at the bottom to map it to either ALL of the `.sus` files in the folder or just the selected `.sus` file from the list above it.


# TODO:

## Short Term
- [ ] Clean up the code (seriously its a disaster)
- [ ] Add a method to create offsets
- [ ] Add support for `.ugc` files

## Hard Maybes
- [ ] Add a method for converting `.sus` files to `.ugc` files
- [ ] Add a method for adding the BGMPRV (menu preview). This requires setting `#REQUEST "x_ug_preview_range <startSec>,<endSec>"` in `.sus` files for working in UMIGURI (this is specific to UMIGURI, `.sus` normally doesn't support previews).