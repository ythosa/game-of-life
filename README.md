<br>

<h1 align="center">Game of Life</h1>
<div align="center">

[![Badge](https://img.shields.io/badge/Uses-CSharp-brightgreen.svg?style=for-the-badge&logo=c-sharp&logoWidth=15&logoColor=brightgreen)](https://docs.microsoft.com/ru-ru/dotnet/csharp/)
[![Badge](https://img.shields.io/badge/Open-Source-important.svg?style=for-the-badge&logo=open-source-initiative&logoWidth=15&logoColor=orange)](https://ru.wikipedia.org/wiki/Open_source)
[![Badge](https://img.shields.io/badge/Made_with-Affection-ff69b4.svg?style=for-the-badge&logo=ko-fi&logoWidth=15&logoColor=ff69b4)](https://i.pinimg.com/736x/d7/5f/e3/d75fe32e7af10c3ed0bafb98816a6ce2.jpg)
    
</div>

<br>

## Description
*	Conway's Game of Life realisation implemented on C# .NET Framework;
*	The application includes:
	*	resolution and density settings,
	*	generation of the first generation,
	* 	generation number counter,
	*	delete and add new cells by clicking the right and left mouse buttons respectively.
*	You can clone this repository and run it for example from Visual Studio if you have .NET Framework on your computer. :3

## What is Game of Life?
The Game of Life, also known simply as Life, is a cellular automaton devised by the British mathematician John Horton Conway in 1970. It is a zero-player game, meaning that its evolution is determined by its initial state, requiring no further input. One interacts with the Game of Life by creating an initial configuration and observing how it evolves. It is Turing complete and can simulate a universal constructor or any other Turing machine.

## Rules
The universe of the Game of Life is an infinite, two-dimensional orthogonal grid of square cells, each of which is in one of two possible states, live or dead, (or populated and unpopulated, respectively). Every cell interacts with its eight neighbours, which are the cells that are horizontally, vertically, or diagonally adjacent. At each step in time, the following transitions occur:

1. Any live cell with fewer than two live neighbours dies, as if by underpopulation.
2. Any live cell with two or three live neighbours lives on to the next generation.
3. Any live cell with more than three live neighbours dies, as if by overpopulation.
4. Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.

These rules, which compare the behavior of the automaton to real life, can be condensed into the following:

1. Any live cell with two or three live neighbours survives.
2. Any dead cell with three live neighbours becomes a live cell.
3. All other live cells die in the next generation. Similarly, all other dead cells stay dead.

The initial pattern constitutes the seed of the system. The first generation is created by applying the above rules simultaneously to every cell in the seed; births and deaths occur simultaneously, and the discrete moment at which this happens is sometimes called a tick. Each generation is a pure function of the preceding one. The rules continue to be applied repeatedly to create further generations.

## Links
*	More info about Game of Life: https://en.wikipedia.org/wiki/Conway%27s_Game_of_Life
*	What is cellular automaton: https://en.wikipedia.org/wiki/Cellular_automaton

## How it looks
<div align="center">
	<img src="https://github.com/Ythosa/GameOfLife/blob/master/assets/Application.jpg" alt="Application screenshot." />
</div>

<br>

<div align="center">
  Copyright 2020 Ythosa
</div>
