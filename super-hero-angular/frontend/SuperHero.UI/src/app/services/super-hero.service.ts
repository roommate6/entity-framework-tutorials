import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { SuperHero } from '../models/super-hero';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs/internal/Observable';

@Injectable({
  providedIn: 'root',
})
export class SuperHeroService {
  private url = 'SuperHero';

  constructor(private http: HttpClient) {}

  public getSuperHeroes(): Observable<SuperHero[]> {
    return this.http.get<SuperHero[]>(`${environment.apiUrl}/${this.url}`);
  }

  public createSuperHero(superHero: SuperHero): Observable<SuperHero[]> {
    return this.http.post<SuperHero[]>(
      `${environment.apiUrl}/${this.url}`,
      superHero
    );
  }

  public updateSuperHero(superHero: SuperHero): Observable<SuperHero[]> {
    return this.http.put<SuperHero[]>(
      `${environment.apiUrl}/${this.url}`,
      superHero
    );
  }

  public deleteSuperHero(superHero: SuperHero): Observable<SuperHero[]> {
    return this.http.delete<SuperHero[]>(
      `${environment.apiUrl}/${this.url}/${superHero.id}`
    );
  }
}
