import { Component, Input } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Curso } from '../../models/curso';

@Component({
  selector: 'app-card-curso',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './card-curso.html',
  styleUrls: ['./card-curso.css']
})
export class CardCurso {
  @Input() curso!: Curso;
}