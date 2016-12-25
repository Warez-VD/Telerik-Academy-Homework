import { Creature } from "./Creature";
import { IPet } from "../../interfaces/IPet";
import { IPowerable } from "../../interfaces/IPowerable";
import { Power } from "../../models/Power";
import { PowerType } from "../../enums/PowerType";
import { Alignment } from "../../enums/Alignment";
import { IAttackable } from "../../interfaces/IAttackable";

export abstract class SuperCreature extends Creature implements IAttackable, IPowerable {
    public pets: IPet[];
    public powers: Power[];
    public damage: number;

    constructor(name: string, health: number, alignment: Alignment, damage: number, ...powers: Power[]) {
        super(name, health, alignment);
        this.damage = damage;
        this.powers = powers;
    }

    applyPower(otherCreature: Creature) {
        this.powers.forEach(power => {
            if (power.type === PowerType.helpful &&
                this.alignment === otherCreature.alignment ||
                otherCreature.alignment === Alignment.Neutral) {
                otherCreature.health *= 2;
            } else if (power.type === PowerType.destructive &&
                this.alignment !== otherCreature.alignment) {
                otherCreature.health -= 10;
            }
        });
    }

    hit(otherCreature: Creature) {
        otherCreature.takeHit(this.damage);
    }
}