import { Creature } from "./abstract/Creature";
import { IAttackable } from "../interfaces/IAttackable";
import { IPet } from "../interfaces/IPet";
import { Alignment } from "../enums/Alignment";

export class Beast extends Creature implements IAttackable, IPet {
    public damage: number;
    public master: Creature;

    constructor(name: string, health: number, alignment: Alignment, damage: number) {
        super(name, health, alignment);
        this.damage = damage;
    }

    hit(otherCreature: Creature) {
        otherCreature.takeHit(this.damage);
    }
}