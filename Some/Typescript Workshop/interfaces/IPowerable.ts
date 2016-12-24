import { Creature } from "../models/abstract/Creature";

export interface IPowerable {
    applyPower(otherCreature: Creature);
}