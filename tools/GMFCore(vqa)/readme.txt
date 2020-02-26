============================================================================
           Game Media Formats Core Filters Package v1.00		  
          A Few Words That Might Be Called "Documentation"       24 Aug 2004
============================================================================
                                             Copyright (C) 2004 ANX Software

============================================================================
 Overview
============================================================================

GMFCore.ax is the package of freeware DirectShow filters aimed at supporting 
several game media (audio and video) formats. The word "support" means here 
that you can open the supported game media files in any program capable of 
automatic DirectShow filter graph building and do with those files whatever 
the program allows you to do. The simplest (and I suppose the most 
wide-spread) way to exercise the DirectShow filters' capabilities is to play 
back audio/video files in your favorite DirectShow-aware media player. To 
name a few: Windows Media Player (WMP), BSPlayer, SASAMI2K, ZoomPlayer, 
CrystalPlayer, WinAMP (with DirectShow input plug-in).
Also, you can convert the supported files to convenient AVI/WAV using 
DirectShow GraphEdit and you can even convert to compressed AVI/WAV (which 
is especially crucial in case of video files).
Finally, if you are a DirectShow developer, you can add the filters to your 
filter graphs to play back, convert, process, edit the supported media formats.
A good destination to proceed towards for a developer is the software capable 
of playing back game media files right from the game resources (much like GAP 
does). To implement this all you need is to make the source filter capable 
of reading data from the game resource files (and, of course, you should 
supply a convenient GUI and file scanning capabilities). Once the source 
filter is ready to output the game media stream, all remaining work is 
handled by the filters contained in this package.

The filters are developed by me, Valery Anisimovsky, the author of another 
multimedia software, Game Audio Player and are Copyright (C) 2004 ANX Software.
In some filters I used the source code developed by Mike Melanson and
Dr. Tim Ferguson who also contributed to FFmpeg library so that you can watch 
the same game movies in Linux media players MPlayer and xine. HNM/HNS playback 
is provided by the Cryo decoder DLLs (CM6_*x16.dll) -- I hope Cryo programmers 
(in particular, Pascal Urro) would not mind this (at least, too much)...

============================================================================
 How To Use
============================================================================

First, register the filters by executing command "regsvr32 GMFCore.ax" in 
the command line. The batch file register.bat included with the GMFCore.ax 
does the same. You may unregister the filters later by executing another 
command "regsvr32 /u GMFCore.ax" or by running unregister.bat. Note that 
after registring filters the system expects the file GMFCore.ax to be available 
in the directory it was registered in. Be sure not to move it to other location
(or re-register it after move). If you intend to play HNM/HNS movies, you should 
also copy all "CM6_*x16.dll" files to the directory GMFCore.ax resides in. These 
DLLs may be found in the Cryo games somewhere near the game EXE.

Second, you should configure your favorite media player to open the supported 
files. In fact, this step is optional, since after registration you can open 
the supported files using e.g. File|Open menu item in the player or by issuing 
the command like "bsplay.exe movie.vqa". But each really nice media player 
(like BSPlayer) allows the user to set the file extensions to which it assigns 
itself, so that when you double-click on the correspondent file in Windows 
Explorer (or Total Commander), the system runs the player for that file. 
It's easy and convenient, isn't it? So, do not hesitate to go to your player's 
configuration dialog(s), find a section called like "File types" (or 
"File associations") and add the following extensions to the supported 
extensions list: .APC, .CIN, .FST, .HNM, .HNS, .ROQ, .VQA, .MVE, .MV8.
Note that this step IS REQUIRED for WinAMP and the right place to add the 
extensions is DirectShow decoder plug-in configuration dialog.
Unfortunately, some players do not allow setting custom extensions (and are 
not intelligent enough to find those extensions themselves in the registry). 
That is not a problem, in fact: just open the file you want to play and the 
player will recognize it without a help of its extension (of course if the 
player uses automatic filter graph building, which is a common behaviour of 
DirectShow-aware players).

Third, if you experience any problems, do not hesitate to access the filters' 
property pages (the way to do this depends on the player you use, e.g. in 
BSPlayer the property pages are found under Options|Filters menu item).
All GMFCore splitter/parser filters allow you to configure their streaming 
settings and some filters provide their own (format-specific) settings in 
addition. The filters contained in this package are all named following the 
common rule: "ANX <Format Name> <Goal Description>", e.g. "ANX HNM Splitter" 
and "ANX ROQ Video Decompressor".

============================================================================
 Supported Game Media Formats
============================================================================

The filters included in this package provide the support for the following 
game media formats (used in the listed games):
1) Cryo Interactive APC audio format:
    Atlantis 2
    Odyssee
    Chine
    (maybe other Cryo games)
2) Id Software CIN video format:
    Quake 2
    (maybe other Id games?)
3) FutureVision FST video format (currently audio only):
    Harvester
4) Cryo Interactive HNM/HNS video format:
    Atlantis 2
    Odyssee
    Chine
    (maybe other Cryo games)
5) Id Software ROQ video format:
    Quake 3
    American McGee's Alice
    Return to Castle Wolfenstein
    Medal of Honor: Allied Assault
    Jedi Knight 2: Jedi Outcast
    (maybe other games based on Q3 engine)
