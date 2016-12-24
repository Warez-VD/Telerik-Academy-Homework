import { Creature } from "./models/abstract/Creature";
import { IAttackable } from "./interfaces/IAttackable";

 export class Engine {
    public firstFighter: Creature & IAttackable;
    public secondFighter: Creature & IAttackable;

    constructor(firstFighter: Creature & IAttackable, secondFighter: Creature & IAttackable) {
        this.firstFighter = firstFighter;
        this.secondFighter = secondFighter;
    }

    public start() {
        while (true) {
            this.firstFighter.hit(this.secondFighter);
            if (this.secondFighter.health <= 0) {
                break;
            }
            console.log("First fighter hit second fighter");
            console.log(`First fighter health: ${this.firstFighter.health}`);
            console.log(`Second fighter health: ${this.secondFighter.health}`);
            this.secondFighter.hit(this.firstFighter);
            if (this.firstFighter.health <= 0) {
                break;
            }
            console.log("Second fighter hit first fighter");
            console.log(`First fighter health: ${this.firstFighter.health}`);
            console.log(`Second fighter health: ${this.secondFighter.health}`);
        }
    }
}