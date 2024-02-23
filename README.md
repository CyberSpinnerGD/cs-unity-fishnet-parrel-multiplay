
# Multi-Play Utility // Fishnet ParrelSync

## Overview
This utility automates multiplayer Unity testing with FishNet and ParrelSync by launching and configuring editor instances as server or clients by one click.

## Requirements
- Unity Editor
- FishNet Networking
- ParrelSync

## Setup
1. Ensure FishNet and ParrelSync are properly set up in your Unity project.
2. Place the provided scripts in the `Assets/Editor` directory of your Unity project.
3. Modify the PowerShell script as needed to match your project's specific window titles.

## Usage
- Use the `Multi-Play/RUN` menu item or press `Ctrl+Shift+M` to execute the PowerShell script.
- The script identifies Unity editor instances by window titles and sends keyboard commands to control them.
