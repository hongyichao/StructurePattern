﻿// See https://aka.ms/new-console-template for more information
using Flyweight;

Console.WriteLine("Hello, World!");

var sheet = new SpreadSheet();
sheet.setContent(0, 0, "Hello");
sheet.setContent(1, 0, "World");
sheet.setFontFamily(0, 0, "Arial");
sheet.render();