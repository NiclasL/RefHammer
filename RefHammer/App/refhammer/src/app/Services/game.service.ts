import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Game } from '../Models/game';

@Injectable({
  providedIn: 'root'
})
export class GameService {
  private apiUrl = 'https://localhost:7157/api/Games';

  constructor(private http: HttpClient) {}

  addGame(game: Game) {
    console.log(game);
    return this.http.post<Game>(this.apiUrl, game);
  }
}

