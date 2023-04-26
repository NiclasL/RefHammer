import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class StratagemService {
  private apiUrl = 'https://localhost:7157/stratagems';

  constructor(private http: HttpClient) {}

  getStratagems(): Observable<any> {
    return this.http.get<any>(this.apiUrl);
  }
}
