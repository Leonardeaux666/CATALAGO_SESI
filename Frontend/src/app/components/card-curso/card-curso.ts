import { Component, Input } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterLink } from '@angular/router';
import { Curso } from '../../models/curso';

@Component({
  selector: 'app-card-curso',
  standalone: true,
  imports: [CommonModule, RouterLink],
  templateUrl: './card-curso.html',
  styleUrl: './card-curso.css'
})
export class CardCurso {
  @Input() curso!: Curso;
}