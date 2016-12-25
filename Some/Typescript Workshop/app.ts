import { Engine } from "./engine";
import { Superhero } from "./models/Superhero";
import { SuperVillian } from "./models/SuperVillain";
import { Alignment } from "./enums/Alignment";

let fighterOne = new Superhero("Smith", 50, Alignment.Good, 15);
let fighterTwo = new SuperVillian("John", 35, Alignment.Evil, 20);
let engine = new Engine(fighterOne, fighterTwo);
engine.start();