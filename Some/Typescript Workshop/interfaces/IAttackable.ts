import { Creature } from "../models/abstract/creature";

export interface IAttackable {
    damage: number;

    hit(otherCreature: Creature);
}