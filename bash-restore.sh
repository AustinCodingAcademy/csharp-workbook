#!/bin/bash

find . ! -path './.git' ! -path './.vscode' -maxdepth 1 -mindepth 1 -type d -exec bash -c "cd '{}' && dotnet restore" \;
