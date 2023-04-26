import { Component, OnInit } from '@angular/core';
import { GameType } from '../enums/gameType';
import { Game } from '../Models/game';
import { GameService } from '../Services/game.service';

@Component({
  selector: 'app-game',
  templateUrl: './game.component.html',
  styleUrls: ['./game.component.scss']
})
export class GameComponent implements OnInit {

  public name: string;
  public gameType: GameType;
  public startDate: Date;
  public endDate: Date;

  game: Game = {
    name: '',
    gameType: GameType.Crusade,
    startDate: new Date(),
    endDate: new Date()
  };

  gameTypes = Object.values(GameType);


  constructor(
    private _gameService: GameService,
  ) { }

  ngOnInit(): void {
  }

  createGame() {
    this._gameService.addGame(this.game).subscribe(
      response => {
        console.log('Game added successfully!', response);
      },
      error => {
        console.error('Error adding game:', error, this.game);
      }
    );
  }

}
