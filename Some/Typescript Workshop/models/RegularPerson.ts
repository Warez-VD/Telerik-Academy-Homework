import { Creature } from "./abstract/Creature";
import { IPet } from "../interfaces/IPet";
import { Alignment } from "../enums/Alignment";

export class RegularPerson extends Creature implements IPet {
    public master: Creature;

    constructor(name: string, health: number, alignment: Alignment) {
        super(name, health, alignment);
    }
}