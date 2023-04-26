import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Game } from '../Models/game';
import { GameType } from '../enums/gameType';

@Injectable({
  providedIn: 'root'
})
export class GameService {
  private apiUrl = 'https://localhost:7157/api/Games';

  constructor(private http: HttpClient) {}

  addGame(game: Game) {
    return this.http.post<Game>(this.apiUrl, game);
  }

  getGames() {
    return this.http.get<any>(this.apiUrl);
  }
}

