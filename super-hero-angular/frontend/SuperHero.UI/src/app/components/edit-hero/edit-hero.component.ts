import { Component, Input, OnInit, Output, EventEmitter } from '@angular/core';
import { SuperHero } from 'src/app/models/super-hero';
import { SuperHeroService } from 'src/app/services/super-hero.service';

@Component({
  selector: 'app-edit-hero',
  templateUrl: './edit-hero.component.html',
  styleUrls: ['./edit-hero.component.css'],
})
export class EditHeroComponent implements OnInit {
  @Input() superHero?: SuperHero;
  @Output() cancelEvent = new EventEmitter();
  @Output() superHeroesUpdated = new EventEmitter<SuperHero[]>();

  constructor(private superHeroService: SuperHeroService) {}

  ngOnInit(): void {}

  cancel(): void {
    this.cancelEvent.emit();
  }

  createSuperHero(superHero: SuperHero): void {
    this.superHeroService
      .createSuperHero(superHero)
      .subscribe((heroes: SuperHero[]) => this.superHeroesUpdated.emit(heroes));
  }

  updateSuperHero(superHero: SuperHero): void {
    this.superHeroService
      .updateSuperHero(superHero)
      .subscribe((heroes: SuperHero[]) => this.superHeroesUpdated.emit(heroes));
  }

  deleteSuperHero(superHero: SuperHero): void {
    this.superHeroService
      .deleteSuperHero(superHero)
      .subscribe((heroes: SuperHero[]) => this.superHeroesUpdated.emit(heroes));
  }
}
