import { Injectable } from '@angular/core';
import { SuperHero } from '../models/super-hero';

@Injectable({
  providedIn: 'root'
})
export class SuperHeroService {

  constructor() { }

  public getSuperHeroes() : SuperHero[] {
    let hero = new SuperHero();
    hero.id = 1;
    hero.name = "Max Man";
    hero.firstName = "Sabin";
    hero.lastName = "Stan";
    hero.place = "Bucharest";

    return [hero];
  }
}
