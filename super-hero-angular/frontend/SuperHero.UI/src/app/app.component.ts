import { Component } from '@angular/core';
import { SuperHero } from './models/super-hero';
import { SuperHeroService } from './services/super-hero.service';
import { Call } from '@angular/compiler';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  title = 'SuperHero.UI';
  superHeroes: SuperHero[] = [];
  superHeroToEdit?: SuperHero;
  editing: boolean = false;

  constructor(private superHeroService: SuperHeroService) {}

  ngOnInit(): void {
    this.superHeroService
      .getSuperHeroes()
      .subscribe((result: SuperHero[]) => (this.superHeroes = result));
  }

  initializeNewSuperHero(): void {
    this.editing = true;
    this.superHeroToEdit = new SuperHero();
  }

  editSuperHero(index: number): void {
    this.editing = true;
    this.superHeroToEdit = this.superHeroes[index];
  }

  cancelEditing(): void {
    this.editing = false;
  }

  updateSuperHeroList(superHeroes: SuperHero[]): void {
    this.superHeroes = superHeroes;
  }
}
