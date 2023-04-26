import { GameType } from "../enums/gameType";

export interface Game {
  id?: string;
  name: string;
  gameType: GameType;
  startDate: Date;
  endDate: Date;
}
