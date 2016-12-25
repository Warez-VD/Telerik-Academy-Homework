import { ITakeableHit } from "../../interfaces/ITakeableHit";
import { Alignment } from "../../enums/Alignment";

export abstract class Creature implements ITakeableHit {
    public name: string;
    public health: number;
    public alignment: Alignment;

    constructor(name: string, health: number, alignment: Alignment) {
        this.name = name;
        this.health = health;
        this.alignment = alignment;
    }

    takeHit(damage: number) {
        this.health -= damage;
        if (this.health < 0) {
            this.health = 0;
            console.log(`${this.name} is dead!`);
        }
    }
}