import { PowerType } from "../enums/PowerType";
import { Creature } from "../models/abstract/Creature";

export class Power {
    public type: PowerType;

    constructor(type: PowerType) {
        this.type = type;
    }
}