6) Westwood Studios VQA video format:
    Legend of Kyrandia 3: Malcolm's Revenge
    Command & Conquer
    Command & Conquer: Covert Operations
    Red Alert
    Red Alert: The Aftermath
    Red Alert: Counterstrike
    Tiberian Sun
    Tiberian Sun: FireStorm
    Lands Of Lore 2
    Lands Of Lore 3
    Blade Runner
    Dune 2000
    Nox
    (maybe other Westwood games)
7) Interplay Productions MVE video format:
    Descent 2
    Descent 2: Vertigo
    Descent 3
    Descent: Freespace (?)
    Descent to Undermountain (?)
    M.A.X. 2 (?)
    MDK
    MDK 2 (?)
    KingPin
    Star Trek: Starfleet Academy (?)
    Conquest of the New World
    Dungeon Master 2
    Fallout
    Fallout 2
    Planescape: Torment
    Baldur's Gate
    Baldur's Gate - Tales of the Sword Coast (?)
    Baldur's Gate II: Shadows of Amn
    Icewind Dale
    IceWind Dale - Heart of Winter
    (surely many other Interplay games)

============================================================================
 A Few Pieces Of Advice
============================================================================

By default, external APC soundtracks for HNM files are searched in ".\cine\" 
directory (where the dot "." stands for the directory HNM file is located in).
This policy follows the way those APC files are placed on the game CDs in 
Atlantis 2. If you dislocated the HNM and/or APC files in some other way, set 
the correspondent option on the HNM splitter property page. The same issue 
is relevant for ROQ movies (which may have MP3 external sountracks), but the 
default directory for their MP3 soundtracks is just "." (ROQ file directory), 
which is, again, the way those files are located in Alice and MOHAA.

For many games, you have first to extract the media files from the game 
resources to be able to play them. HNM, HNS, APC, CIN, FST files are (as a 
rule) stand-alone files and do not require any extraction. On the opposite, 
ROQ and VQA files are usually contained in game archives (PK3 and MIX 
respectively). PK3 files are regular ZIP archives, so you should have no 
problem extracting the files from them, and MIX archives can be handled by 
RA-MIXer, XCC Mixer, etc. MVE files are often either stand-alone files or 
contained in EXE or some kind of resource files --  you can use FMV-Extractor 
to extract MVEs from these. Fallout contains MVE movies inside DAT archives, 
which can be handled by F2RE, undat and other Fallout tools.
Finally, aforementioned GAP can search and extract VQAs and MVEs from any 
resource file.

============================================================================
 Known Problems
============================================================================

1) 8-bit (palettized) video playback produces black picture when the desktop 
is in 8-bit (256 colors) video mode. This seems to be the problem of the 
DirectShow video renderer being added to the graph by default. Just watch 
those movies in 16-bit (hi-color) or 24-/32-bit (true color) mode.
2) FST movie support is limited to audio only.
3) HNM/HNS movies playback is choppy when the desktop is in 16-bit video mode.
The problem can be solved by configuring the HNM video decompressor filter to 
require color space converter for RGB output.
4) In HNM movies of Odyssee the audio volume goes to very low (almost 
unperceivable) level at the beginning of the movie. I was not able to figure 
out the reason of this (HNM/HNS movie soundtracks in other Cryo games play 
fine while using the same audio format).
5) In some HNM movies there is a serious audio/video synchronization 
problem related to the fact no frame rate is specified in HNM file 
(thus, the actual frame rate is estimated). When the estimation is inaccurate 
it results in utterly choppy playback and playback stallation.
6) VQA seeking is implemented only for HiColor VQAs with PCM, WS ADPCM or no 
soundtrack and is experimental. However, in some players it works for some 
other VQAs (blame it on the player) but shows artifacts (it should not work 
anyway). Proper seeking works only to the nearest preceding full codebook 
frame.
7) Most of the splitters/parsers do not support seeking (some do not even 
support stream duration reporting). That is a limitation of the media formats 
themselves, not the filters -- they just do not contain necessary information 
for seeking or do contain unseekable compressed streams. The only exception 
is VQA for which the seeking is experimental.
8) Gradient and compressed palettes in MVE videos are (in theory) supported, 
but the support is not tested as I've got no MVE movies containing such 
palettes.
9) Variable MVE video dimensions are not supported. If the MVE movie changes 
image dimension on-the-fly, you'll either see cropped image or experience 
player crash.

============================================================================
 Credits
============================================================================

The detailed credits (including each credited person's contribution, e-mail 
and URL (if any)) can be found in the filter's property pages accessible in 
the player after the filter is instantiated (that is, a file of its type is 
being played or processed).

Here I'd just like to thank several people which provided me with the 
inspiration I wouldn't have otherwise and contributed invaluably (in no 
particular order, of course):
Valentin Efimov
Gordan Ugarkovic
Mike Melanson
Dr. Tim Ferguson
Alexey Schepetilnikov
Aleck Horn

============================================================================
 DISCLAIMER
============================================================================

This software comes with NO WARRANTY. You use it at YOUR OWN RISK.
The author of this software may not be kept responsible for any damage
caused by any usage of this software.

This software is meant only as an addition to the wonderful games whose
sound/music/speech/video files it deals with. It's NOT meant to lower those
games value IN ANY WAY. The creators of the supported games ARE NOT
RESPONSIBLE for this software and they should not be contacted in case of
any problems related to this software.
