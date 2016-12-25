import { SuperCreature } from "./abstract/SuperCreature";
import { Alignment } from "../enums/Alignment";

export class Superhero extends SuperCreature {
    constructor(name: string, health: number, alignment: Alignment, damage: number) {
        super(name, health, alignment, damage);
    }
}