import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class FactionService {
  private apiUrl = 'https://localhost:7157/factions';

  constructor(private http: HttpClient) {}

  getFactions(): Observable<any> {
    return this.http.get<any>(this.apiUrl);
  }
}