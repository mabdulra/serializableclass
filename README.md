# Serializable Classes for Unity
Basic serializable classes for use in Unity game projects. Written in C#.

The core intent of these classes is to serve as save data for an entire game's state. The original project this was designed for was a JRPG with four protagonists, akin to the original Final Fantasy on the NES. Players are stored in their own serializable class as well. The overall Game class can be written to and read from a binary file that is handled by a binary formatter. It will save and load from Unity's default path for persistent data.

Future features to add:
 - handling multiple save files
